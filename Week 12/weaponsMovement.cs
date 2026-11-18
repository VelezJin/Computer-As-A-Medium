using UnityEngine;
using UnityEngine.InputSystem;

public class weaponsMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

  
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
           
        }
       
    }
}
