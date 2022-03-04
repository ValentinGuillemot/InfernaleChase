using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Team", menuName = "ScriptableObjects/Skill", order = 3)]
public class Skill : ScriptableObject
{
    public string SkillName;

    public EType Type = EType.Attack;

    public EDamageType damageType = EDamageType.Physical;

    public EElement Element = EElement.Neutral;

    public int NumberOfTargets = 1;

    public int NumberOfHit = 1;

    public bool HasRandomTarget = false;

    public string Description;
}

public enum EElement
{
    Neutral = 0,
    Fire,
    Water,
    Plant,
    Thunder,
    Rock,
    Wind,
    Light,
    Shadow
}

public enum EType
{
    Attack = 0,
    Heal,
    Buff,
    Self
}

public enum EDamageType
{
    Physical = 0,
    Magical
}
