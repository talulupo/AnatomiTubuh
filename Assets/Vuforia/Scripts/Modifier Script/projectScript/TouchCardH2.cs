using UnityEngine;
using System.Collections;

public class TouchCardH2 : MonoBehaviour {

	public GameObject cardSelected;
	MemoryGameH2 memoryGameH2;

	void Start(){
		memoryGameH2 = FindObjectOfType<MemoryGameH2> ();
	}

	void OnMouseDown(){ //jika kartu terpilih maka akan masuk fungsi assign di "Memorygame.cs"
		Debug.Log ("Clicked");
		cardSelected = transform.gameObject;
		memoryGameH2.assign (cardSelected);
	}
}
