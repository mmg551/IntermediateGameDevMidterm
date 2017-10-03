using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {
    float mouseSensitivity = 100f;
    float verticalLook = 0f; //remember our vertical mouse look eulerangle (x axis)
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X"); //horizontal mouse velocity
        float mouseY = Input.GetAxis("Mouse Y"); //vertical mouse velocity 

        //basic mouse look rotation
       // transform.Rotate(-mouseY, 0f, 0f);//up down only rotates camera
        transform.parent.Rotate(0f,mouseX *Time.deltaTime * mouseSensitivity,0f);//left/right mouse rotates entire player

        //more complex mouse look vertical rotation where we clamp it
        verticalLook -= mouseY * Time.deltaTime * mouseSensitivity; //-= to make it not inverted
        verticalLook = Mathf.Clamp(verticalLook,-85f,85f); //dont let people look straight up or down
            

        //correction pass to un-rool the camera, manually override z Euler angle to 0
        //put y back intoitself but overriding the z and overidding x degree eith our own verticalLook value
        transform.localEulerAngles = new Vector3(verticalLook,transform.localEulerAngles.y, 0f);

        //if user clicks in game window lock mouse
        if (Input.GetMouseButtonDown(0)) //0: left click 1: right click 2: middle click
        {
            Cursor.visible = false; //hide mouse cursor
            Cursor.lockState = CursorLockMode.Locked; //locks cursor to center of window
        }
	}
}
