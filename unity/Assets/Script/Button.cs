using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;

public class Button : MonoBehaviour {

	public EventSystem eventsystem; 
	public string standName; 
	public int nowRotation;

	// Use this for initialization
	void Start () {
	//	standName = "centerN"; 
		eventsystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
		nowRotation = 0;
	}

	// Update is called once per frame
	void Update () {
	}
		
	void turnL(){
		nowRotation -= 45;
		iTween.RotateTo(GameObject.Find("Player"),iTween.Hash("y", nowRotation, "time", 0.4f));
	}
	void turnR(){
		nowRotation += 45;
		iTween.RotateTo(GameObject.Find("Player"),iTween.Hash("y", nowRotation, "time", 0.4f));
	}
}