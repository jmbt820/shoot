using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
	private GameObject player;
	private GameObject gameControler;
	int defence = 2;
	private void Start()
	{
		player = GameObject.Find("Player");
		Destroy (gameObject, 11f);
		gameControler = GameObject.Find("GameControler");
	}
	private void Update()
	{
		if (player) {
			iTween.MoveTo(gameObject, player.transform.position, 10f); 
		}
	}

	private void OnCollisionEnter(Collision other) {
		if (other.gameObject.layer == 8) { //layer = 8:player
			gameControler.GetComponent<GameControler>().Damage();
			Destroy(gameObject);
		} else if (other.gameObject.layer == 10) {//layer = 10: attack
			defence--;
			if(defence <= 0){
				gameControler.GetComponent<GameControler>().AddScore (10);
				Destroy(gameObject);
			}
		}
	}
}