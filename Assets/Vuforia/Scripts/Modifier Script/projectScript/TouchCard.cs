using UnityEngine;
using System.Collections;

public class TouchCard : MonoBehaviour {

	public GameObject cardSelected;
	MemoryGame memoryGame;

	void Start(){
		memoryGame = FindObjectOfType<MemoryGame> ();
	}

	void OnMouseDown(){ //jika kartu terpilih maka akan masuk fungsi assign di "Memorygame.cs"
		Debug.Log ("Clicked");
		cardSelected = transform.gameObject;
		memoryGame.assign (cardSelected);
	}
}
