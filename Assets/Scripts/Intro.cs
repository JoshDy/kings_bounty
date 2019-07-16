using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Intro : MonoBehaviour {
    public void MENU_ACTION_GotoPage(string Level_1) //If an action is carried out this event will be triggered
    {
        Application.LoadLevel(Level_1); //Loads the Level_1 scene
    }
}
