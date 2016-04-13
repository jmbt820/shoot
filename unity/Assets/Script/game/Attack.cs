using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public GameObject bullet;
	public GameObject laser;
	public GameObject missile;
	private float interval;
	public int attackmode;

	// Use this for initialization
	void Start () {
		interval = 0f;
		attackmode = 0;
	}
		
	// Update is called once per frame
	void Update () {
		interval += Time.deltaTime; 
		switch (attackmode) {
		case 0:
			if (interval >= 0.5f) {
				Instantiate (bullet, new Vector3 (transform.position.x, transform.position.y, transform.position.z), transform.rotation);
				interval = 0f;
			}
			break;

		case 1:
			if (interval >= 2.5f) {
				Instantiate (laser, new Vector3 (transform.position.x, transform.position.y, transform.position.z), transform.rotation);
				interval = 0f;
			}
			break;
		
		default:
			break;
		}
	}

	public void OnClick (int number){
		attackmode = number;
	}
}