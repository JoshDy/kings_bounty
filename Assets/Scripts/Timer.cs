using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Gives access to the UI objects in unity

public class Timer : MonoBehaviour
{
    public int timeLeft = 60; //Sets the amount of seconds that are going to be used in the countdown timer
    public Text countdownText; //Creates a variable that will store what text to use in the timer when the game is running

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime"); //If a coroutine has this name it will be run
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left : " + timeLeft); //Determines what the text value of this variable is so that it can be updated in the game

        if (timeLeft <= 0) //Switches to the End_Game scene if this variable reaches this value
        {
            StopCoroutine("LoseTime"); //If a coroutine has this name it will stop running
            Application.LoadLevel("End_Game"); //The End_Game scene will be loaded
        }
    }

    IEnumerator LoseTime()
    {
        while (true) //If this coroutine is still running then the countdown timer will count down
        {
            yield return new WaitForSeconds(1); //Determines how many seconds should be delayed before the value of the countdown timer goes down
            timeLeft--; //Reduces the value of the countdown timer
        }
    }
}
