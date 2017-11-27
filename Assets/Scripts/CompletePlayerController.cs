using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletePlayerController : MonoBehaviour {
    public float speed;
	float inputX;
	float inputY;
    private Rigidbody2D rb2d;
    public Vector2 speedd = new Vector2(10, 10);

    private Vector2 movement = new Vector2(1, 1);



    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        movement = new Vector2(
        speedd.x * inputX,
        speedd.y * inputY);

        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }
    }
    void FixedUpdate()

    {
        

		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis("Horizontal");

		//Store the current vertical input in the float moveVertical.
		float moveVertical = Input.GetAxis("Vertical");

		//Use the two store floats to create a new Vector2 variable movement.
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.AddForce(movement * speed);
}
}