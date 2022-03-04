using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Team", menuName = "ScriptableObjects/Party", order = 2)]
public class Party : ScriptableObject
{
    [SerializeField]
    List<Character> partyMembers;

    public List<Character> Members => partyMembers;

    Character[] activePartyMembers = new Character[4];

    public Character[] ActiveParty => activePartyMembers;

    public void Initialize()
    {
        foreach (Character member in partyMembers)
            member.Initialize();

        for (int i = 0; i < activePartyMembers.Length; i++)
            activePartyMembers[i] = null;
    }

    public void AddActiveCharater(Character newPartyMember)
    {
        for (int i = 0; i < activePartyMembers.Length; i++)
        {
            if (activePartyMembers[i] == null)
            {
                activePartyMembers[i] = newPartyMember;
                return;
            }
            else if (activePartyMembers[i] == newPartyMember)
            {
                for (int j = i; j < activePartyMembers.Length - 1; j++)
                {
                    activePartyMembers[j] = activePartyMembers[j + 1];
                }
                activePartyMembers[activePartyMembers.Length - 1] = null;
                return;
            }
        }

        activePartyMembers[activePartyMembers.Length - 1] = newPartyMember;
    }
}
