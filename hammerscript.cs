using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerscript : MonoBehaviour
{    
    public Rigidbody2D hammer;

    // Start is called before the first frame update
    void Start()
    {
        // Cursor.SetCursor(hammer, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
            hammer.rotation += 45f;
            Debug.Log("yea pressed button");
    }
}
