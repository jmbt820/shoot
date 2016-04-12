﻿using UnityEngine;
using System.Collections;

public class Beam : MonoBehaviour {

	float bulletSpeed = 0.3f;


	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0, 0.2f, 0);
		Destroy(this.gameObject, 5);
	}
	// Update is called once per frame
	void Update () {
		
		transform.Translate(0, 0, bulletSpeed);
	}
	/*
	void OnCollisionEnter(Collision enemyCol) {
		if(enemyCol.gameObject.layer == 9){ //layer = enemy
			Destroy (gameObject);	
		}
}
*/
}