using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch2 : MonoBehaviour
{
    public GameObject paintbrush;
    public GameObject hammer;
    public GameObject wand;


    // Start is called before the first frame update
    void Start()
    {
        // hammer..activeSelf = false;
        hammer.active = false;
        wand.active = true;
        paintbrush.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.H)||Input.GetKeyDown(KeyCode.Alpha1)) {
            hammer.active = true; 
            wand.active = false;
            paintbrush.active = false;
        }
        if ( Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.Alpha2)) {
            hammer.active = false;
            wand.active = true;
            paintbrush.active= false;
        }
        if ( Input.GetKeyDown(KeyCode.P)||Input.GetKeyDown(KeyCode.Alpha3)) {
            hammer.active = false;
            wand.active = false;
            paintbrush.active = true;
        }
    }
}
