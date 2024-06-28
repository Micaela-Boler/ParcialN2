using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private SObject weaponInformation;

    [SerializeField] private int damage;
    [SerializeField] private string name;
    [SerializeField] private float range;



    void Start()
    {
        damage = weaponInformation.Damage; 
        range = weaponInformation.Range;
        name = weaponInformation.Name;

        weaponInformation.showObjectInformation();
    }



}
