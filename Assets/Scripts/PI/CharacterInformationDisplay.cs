using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterInformationDisplay : MonoBehaviour
{
    [SerializeField]
    CharacterUI _characterBaseInformation;

    [SerializeField]
    TextMeshProUGUI _characterClass;

    [SerializeField]
    TextMeshProUGUI _attackText;
    [SerializeField]
    TextMeshProUGUI _intText;
    [SerializeField]
    TextMeshProUGUI _defenseText;

    public void SetInfo(Character p_character)
    {
        _characterBaseInformation.gameObject.SetActive(true);
        _characterBaseInformation.Init(p_character);

        _characterClass.text = p_character.Class;
        _attackText.text = p_character.Attack.ToString();
        _intText.text = p_character.Intel.ToString();
        _defenseText.text = p_character.Def.ToString();
    }
}
