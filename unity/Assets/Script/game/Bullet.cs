using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	const float bulletSpeed = 2f;

	// Use this for initialization
	void Start () {
		Destroy(this.gameObject, 5);
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, bulletSpeed);
	}
	void OnCollisionEnter(Collision enemyCol) {
		if(enemyCol.gameObject.layer == 9){ //layer = enemy
			Destroy (this.gameObject);	
		}
	}
}