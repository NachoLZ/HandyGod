using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Texture2D[] cursorTextureArray;
    [SerializeField] private int frameCount;
    [SerializeField] private float frameRate;
    private int currentFrame;
    private float frameTimer;
    

    private void Start()
    {

        Cursor.SetCursor(cursorTextureArray[0], new Vector2(140, 140), CursorMode.Auto);    
    }

    private void Update()
    {
        frameTimer -= Time.deltaTime;
        if (frameTimer <= 0f)
        {
            frameTimer += frameRate;
            currentFrame = (currentFrame + 1) % frameCount;
            Cursor.SetCursor(cursorTextureArray[currentFrame], new Vector2(140, 140), CursorMode.Auto);
        }
        
    }
}
