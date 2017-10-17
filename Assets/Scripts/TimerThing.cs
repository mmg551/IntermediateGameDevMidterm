using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerThing : MonoBehaviour {
    float timer= 180f;
    public Text myText;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        myText.text = "\n time left \n" + timer.ToString();

        if (timer <= 0f)
        {
            myText.text = "you lose";
        }
	}
}
