﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	[SerializeField] float maxX = 19.667f;
	[SerializeField] float minX = 1.636f;
	[SerializeField] float screenWidthInUnits = 16f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
		 Vector2 paddlePos = new Vector2 (mousePosInUnits, transform.position.y);
		 paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
		 transform.position = paddlePos;
	}
}
