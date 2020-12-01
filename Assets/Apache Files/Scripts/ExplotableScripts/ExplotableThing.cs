using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotableThing : MonoBehaviour
{
    [SerializeField]
    int health = 2;

    [SerializeField]
    Object destructableRef;


    [SerializeField]
    Object explosionRef;

    bool isShaking = false;
    float shakeAmount = .2f;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start() {
     
    }

    // Update is called once per frame
    void Update() {

        if (isShaking) {
            transform.position = startPos + Random.insideUnitCircle * shakeAmount;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {

    }

    private void OnMouseDown() {
        
        health--;

        startPos = transform.position;

        if (health <= 0) {
            ExplodeThisGameObject();
        }
        else {
            isShaking = true;
            Invoke("ResetShake", .2f);
        }

    }

    private void ResetShake() {
        isShaking = false;
        transform.position = startPos;
    }


    private void ExplodeThisGameObject() {

        GameObject destructable = (GameObject)Instantiate(destructableRef);
        GameObject explosion = (GameObject)Instantiate(explosionRef);

        // map the newly loaded destructable object to the x and y position of the previously destroyed barrel
        destructable.transform.position = transform.position;

        explosion.transform.position = transform.position;

        Destroy(gameObject);

    }

}
