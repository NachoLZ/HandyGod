using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField]
    PlayerScript playerScript = default;

    [SerializeField]
    int numOfHearts;

    [SerializeField]
    Image[] hearts;

    [SerializeField]
    Sprite fullHeart;

    [SerializeField]
    Sprite emptyheart;

    // Start is called before the first frame update
    void Start()
    {
        print("PlayerHealthScript Starting now");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.health > numOfHearts)
        {
            numOfHearts = playerScript.health;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerScript.health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyheart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        
    }
}
