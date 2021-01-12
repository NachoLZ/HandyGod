using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                //Replace this with whatever logic you want to use to validate the objects you want to click on
                if (hit.collider.gameObject.tag == "Cursor Manager")
                {
                    SceneManager.LoadScene(3);
                }
            }
        }

    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene(3);
    }
}
