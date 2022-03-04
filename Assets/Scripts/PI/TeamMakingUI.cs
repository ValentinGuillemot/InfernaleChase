using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TeamMakingUI : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    SelectedTeamHandler _handler;
    Character _character;
    CharacterInformationDisplay _display;

    [SerializeField]
    CharacterUI _ui;

    public void OnPointerClick(PointerEventData eventData)
    {
        _handler.AddMemberToActiveParty(_character);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _display.SetInfo(_character);
    }

    // Start is called before the first frame update
    void Start()
    {
        _handler = FindObjectOfType<SelectedTeamHandler>();
        _display = FindObjectOfType<CharacterInformationDisplay>();
        _character = _ui.Character;
    }
}
