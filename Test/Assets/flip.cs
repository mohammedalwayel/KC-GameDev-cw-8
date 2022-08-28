using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    SpriteRenderer sprite;
    bool faceright = true; 


    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        fipplayer();    
    }

    void fipplayer()
    {

        if(Input.GetKeyDown(KeyCode.D)&& faceright == false)
        {

            sprite.flipX = false;
            faceright = true; 
        }

       else if (Input.GetKeyDown(KeyCode.A) && faceright == true)
        {

            sprite.flipX = true;
            faceright = false;
        }
    }
}
