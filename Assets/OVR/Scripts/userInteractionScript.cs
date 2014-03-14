﻿using UnityEngine;
using System.Collections;

public abstract class userInteractionScript : MonoBehaviour {
	private bool moving = false;
	private int distanceToMove = 10;
	public void userInteraction() {
		moving = true;
		this.gameObject.transform.renderer.material.SetColor("_Color", Color.cyan);
		
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (moving == true && distanceToMove > 0) {
			distanceToMove--;
			this.gameObject.transform.Translate(0, Time.deltaTime * 1, 0);
		}
	}
}