using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerscript : toolscript
{    
    // public Rigidbody2D hammer;
    public SpriteRenderer image;
    public Sprite hammer_unused;
    public Sprite hammer_used;


    private int mouse_clicked_frames = 0;


    // Start is called before the first frame update
    void Start()
    {
        // Cursor.SetCursor(hammer, Vector2.zero, CursorMode.Auto);
    }


    public override void Use(){
        if(mouse_clicked_frames >= 35){
            mouse_clicked_frames = 0;
            image.sprite = hammer_unused;

        } else if(mouse_clicked_frames > 0) {
            mouse_clicked_frames++;
        } else {
            if(Input.GetMouseButtonDown(0)){
                Animate();
            }
        }
        
    }

    public void Animate(){
        
            image.sprite = hammer_used;
            mouse_clicked_frames = 1;
    }
}
