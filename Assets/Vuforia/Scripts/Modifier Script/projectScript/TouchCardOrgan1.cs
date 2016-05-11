using UnityEngine;
using System.Collections;

public class TouchCardOrgan1 : MonoBehaviour {

	public GameObject cardOrgan1;
	MemoryGameH1 memoryGameH1;

	void Start(){
		memoryGameH1 = FindObjectOfType<MemoryGameH1> ();
	}

	void OnMouseDown(){ //jika kartu terpilih maka akan masuk fungsi assign di "Memorygame.cs"
		Debug.Log ("Clicked");
		cardOrgan1 = transform.gameObject;
		memoryGameH1.ObjectOrgan (cardOrgan1);
	}
}