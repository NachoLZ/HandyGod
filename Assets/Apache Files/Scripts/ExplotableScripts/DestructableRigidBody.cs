using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableRigidBody : MonoBehaviour
{
    [SerializeField]
    Vector2 forceDirection;

    [SerializeField]
    float torque;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start() {

        float randTorque = Random.Range(-50, 50);
        float randForceX = Random.Range(forceDirection.x - 50, forceDirection.x + 50);
        float randForceY = Random.Range(forceDirection.y, forceDirection.y + 50);

        forceDirection.x = randForceX;
        forceDirection.y = randForceY;

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(forceDirection);
        rb2d.AddTorque(randTorque);

        // Uncomment 
        // Invoke("DestroySelf", Random.Range(2.5f, 4f));

    }

    void DestroySelf() {
        Destroy(gameObject);
    }

}
