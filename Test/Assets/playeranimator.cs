using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimator : MonoBehaviour
{

    Animator animm; 
    // Start is called before the first frame update
    void Start()
    {
        animm = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animm.SetFloat("spped", Mathf.Abs  (Input.GetAxis("Horozantal")));

        if (Input.GetKeyDown(KeyCode.Space))
        {

            animm.SetTrigger("jump");  
        }
    }
}
