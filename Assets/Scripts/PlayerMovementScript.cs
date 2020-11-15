using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    [SerializeField]
    PlayerScript playerScript = default;


    // Start is called before the first frame update
    void Start()
    {
        print("PlayerMovementScript Starting now");
        playerScript.anim.Play("Appear");
        playerScript.anim.Play("pink_idle");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerScript.inputScript.isRightPressed && !playerScript.inputScript.isGrabbing)
        {
            MovePlayerRight();
            if (playerScript.inputScript.isSpaceBarPressed && playerScript.inputScript.isGrounded)
            {
                PlayerJump();
            }
            else if (playerScript.inputScript.isSpaceBarPressed && playerScript.inputScript.canDoubleJump)
            {
                PlayerJump();
            }
        }
        else if (playerScript.inputScript.isLeftPressed && !playerScript.inputScript.isGrabbing)
        {
            MovePlayerLeft();
            if (playerScript.inputScript.isSpaceBarPressed && playerScript.inputScript.isGrounded)
            {
                PlayerJump();
            }
            else if (playerScript.inputScript.isSpaceBarPressed && playerScript.inputScript.canDoubleJump)
            {
                PlayerJump();
            }
        }
        //else if (playerScript.inputScript.isGrabbing)
        //{
        //    WallJump();
        //}
        else if (playerScript.inputScript.isSpaceBarPressed && playerScript.inputScript.isGrounded)
        {
            PlayerJump();
        }
        else if (playerScript.inputScript.isSpaceBarPressed && playerScript.inputScript.canDoubleJump)
        {
            PlayerJump();
        }
        else
        {
            StopMovement();
        }
    }

    public void TakeDamage(int damage)
    {
        playerScript.health -= damage;
        playerScript.anim.Play("pink_hit");

        if (playerScript.health <= 0)
        {
            playerScript.rb2d.velocity = new Vector2(0, 0);
            Die();
        }
    }

    private void Die()
    {
        print("Player died");
        playerScript.anim.Play("Disappear");
        GetComponent<Collider2D>().enabled = false;
        playerScript.rb2d.gravityScale = 0;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        this.enabled = false;
    }

    private void MovePlayerLeft()
    {
        playerScript.rb2d.velocity = new Vector2(-playerScript.walkSpeed, playerScript.rb2d.velocity.y);
        if (playerScript.inputScript.isGrounded)
        {
            playerScript.anim.Play("pink_run");
        }
        playerScript.spriteRenderer.flipX = true;
    }

    private void MovePlayerRight()
    {
        playerScript.rb2d.velocity = new Vector2(playerScript.walkSpeed, playerScript.rb2d.velocity.y);
        if (playerScript.inputScript.isGrounded)
        {
            playerScript.anim.Play("pink_run");
        }

        playerScript.spriteRenderer.flipX = false;
    }

    private void PlayerJump()
    {
        if (playerScript.inputScript.isGrounded)
        {
            playerScript.rb2d.velocity = new Vector2(playerScript.rb2d.velocity.x, playerScript.jumpSpeed);
            playerScript.anim.Play("pink_jump");
        }
        else
        {
            playerScript.rb2d.velocity = new Vector2(playerScript.rb2d.velocity.x, playerScript.jumpSpeed);
            playerScript.anim.Play("pink_DoubleJump");
            playerScript.inputScript.canDoubleJump = false;
        }
    }

    private void StopMovement()
    {
        playerScript.rb2d.velocity = new Vector2(0, playerScript.rb2d.velocity.y);
        if (playerScript.inputScript.isGrounded)
        {
            playerScript.anim.Play("pink_idle");
        }
    }

    //private void WallJump()
    //{
    //    playerScript.anim.Play("pink_WallJump");
    //}
}
