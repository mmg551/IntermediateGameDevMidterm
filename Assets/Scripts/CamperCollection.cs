using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CamperCollection : MonoBehaviour {

	// Use this for initialization
    //once parented it should it should be locked to the back of the player and each consecutive one is placed behind the last
    //maybe when collected, adds them to array of objects and puts them in a specific spot 
   float speed = 10f;

    public bool collected = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (collected)
        {
            Debug.Log("collected works");
            if (Vector3.Distance(gameObject.transform.position, GameObject.Find("Player").transform.position) > 5f)
            {          
                Debug.Log("other if works");
                float step = speed * Time.deltaTime;
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, GameObject.Find("Player").transform.position, step);


            }
       
	    }
        //once all the campers have been collected, one more cutscene and then you win
       
    }
    void OnTriggerEnter(Collider thing)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
//            transform.parent.SetParent(thing.transform);
           // transform.SetParent(thing.transform);

        }

    }
    void OnTriggerStay(Collider thing)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
//            transform.parent.SetParent(thing.transform);
           // transform.SetParent(thing.transform);
            Debug.Log("hi");
            if (collected == false)
            {
                GameObject.Find("Player").GetComponent<CamperCount>().numCollected += 1f;
                collected = true;
            }


                

        }
    }

    //if the player is a certain distance away from the camper, the camper moves towards the player
   
}
