using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript = default;


    // Todavia no hace nada
    // Start is called before the first frame update
    void Start()
    {
        print("PlayerCollisionsScript Starting now");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sides")
        {
            print("Collision with sides");
            playerScript.inputScript.wallCollision = true;
        }
        else
        {
            playerScript.inputScript.wallCollision = false;
        }
        print("Wall collision?: " + playerScript.inputScript.wallCollision);
    }
}
