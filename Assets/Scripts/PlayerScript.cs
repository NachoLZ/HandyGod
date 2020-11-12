using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Store a reference to all the sub player scripts
    [SerializeField]
    internal PlayerInputScript inputScript = default;

    [SerializeField]
    internal PlayerMovementScript movementScript = default;

    [SerializeField]
    internal PlayerCollisionScript collisionScript = default;

    // Main player properties
    [SerializeField]
    internal int health = 10;

    [SerializeField]
    internal float walkSpeed = 0;

    [SerializeField]
    internal float jumpSpeed = 0;

    // Component references
    internal Animator anim;
    internal Rigidbody2D rb2d;
    internal SpriteRenderer spriteRenderer;


    private void Awake()
    {
        print("Main PlayerScript Awake");
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        print("PlayerScript Starting now");
    }
}
