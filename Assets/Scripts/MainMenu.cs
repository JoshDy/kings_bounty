using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
    public void MENU_ACTION_GotoPage(string Intro) //If an action is carried out this event will be triggered
    {
        Application.LoadLevel(Intro); //Loads the Intro scene
    }
}
