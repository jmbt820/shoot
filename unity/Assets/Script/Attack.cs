using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public GameObject bullet;
	float interval;

	// Use this for initialization
	void Start () {
		interval = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		interval += Time.deltaTime; 
		if(interval >= 0.5f){
			Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z),transform.rotation);
			interval = 0f;
		}
	}
}
