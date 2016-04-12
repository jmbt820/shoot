using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
	public Text scoreText;
	public Text lifeText;
	public Text gameOverText;
	private bool gameOver;
	private int score;
	private int life;
	private AudioSource sound01;
	private AudioSource sound02;
	[SerializeField]
	private Text _textCountdown;
	GameObject meteor;

	void Start ()
	{
		gameOver = false;
		lifeText.text = "";
		gameOverText.text = "";
		score = 0;
		life = 3;
		AudioSource[] audioSources = GetComponents<AudioSource>();
		sound01 = audioSources[0];
		sound02 = audioSources[1];
		UpdateScore ();
		UpdateLife ();
		_textCountdown.text = "";
		StartCoroutine(CountdownCoroutine());

	}

	void Update ()
	{
		if (gameOver) {
			if (Input.touchCount == 1) {
					Time.timeScale = 1;
					SceneManager.LoadScene ("main");
			}
		}
	}

	IEnumerator CountdownCoroutine()
	{
		_textCountdown.gameObject.SetActive(true);

		_textCountdown.text = "3";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "2";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "1";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "GO!";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "";
		_textCountdown.gameObject.SetActive(false);
		EnemyInstance ei = this.GetComponent<EnemyInstance>();
		ei.StartMeteo();
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		sound01.PlayOneShot(sound01.clip);
		UpdateScore ();
	}

	void UpdateScore ()
	{
		scoreText.text = "SCORE: " + score;
	}

	public void Damage ()
	{
		life -= 1;
		sound02.PlayOneShot(sound02.clip);
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