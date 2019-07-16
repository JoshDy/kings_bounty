using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
    public void MENU_ACTION_GotoPage(string Main_Menu) //If an action is carried out this event will trigger
    {
        Application.LoadLevel(Main_Menu); //Loads the Main_Menu scene
    }
}
