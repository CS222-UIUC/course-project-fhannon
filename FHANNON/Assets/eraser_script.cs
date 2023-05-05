using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eraser_script : toolscript
{
    // Start is called before the first frame update
    public SpriteRenderer image;
    public Sprite wand_unused;
    public Sprite wand_used;

    public GameObject[] effects;

    private int mouse_clicked_frames = 0;


    void Start()
    {
        effects = GameObject.FindGameObjectsWithTag("Effect");
        //  if (effects == null)
        
    }
    
    public override void MakeEffect(){
        effects = GameObject.FindGameObjectsWithTag("Effect");

        Debug.Log("Make Effect in Eraser Script");
        
        //  Destroy(GameObject.FindGameObjectsWithTag("Effect"));
        foreach (GameObject effect in effects) {
            Debug.Log("There is an effect in effects");
        
            Destroy(effect);
        }
    }

    public override void Animate(){
        if(mouse_clicked_frames >= 10){
            mouse_clicked_frames = 0;
            image.sprite = wand_unused;

        } else if(mouse_clicked_frames > 0) {
            mouse_clicked_frames++;
        } else {
            if(Input.GetMouseButtonDown(0)){
                image.sprite = wand_used;
                mouse_clicked_frames = 1;
            }
        }

    }
}
