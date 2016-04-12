using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
	public Text scoreText;
	public Text lifeText;
	public Text gameOverText;
	private bool gameOver;
	private int score;
	private int life;

	void Start ()
	{
		gameOver = false;
		lifeText.text = "";
		gameOverText.text = "";
		score = 0;
		life = 3;
		UpdateScore ();
		UpdateLife ();
	//	StartCoroutine (SpawnWaves ());
	}

	void Update ()
	{
		if (gameOver)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Time.timeScale = 1;
				Application.LoadLevel("main");
			}
		}
	}

	/*
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);

			if (gameOver)
			{
				restartText.text = "Press 'R' for Restart";
				restart = true;
				break;
			}
		}
	}
*/
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore ()
	{
		scoreText.text = "SCORE: " + score;
	}

	public void Damage ()
	{
		life -= 1;
		UpdateLife ();
		if(life <= 0){
			GameOver ();
		}
	}

	void UpdateLife ()
	{
		lifeText.text = "LIFE:";
		for(int lifepoint = life; lifepoint > 0; lifepoint--){
			lifeText.text += "☆ ";
		}
	}

	public void GameOver ()
	{
		gameOverText.text = "GAME OVER";
		gameOver = true;
		Time.timeScale = 0;
	}
}