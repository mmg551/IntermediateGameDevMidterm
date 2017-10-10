using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CamperCount : MonoBehaviour {
//    bool [] wasCamperCollected = new bool[12];
    public float numCollected = 0f;
	// Use this for initialization
	void Start () {
//        for (int i = 1; i <= wasCamperCollected.Length; i++)
//        {
//            wasCamperCollected[i] = GameObject.FindGameObjectWithTag("Camper").GetComponent<CamperCollection>().collected;
//        }
	}
	
	// Update is called once per frame
	void Update () {
        
        if (numCollected == 12f)
        {
            SceneManager.LoadScene(1);
        }
	}
}
