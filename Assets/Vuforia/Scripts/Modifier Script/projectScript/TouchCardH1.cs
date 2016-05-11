using UnityEngine;
using System.Collections;

public class TouchCardH1 : MonoBehaviour {

	public GameObject cardSelected;
	MemoryGameH1 memoryGameH1;

	void Start(){
		memoryGameH1 = FindObjectOfType<MemoryGameH1> ();
	}

	void OnMouseDown(){ //jika kartu terpilih maka akan masuk fungsi assign di "Memorygame.cs"
		Debug.Log ("Clicked");
		cardSelected = transform.gameObject;
		memoryGameH1.assign (cardSelected);
	}
}
