using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterUI : MonoBehaviour
{
    [SerializeField]
    Character _character;

    [SerializeField]
    TextMeshProUGUI _nameField;

    [SerializeField]
    Image _hpGauge;

    private float _hpGaugeSize;

    [SerializeField]
    TextMeshProUGUI _hpField;

    [SerializeField]
    Image _manaGauge;

    private float _manaGaugeSize;

    [SerializeField]
    TextMeshProUGUI _manaField;

    [SerializeField]
    Image _characterImage;

    public void Init(Character p_player)
    {
        _character = p_player;
        _nameField.text = _character.Name;
        _hpField.text = (int)_character.MaxHp + " / " + (int)_character.MaxHp;
        _manaField.text = (int)_character.MaxMana + " / " + (int)_character.MaxMana;
        _characterImage.sprite = _character.Image;

        _hpGaugeSize = _hpGauge.rectTransform.sizeDelta.x;
        _manaGaugeSize = _manaGauge.rectTransform.sizeDelta.x;

        _character.OnTookDamage += UpdateLifeGauge;
        _character.OnUsedMana += UpdateManaGauge;
    }

    private void UpdateLifeGauge()
    {
        _hpField.text = (int)_character.Hp + " / " + (int)_character.MaxHp;
        float ratio = _character.Hp / _character.MaxHp;
        _hpGauge.rectTransform.sizeDelta = new Vector2(_hpGaugeSize * ratio, _hpGauge.rectTransform.sizeDelta.y);
    }

    private void UpdateManaGauge()
    {
        _manaField.text = (int)_character.Mana + " / " + (int)_character.MaxMana;
        float ratio = _character.Mana / _character.MaxMana;
        _manaGauge.rectTransform.sizeDelta = new Vector2(_manaGaugeSize * ratio, _manaGauge.rectTransform.sizeDelta.y);
    }

    private void Start()
    {
        if (_character != null)
            Init(_character);
    }
}
