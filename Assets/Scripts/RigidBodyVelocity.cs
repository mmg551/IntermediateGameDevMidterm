using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyVelocity : MonoBehaviour {
    Vector3 inputVector;
    Rigidbody rbody;
    public float moveSpeed = 5f;
    public float gravityStrength = 0.1f;
	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
	}
	
    void FixedUpdate(){
        //override velocity directly
        //only if we're not moving or pressing anything
        if (inputVector.magnitude > 0.01f) //magnitude will be close to 0 if not pressing anything
        {
            rbody.velocity = inputVector * moveSpeed + Physics.gravity * gravityStrength;
        }


//        Debug.Log(inputVector);
    }

	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");//A/D Left/Right
        float vertical = Input.GetAxis("Vertical");//W/s up/down

        //take our rotation into account for the inputVector
        inputVector = transform.right * horizontal + transform.forward * vertical;

        //normalize vecotr to avoid diagonal movement exploit
        if (inputVector.magnitude > 1)
        {
            inputVector = Vector3.Normalize(inputVector);
        }
	}

   
}
