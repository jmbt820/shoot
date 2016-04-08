using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

	private GameObject player;

	private void Start()
	{
		player = GameObject.Find("Player");
		Destroy (gameObject, 11f);
	}

	private void Update()
	{
		if (player) {
			iTween.MoveTo(gameObject, player.transform.position, 10f); 
		}
	}

	private void OnCollisionEnter(Collision other) {
		if(other.gameObject.layer == 8){ //layer = 8:player
			Destroy (other.gameObject);	
		}
	}
}