using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInformationDisplay : MonoBehaviour
{
    [SerializeField]
    CharacterUI _characterBaseInformation;

    public void SetInfo(Character p_character)
    {
        _characterBaseInformation.Init(p_character);
    }
}
