using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

	private GameObject player;

	private void Start()
	{
		player = GameObject.Find("Player");
	}

	private void Update()
	{
		iTween.MoveTo(gameObject, player.transform.position, 10f); 
	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.layer == 8){ //layer = 8:player
			Destroy (other.gameObject);	
		}
	}
}