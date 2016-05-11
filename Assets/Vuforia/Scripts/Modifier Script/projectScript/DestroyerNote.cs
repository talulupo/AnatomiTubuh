using UnityEngine;
using System.Collections;

public class DestroyerNote : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Note") {
			Destroy (other.gameObject);
		}
	}
}
