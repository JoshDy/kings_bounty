using UnityEngine;
using System.Collections;

public class Walking : MonoBehaviour {

    public AudioSource walk; //Makes an audio source public so that it can be called upon throughout the code

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) //An event will trigger if the A button or D button is pushed
        {
            walk.Play(); //This audio source will play
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) //An event will trigger if the A button or D button is released
        {
            walk.Stop(); //This audio source will stop playing
        }
    }
}
