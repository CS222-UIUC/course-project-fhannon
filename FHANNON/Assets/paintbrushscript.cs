using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintbrushscript : toolscript
{


    // public Rigidbody2D hammer;
    public SpriteRenderer image;
    public Sprite paintbrush;
    public Sprite paintbrush_after;

    // public GameObject effect;

    public Vector2 world_position;

    // public Vector2 mousePos;


    private int mouse_clicked_frames = 0;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    public void Use(){
    }

    

    public override void Animate(){
        if(mouse_clicked_frames >= 35){
            mouse_clicked_frames = 0;
            image.sprite = paintbrush;

        } else if(mouse_clicked_frames > 0) {
            mouse_clicked_frames++;
        } else {
            if(Input.GetMouseButtonDown(0)){
                image.sprite = paintbrush_after;
                mouse_clicked_frames = 1;
            }
        }

    }
}
