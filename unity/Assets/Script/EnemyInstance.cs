using UnityEngine;
using System.Collections;

public class EnemyInstance : MonoBehaviour {

	public GameObject meteor;
	public GameObject player;
	private int angle;
	public float interval = 1f;
	public float radius = 100f;


	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		StartCoroutine ("CreateMeteor");
	}
		
	private IEnumerator CreateMeteor(){
		while(true){
		Instantiate (meteor, GetPosition (radius), transform.rotation);
		yield return new WaitForSeconds (interval);
			if (!player)
				yield break;
		}
	}

	public Vector3 GetPosition(float radius) {
		angle = Random.Range(0,3);
		float x = Mathf.Cos(90 * angle * Mathf.Deg2Rad) * radius;
		float z = Mathf.Sin(90 * angle * Mathf.Deg2Rad) * radius;
		return new Vector3 (x, 0, z);
	}

}
