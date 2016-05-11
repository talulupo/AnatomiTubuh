using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainCodeRhytmGame : MonoBehaviour {

	public Text ScoreText;
	public int score = 0;
	PlaySong PS;


	void Start(){
		PS = FindObjectOfType<PlaySong> ();
	}
	void Update(){
		ScoreText.text = "Score : " + score;
	}

	public void Retry(){
		PS.Start ();
	}
}
