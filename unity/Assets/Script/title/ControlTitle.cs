using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControlTitle : MonoBehaviour {

	public EventSystem eventsystem; 

	// Use this for initialization
	void Start () {

		eventsystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void StartButton(){
		SceneManager.LoadScene ("main");
	}

	public void RankingButton(){
		SceneManager.LoadScene ("main");
	}

	public void SNSButton(){
		SocialConnector.Share ("あなたのスコアは○点です！!", "#spaceshoot");
	}
}

