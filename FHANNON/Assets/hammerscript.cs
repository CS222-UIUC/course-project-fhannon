using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerscript : toolscript
{    
    // public Rigidbody2D hammer;
    public SpriteRenderer image;
    public Sprite hammer_unused;
    public Sprite hammer_used;

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
        if(mouse_clicked_frames >= 10){
            mouse_clicked_frames = 0;
            image.sprite = hammer_unused;

        } else if(mouse_clicked_frames > 0) {
            mouse_clicked_frames++;
        } else {
            if(Input.GetMouseButtonDown(0)){
                image.sprite = hammer_used;
                mouse_clicked_frames = 1;
            }
        }

    }
}
