using UnityEngine;
using System.Collections;

public class TouchCardOrgan3 : MonoBehaviour {

	public GameObject cardOrgan3;
	MemoryGameH3 memoryGame3;

	// Use this for initialization
	void Start () {
		memoryGame3 = FindObjectOfType<MemoryGameH3> ();
	}


	void OnMouseDown(){
		Debug.Log ("Clicked");
		cardOrgan3 = transform.gameObject;
		memoryGame3.ObjectOrgan3 (cardOrgan3);
	}

}
