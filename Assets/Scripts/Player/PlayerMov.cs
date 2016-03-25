﻿using UnityEngine;
using System.Collections;


public class PlayerMov : MonoBehaviour {
	public float moveX;
	public float moveY;
	public float speed;


	public bool moving;
	public Animator Graphics;

	public Rigidbody2D rigidBody2D;

	void Start()
	{

	}
	void Update () {
	

				
		moveY = Input.GetAxis ("Vertical");
		// Movement
		rigidBody2D.velocity = new Vector2 (moveY * speed, rigidBody2D.velocity.y);

		moveX = Input.GetAxis ("Horizontal");
		// Movement
		rigidBody2D.velocity = new Vector2 (moveX * speed, rigidBody2D.velocity.x);

		if ((moveX != 0) || (moveY != 0)) {
		
			moving = true;
			Graphics.SetBool("IsMoving",true);

		}
		if ((moveX == 0) && (moveY == 0)) {
			
			moving = false;
			Graphics.SetBool("IsMoving",false);
			
		}
	}

}