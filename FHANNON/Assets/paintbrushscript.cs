using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintbrushscript : toolscript
{

    public SpriteRenderer image;
    public Sprite paintbrush;
    public Sprite paintbrush_after;

    public Vector2 world_position;

    private int mouse_clicked_frames = 0;

    public void Use(){
    }

    

    public override void Animate(){
        if(mouse_clicked_frames >= 10){
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
