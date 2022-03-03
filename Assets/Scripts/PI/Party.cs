using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Team", menuName = "ScriptableObjects/Party", order = 2)]
public class Party : ScriptableObject
{
    [SerializeField]
    List<Character> partyMembers;

    Character[] activePartyMembers = new Character[4]; 
}
