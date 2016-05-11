using UnityEngine;
using System.Collections;

public class TouchCardH3 : MonoBehaviour {

	public GameObject cardSelected;
	MemoryGameH3 memoryGame3;


	// Use this for initialization
	void Start () {
		memoryGame3 = FindObjectOfType<MemoryGameH3> ();
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		Debug.Log ("Clicked");
		cardSelected = transform.gameObject;
		memoryGame3.assign (cardSelected);
	}
}
