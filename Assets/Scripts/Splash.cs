using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

    public float timer = 2f; //Declares a variable that can store decimal values and decides upon the amount of time that the splash screen appears on screen
    public string levelToLoad = "Main_Menu"; //Declares a variable that stores string values and chooses which scene to load

	// Use this for initialization
	void Start () {
        StartCoroutine("DisplayScene"); //If a coroutine has this name it will be run
	}
	
	IEnumerator DisplayScene()
    {
        yield return new WaitForSeconds(timer); //Uses a variable to delay the amount of time the splash screen scene is on screen before the next scene
        Application.LoadLevel(levelToLoad); //Loads the Main_Menu scene
    }
}
