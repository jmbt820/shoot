using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;

public class Button : MonoBehaviour {

	public EventSystem eventsystem; 
	public string standName; 

	// Use this for initialization
	void Start () {
		standName = "centerN"; //現在の立ち位置 =　北向き
		eventsystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
	}

	// Update is called once per frame
	void Update () {
	}

	public void turnL () {
		switch(standName){
		case "centerN":
			iTween.RotateTo(GameObject.Find("Player"),iTween.Hash(
				"x",0, "y",270, "z",0, "time", 0.4, "islocal", true
			));
			standName = "centerW";
			break;
		case "centerW":
			iTween.RotateTo(GameObject.Find("Player"),iTween.Hash(
				"x",0, "y",180, "z",0, "time", 0.4, "islocal", true
			));
			standName = "centerS";
			break;
		case "centerS":
			iTween.RotateTo(GameObject.Find("Player"),iTween.Hash(
				"x",0, "y",90, "z",0, "time", 0.4, "islocal", true
			));
			standName = "centerE";
			break;
		case "centerE":
			iTween.RotateTo(GameObject.Find("Player"),iTween.Hash(
				"x",0, "y",0, "z",0, "time", 0.4, "islocal", true
			));
			standName = "centerN";
			break;
		}
	}

	public void turnR () {
		switch(standName){
		case "centerN":
			iTween.RotateTo(GameObject.Find("Player"),iTween.Hash(
				"x",0, "y",90, "z",0, "time", 0.4, "islocal", true
			));
			standName = "centerE";
			break;
		case "centerW":
			iTween.RotateTo(GameObject.Find("Player"),iTween.Hash(
				"x",0, "y",0, "z",0, "time", 0.4, "islocal", true
			));
			standName = "centerN";
			break;
		case "centerS":
			iTween.RotateTo(GameObject.Find("Player"),iTween.Hash(
				"x",0, "y",270, "z",0, "time", 0.4, "islocal", true
			));
			standName = "centerW";
			break;
		case "centerE":
			iTween.RotateTo(GameObject.Find("Player"),iTween.Hash(
				"x",0, "y",180, "z",0, "time", 0.4, "islocal", true
			));
			standName = "centerS";
			break;
		}
	}
}