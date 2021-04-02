using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharMaze : MonoBehaviour {
	public float speedX = 5;
	public float speedY = 5;
	private Rigidbody2D rigidBody;
	
	void Start() {
        	rigidBody = GetComponent<Rigidbody2D>();
	}

	void Update() {
		if(ScienceGameLogic.roundType%2==0) {
			// Horizontal movement
	        	rigidBody.velocity = new Vector2(Input.GetAxis("Horizontal")*speedX, rigidBody.velocity.y);
			// Vertical move detection
	        	rigidBody.velocity = new Vector2(rigidBody.velocity.x, Input.GetAxis("Vertical")*speedY);

		}
    	}

	private void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("COLLISION DETECTED!");
	}
}

