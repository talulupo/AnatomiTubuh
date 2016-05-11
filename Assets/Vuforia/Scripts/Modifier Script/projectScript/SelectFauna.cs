using UnityEngine;
using System.Collections;

public class SelectFauna : MonoBehaviour {

	ParticleSystem objectSelected;
	public GameObject AlloDesc;
	public GameObject SatroDesc;

	void Start(){
		objectSelected = GameObject.Find ("Life Stream").GetComponent<ParticleSystem> ();
	}

	void OnMouseDown() {
		objectSelected.transform.position = this.gameObject.transform.position;
		objectSelected.Play ();
		Debug.Log ("Play");
		if (this.name == "Allosaurus") {
			Debug.Log ("Allosaurus");
			AlloDesc.SetActive (true);
			SatroDesc.SetActive (false);
		} else {
			Debug.Log ("Satrosaurus");
			SatroDesc.SetActive (true);
			AlloDesc.SetActive (false);
		}
	}
}
