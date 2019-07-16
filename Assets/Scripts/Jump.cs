using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    public AudioSource jump; //Makes an audio source public so that it can be called upon throughout the code
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) //An event will trigger if the space bar is pushed
        {
            jump.Play(); //This audio source will play
        }
	
	}
}
