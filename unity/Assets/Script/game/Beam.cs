using UnityEngine;
using System.Collections;

public class Beam : MonoBehaviour {

	const float lazarSpeed = 0.3f;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0, 0.2f, 0);
		Destroy(this.gameObject, 5);
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, lazarSpeed);
	}
}