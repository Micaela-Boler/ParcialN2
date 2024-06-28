using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;

    [SerializeField] Text enemyHealthText;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            enemy.GetComponent<IDamageable>().TakeDamage(1);

            enemyHealthText.text = enemy.GetComponent<Enemy>().health.ToString();
        }
    }

}
