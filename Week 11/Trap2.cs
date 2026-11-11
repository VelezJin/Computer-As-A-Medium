using UnityEngine;

public class Trap2 : MonoBehaviour
{
    public GameObject trapObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            trapObject.SetActive(true);
        }
    }
}