using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Player", menuName = "ScriptableObjects/Character", order = 1)]
public class Character : ScriptableObject
{
    public Action OnTookDamage;
    public Action OnUsedMana;

    [SerializeField]
    string characterName = "Player";

    [SerializeField]
    string characterClass = "Class";

    public string Name => characterName;

    public string Class => characterClass;

    float currentLife;
    int targetLife;
    [SerializeField]
    int maxLife = 1000;

    public float Hp => currentLife;
    public float MaxHp => maxLife;

    int currentPI;
    [SerializeField]
    int maxPI = 500;

    public float Mana => currentPI;
    public float MaxMana => maxPI;

    int currentConcentration = 0;

    [SerializeField]
    int attack;
    [SerializeField]
    int intelligence;
    [SerializeField]
    int defense;

    [SerializeField]
    Sprite characterImage;

    public Sprite Image => characterImage;

    public void TakeDamage(float damage)
    {
        currentLife = Mathf.Clamp(currentLife - damage, 0.0f, maxLife);
    }
}
