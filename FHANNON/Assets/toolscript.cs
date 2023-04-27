using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolscript : MonoBehaviour
{
    public Rigidbody2D tool;

    public Vector2 world_position;

    public Vector2 mousePos;

    public GameObject effect;

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
        Animate();
        if(Input.GetMouseButtonDown(0)){
            MakeEffect();

        }

    }


   public virtual void MakeEffect(){
        world_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(effect, world_position, Quaternion.identity);
    }

    public virtual void Animate(){

    }

}
