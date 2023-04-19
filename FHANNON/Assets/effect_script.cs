using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_script : MonoBehaviour
{
    public Sprite image; // the sprite for the effect image
    private SpriteRenderer spriteRenderer; // the sprite renderer component


    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Effect";
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
}
