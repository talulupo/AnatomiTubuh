using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Utils;

namespace game{
public class hangmangame : MonoBehaviour {

	public Text wordIndicator;
	public Text scoreIndicator;
	public Text lettersIndicator;

	private hangmanController hangman;
	private string  word;
	private char[] revealed;
	private int score;
	private bool completed;
		string s = "";
		string tmp = " ";

	// Use this for initialization
	void Start () {
		hangman = FindObjectOfType<hangmanController> ();
		reset ();
	}
	
	// Update is called once per frame
	void Update () {


		if (completed) {
				//string tmp = Input.inputString;
				if(Input.anyKeyDown){
					next ();
					return;
				}
		}

		if (s != null) {
			if (s.Length == 1 /*&& TextUtils.isAlpha (s [0])*/) {
					if (s != tmp) {
						tmp = s;
						if (!check (s.ToUpper () [0])) {
							hangman.punish ();
							
							if (hangman.isDead) {
								wordIndicator.text = word;
								completed = true;
							}
							//s = null;
						}
					}
				}
			}
		
	}

	private bool check(char c){
		bool ret = false;
		int complete = 0;
		int score = 0;

		for (int i = 0; i < revealed.Length; i++) {
			if( c == word[i]){
				ret = true;
				if(revealed[i] == 0 ){
					revealed[i] = c;
					score++;
				}
			}

			if(revealed[i] != 0){
				complete++;
			}
		}

		if (score != 0) {
			this.score = score;
			if(complete == revealed.Length){
				this.completed = true;
				this.score += revealed.Length;
			}
			
			updateWordIndicator();
			updateScoreIndicator();
		}
		return ret;
	}

	private void updateWordIndicator(){
		string displayed = "";

		for (int i = 0; i < revealed.Length; i++) {
			char c = revealed[i];
			if(c == 0){
				c = '_';
			}
			displayed += ' ';
			displayed += c;
		}

		wordIndicator.text = displayed;
	}

	private void updateScoreIndicator(){
		scoreIndicator.text = "Score : " + score;
	}

	private void setWord(string word){
		word = word.ToUpper ();
		this.word = word;
		revealed = new char[word.Length];
		lettersIndicator.text = "Letters: " + word.Length;
		updateWordIndicator ();
	}

	public void next(){
		setWord (kamus);
		completed = false;
		hangman.reset ();
	}

	public void reset(){
		score = 0;
		updateScoreIndicator ();
		next ();
	}

		public static string kamus {
			get {
				string[] kumpulanKata = {"red","blue","green","yellow","gray","black","white"};
				int acak = Random.Range (-1, 7);
				string kata = kumpulanKata [acak];
				return kata;
			}
		}


		public void Button(string w){
			s = w;
			Debug.Log (w);
			return;
		}

		public void quitButton(){
			Application.Quit();
		}

}
}
