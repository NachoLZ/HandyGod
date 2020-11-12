using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript = default;

    [SerializeField]
    Transform GroundCheck = default;

    [SerializeField]
    Transform RightWallgrabPoint = default;

    [SerializeField]
    Transform LeftWallgrabPoint = default;

    // WallJump Booleans
    internal bool isGrabbing = false;

    // Jumps booleans
    internal bool canDoubleJump;

    // Input booleans
    internal bool isGrounded;
    internal bool isLeftPressed;
    internal bool isRightPressed;
    internal bool isSpaceBarPressed;

    // A lil something
    private  float xScale;


    // Start is called before the first frame update
    void Start()
    {
        print("PlayerInputScript Starting now");
        xScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {

        if ((Physics2D.Linecast(transform.position, LeftWallgrabPoint.position, 1 << LayerMask.NameToLayer("Ground")) || Physics2D.Linecast(transform.position, RightWallgrabPoint.position, 1 << LayerMask.NameToLayer("Ground"))) && !isGrounded)
        {
            isGrabbing = true;
        }
        else
        {
            isGrabbing = false;
        }

        if (Physics2D.Linecast(transform.position, GroundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
            canDoubleJump = true;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            isLeftPressed = true;
        }
        else
        {
            isLeftPressed = false;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            isRightPressed = true;
        }
        else
        {
            isRightPressed = false;
        }

        if (Input.GetKeyDown("space"))
        {
            isSpaceBarPressed = true;
        }
        else
        {
            isSpaceBarPressed = false;
        }
    }
}
