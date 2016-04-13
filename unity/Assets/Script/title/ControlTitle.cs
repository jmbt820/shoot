using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControlTitle : MonoBehaviour {

	public EventSystem eventsystem; 
	public GameObject ranking;
	public Text rankText;

	// Use this for initialization
	void Start () {
		rankText.GetComponent<Text>().text = "";
		ranking.gameObject.SetActive(false);
		eventsystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
		for(int i = 0; i < 5; i++) {
			rankText.GetComponent<Text>().text += (i + 1) + ":" + PlayerPrefs.GetInt("Result" + (i
				+ 1)) + "\n";
		}
	}

	public void StartButton(){
		SceneManager.LoadScene ("main");
	}

	public void RankingButton(){
		ranking.gameObject.SetActive(true);
	}

	public void RankingClose(){
		ranking.gameObject.SetActive(false);
	}

	public void SNSButton(){
		SocialConnector.Share ("あなたのスコアは○点です！!", "#spaceshoot");
	}
}

