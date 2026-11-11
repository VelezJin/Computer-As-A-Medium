using UnityEngine;

public class HealthPack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth.health < 100)
            {
                playerHealth.health += 10;

                if (playerHealth.health > 100)
                {
                    playerHealth.health = 100;
                }
            }

            Destroy(gameObject);
        }
    }
}