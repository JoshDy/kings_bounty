using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed; //Declares a public variable that can have a decimal value that contains the value of the players speed
    public float jumpHeight; //Declares a public variable that can have a decimal value that contains the value of the players jump height

    private Rigidbody2D rigidbody2D; //Declares a private variable which stores the information that the player can collide with objects

    public Transform groundCheck; //Declares a public variable that decides if the player is on the ground
    public float groundCheckRadius; //Declares a public variable that can have a decimal value that contains the distance between the player and the ground
    public LayerMask whatIsGround; //Declares a public variable that determines what objects are going to be used as the ground in the game
    private bool grounded; //Declares a public variable that stores the information about if the player is on the ground

    private bool doubleJumped; //Declares a private variable which stores the boolean values of true or false and determines when the player has double jumped

    void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); //Checks to see when player hits the ground

    }

    // Update is called once per frame
    void Update () {
        if (grounded) //If the player is on the ground then they can still double jump or jump once
            doubleJumped = false;

        if(Input.GetKeyDown(KeyCode.Space) && grounded) //If the player has jumped once they can still jump again or wait and double jump
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded) //If the player has double jumped they cannot jump again until they reach the ground
        {
            Jump();
            doubleJumped = true;
        }

        if (Input.GetKey(KeyCode.D)) //Controls how the players move speed to the right is determined
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
            rigidbody2D.velocity = new Vector2(moveSpeed, rigidbody2D.velocity.y); //Adds a option to the player object to increase move speed to the right
        }

        if (Input.GetKey(KeyCode.A)) //Controls how the players move speed to the left is determined
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
            rigidbody2D.velocity = new Vector2(-moveSpeed, rigidbody2D.velocity.y); //Adds a option to the player object to increase move speed to the left
        }
    }

    public void Jump() //Controls how the players jump height is determined
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); 
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpHeight); //Adds a option to the player object to increase jump height
    }

    void OnTriggerEnter2D(Collider2D col) //Checks if the player is colliding with a trigger
    {
        if (col.gameObject.tag == "Trig01") //If the player has collided with a certain trigger an event will execute
        {
            Application.LoadLevel("End_Game"); //The scene End_Game is loaded
        }
    }

}
