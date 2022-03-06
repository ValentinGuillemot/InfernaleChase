using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUI : MonoBehaviour
{
    [SerializeField]
    Party team;

    [SerializeField]
    List<CharacterUI> charactersUI;

    // Start is called before the first frame update
    void Start()
    {
        Character[] activeParty = team.ActiveParty;
        for (int i = 0; i < activeParty.Length; i++)
            charactersUI[i].Init(activeParty[i]);
    }
}
