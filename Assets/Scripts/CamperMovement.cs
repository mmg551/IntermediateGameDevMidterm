using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamperMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray camperRay = new Ray(transform.position, transform.forward);

        //Step 2. declare max distance
        float maxRayDistance = 2f; //tune this number

        //step 3.  visualize the raycast
        Debug.DrawRay(camperRay.origin,camperRay.direction *maxRayDistance, Color.yellow);

        //step 4 actually shoot the raycast

        if (Physics.Raycast(camperRay, maxRayDistance))
        {
            Debug.Log("camper sees something");
            //if sees a wall in front, turns 50% left or right
            if (Random.Range(0f, 100f) > 50f)
            {
                transform.Rotate(0f, 90f, 0f);  
            }
            else
            {
                transform.Rotate(0f, -90f, 0f);
            }
        }
        else//raycast failed so move forward
        {//move forward based on rotation
            transform.Translate(0f, 0f, 15f * Time.deltaTime);
        }
    }
	
}
