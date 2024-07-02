using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("INTERFACE")]

    [SerializeField] GameObject enemy;

    [SerializeField] Text enemyHealthText;


    [Header("EVENTO")]

    [SerializeField] Text scoreText;

    int pointQuantity;



    // INTERFACE //

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            enemy.GetComponent<IDamageable>().TakeDamage(1);

            enemyHealthText.text = enemy.GetComponent<Enemy>().health.ToString();
        }
    }



    // EVENTO //

    void UpdateScore(int pointValue)
    {
        pointQuantity += pointValue;

        scoreText.text = "Puntaje: " + pointQuantity;
    }


    private void OnEnable()
    {
        coin.Point += UpdateScore;
    }

    private void OnDisable()
    {
       coin.Point -= UpdateScore;
    }

}
