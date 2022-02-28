using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "ScriptableObjects/Character", order = 1)]
public class Character : ScriptableObject
{
    [SerializeField]
    string characterName = "Player";

    float currentLife;
    int targetLife;
    [SerializeField]
    int maxLife = 1000;

    int currentPI;
    [SerializeField]
    int maxPI = 500;

    int currentConcentration = 0;

    [SerializeField]
    int attack;
    [SerializeField]
    int intelligence;
    [SerializeField]
    int defense;

    [SerializeField]
    Sprite characterImage;
}
