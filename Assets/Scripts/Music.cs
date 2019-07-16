using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

    void Awake() //Runs this code when the game starts
    {
        DontDestroyOnLoad(this.gameObject); //Makes sure that an object is continuos throughout all scenes
    }
}
