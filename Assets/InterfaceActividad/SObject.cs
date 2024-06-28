using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ScriptableObjectName", menuName = "Weapon")]

public class SObject : ScriptableObject
{
    [SerializeField] private int damage;
    [SerializeField] private string name;
    [SerializeField] private float range;


    public string Name { get { return name; } }
    public float Range { get { return range; } }
    public int Damage { get { return damage; } }


    public void showObjectInformation()
    {
        Debug.Log("Name: " + name + " Damage: " + damage + " Range: " + range);
    }
}
