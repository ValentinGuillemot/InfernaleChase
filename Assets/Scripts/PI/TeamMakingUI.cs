using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TeamMakingUI : MonoBehaviour, IPointerClickHandler
{
    SelectedTeamHandler _handler;
    Character _character;

    [SerializeField]
    CharacterUI _ui;

    public void OnPointerClick(PointerEventData eventData)
    {
        _handler.AddMemberToActiveParty(_character);
    }

    // Start is called before the first frame update
    void Start()
    {
        _handler = FindObjectOfType<SelectedTeamHandler>();
        _character = _ui.Character;
    }

}
