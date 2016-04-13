using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;

public class Button : MonoBehaviour {

	public EventSystem eventsystem; 
	public int nowRotation;

	// Use this for initialization
	void Start () {
		eventsystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
		nowRotation = 0;
	}
		
	void TurnL(){
		nowRotation -= 45;
		iTween.RotateTo(GameObject.Find("Player"),iTween.Hash("y", nowRotation, "time", 0.4f));
	}

	void TurnR(){
		nowRotation += 45;
		iTween.RotateTo(GameObject.Find("Player"),iTween.Hash("y", nowRotation, "time", 0.4f));
	}
}