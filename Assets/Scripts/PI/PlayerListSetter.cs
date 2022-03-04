using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerListSetter : MonoBehaviour
{
    [SerializeField]
    Party team;

    [SerializeField]
    GameObject characterDataPrefab;

    [SerializeField]
    GameObject layoutGroupParent;

    // Start is called before the first frame update
    void Start()
    {
        team.Initialize();

        foreach (Character member in team.Members)
        {
            GameObject character = Instantiate(characterDataPrefab, layoutGroupParent.transform);
            CharacterUI ui = character.GetComponent<CharacterUI>();
            ui.Init(member);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
