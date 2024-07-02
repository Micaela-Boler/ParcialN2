using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Character Data")]

public class CharacterData : ScriptableObject
{
        public string characterName;
        public int health;
        public int damage;
        public int defense;
}

