using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;

    void Start()
    {
        manaText.text = "Mana: " + mana;
    }
    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + mana;
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            mana -= 10;
        }

    }
}
