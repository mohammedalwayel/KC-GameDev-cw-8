using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousecamera : MonoBehaviour
{
    float mouseX;
    float mousey;
   public float Sensitivity = 1f;
    public Transform player;

    public float minAngle = -90f; //عشان ما ينقلب اللاعب الحد هو ٩٠ و -٩٠
    public float maxAngle = 90f; 
    

    float rotatoin = 0f ; 
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; 
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;//this for sensivit
        mousey = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;
        rotatoin -= mousey;

        rotatoin = Mathf.Clamp(rotatoin, minAngle, maxAngle); 
        transform.localRotation = Quaternion.Euler(rotatoin, 0, 0); 
 
        player.Rotate(Vector3.up * mouseX);

            }

}
