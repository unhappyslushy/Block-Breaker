﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour {
	Level level;

	private void Start()
	{
		level = FindObjectOfType<Level>();
		level.CountBreakableBlocks();
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy(gameObject);
	}
	
}

