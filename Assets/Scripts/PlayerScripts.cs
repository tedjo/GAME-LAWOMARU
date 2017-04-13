using UnityEngine;
using System.Collections;

public class PlayerScripts : MonoBehaviour {

    public float speedChar = 2f;
    public float powerJump = 5f;
    Rigidbody2D rigidBody;

    private Vector2 movement;

	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        movement = Vector2.zero;
	}
	
	void Update () {
        GetInputMove();
        GetInputJump();
	}

    void GetInputMove()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.velocity = new Vector2(-speedChar, rigidBody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.velocity = new Vector2(speedChar, rigidBody.velocity.y);
        }
    }

    public void GetInputJump()
    {
         
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, powerJump);
        }
    }

}
