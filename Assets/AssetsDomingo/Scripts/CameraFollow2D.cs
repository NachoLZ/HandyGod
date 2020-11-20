using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    [SerializeField]
    GameObject player = default;

    [SerializeField]
    float timeOffset = default;

    [SerializeField]
    Vector2 posOffset = default;


    //// Start is called before the first frame update
    void Start()
    {
        print("CameraFollow2D is starting");
    }

    // Update is called once per frame
    void Update()
    {
        // Cameras start position
        Vector3 startPos = transform.position;

        // Player current position
        Vector3 endPos = player.transform.position;
        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z = -10;

        transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);
    }
}
