using UnityEngine;
using System.Collections;

public class TouchCardOrgan2 : MonoBehaviour {

	public GameObject cardOrgan2;
	MemoryGameH2 memoryGameH2;

	void Start(){
		memoryGameH2 = FindObjectOfType<MemoryGameH2> ();
	}

	void OnMouseDown(){ //jika kartu terpilih maka akan masuk fungsi assign di "Memorygame.cs"
		Debug.Log ("Clicked");
		cardOrgan2 = transform.gameObject;
		memoryGameH2.ObjectOrgan2 (cardOrgan2);
	}
}