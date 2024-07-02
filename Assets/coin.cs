using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public static event Action<int> Point;

    [SerializeField] int pointValue;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Point?.Invoke(pointValue);
            Destroy(gameObject, 0.3f);
        }
    }
}
