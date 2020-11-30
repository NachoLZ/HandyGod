using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotableThing : MonoBehaviour
{
    [SerializeField]
    int health = 2;

    [SerializeField]
    Object destructableRef;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCollisionEnter2D(Collision2D collision) {

    }

    private void OnMouseDown() {
        
        health--;

        if (health <= 0) {
            ExplodeThisGameObject();
        }

    }

    private void ExplodeThisGameObject() {

        GameObject destructable = (GameObject)Instantiate(destructableRef);

        // map the newly loaded destructable object to the x and y position of the previously destroyed barrel
        destructable.transform.position = transform.position;

        Destroy(gameObject);

    }

}
