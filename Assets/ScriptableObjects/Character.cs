using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterData characterData;

    void Start()
    {
            Debug.Log("Character Name: " + characterData.characterName);
            Debug.Log("Health: " + characterData.health);
            Debug.Log("Damage: " + characterData.damage);
            Debug.Log("Defense: " + characterData.defense);
    }
}
