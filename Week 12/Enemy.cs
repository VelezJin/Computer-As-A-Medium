
using System.Collections;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    public TMP_Text enemyText;

    private bool isDying = false;

    void Start()
    {
        // Hide the text when the game starts
        enemyText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sword") && !isDying)
        {
            enemyHealth -= 10;

            if (enemyHealth <= 0)
            {
                StartCoroutine(EnemyDeath());
            }
        }
    }

    IEnumerator EnemyDeath()
    {
        isDying = true;

        // Show the enemy's last words
        enemyText.gameObject.SetActive(true);
        enemyText.text = "I'm dead skull emoji";

        // Wait 2 seconds
        yield return new WaitForSeconds(2f);

        // Destroy the enemy
        Destroy(gameObject);
    }
}
