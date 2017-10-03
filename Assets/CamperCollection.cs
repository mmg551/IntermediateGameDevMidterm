using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamperCollection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnTriggerEnter(Collider thing)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.parent.SetParent(thing.transform);
           // transform.SetParent(thing.transform);

        }

    }
    void OnTriggerStay(Collider thing)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.parent.SetParent(thing.transform);
           // transform.SetParent(thing.transform);
        }
    }
}
