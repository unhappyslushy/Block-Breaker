﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	[SerializeField] Paddle paddle1;
	[SerializeField] float xPush = 2f;
	[SerializeField] float yPush = 15f;
	// Use this for initialization

	Vector2 paddleToBallVector;
	bool hasStarted = false;

	void Start () {
		paddleToBallVector = transform.position - paddle1.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted)
		{
			LockBallToPaddle();
			LaunchOnMouseClick();
		}
	}

	private void LaunchOnMouseClick()
	{
		if (Input.GetMouseButtonDown(0))
		{
			hasStarted = true;
			GetComponent<Rigidbody2D>().velocity = new Vector2 (xPush, yPush);
		}
	}
	private void LockBallToPaddle()
	{
		Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
		transform.position = paddlePos + paddleToBallVector;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		GetComponent<AudioSource>().Play();
	}
}
