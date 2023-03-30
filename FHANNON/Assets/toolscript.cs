using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolscript : MonoBehaviour
{
    public Rigidbody2D tool;

    // public Effect effectPrefab; // the prefab of the effect to create

    // private bool isEffectActive = false; // whether the effect is currently active

    // private SpriteRenderer sprite_renderer;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        tool.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        Use();
    }

    public virtual void Use(){
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("use");
        }

    }



    // void setSprite(){
    //     // sprite_renderer.sortingOrder = m_Order.0;
    // }
}
