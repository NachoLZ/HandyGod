using UnityEngine;
using System.Collections;

public class CursorParticle : MonoBehaviour
{

    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector3.Lerp(transform.position, mousePosition, moveSpeed);
        position[2] = -1; // the Z value
        transform.position = position;


    }
}
