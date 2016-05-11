using UnityEngine;
using System.Collections;

public class ComparingButton : MonoBehaviour {

	public GameObject[] buttons;
	RandomizeArrow RA;
	int x;

	// Use this for initialization
	void Start () {
		x = 0;
		RA = FindObjectOfType<RandomizeArrow> ();
	}

	public void revealation(){
		if (RA.slots[x].tag == "1") {
			RA.slots[x].GetComponent<Renderer>().material = RA.materials[0];
		}
		else if (RA.slots[x].tag == "2") {
			RA.slots[x].GetComponent<Renderer>().material = RA.materials[1];
		}
		else if (RA.slots[x].tag == "3") {
			RA.slots[x].GetComponent<Renderer>().material = RA.materials[2];
		}
		else if (RA.slots[x].tag == "4") {
			RA.slots[x].GetComponent<Renderer>().material = RA.materials[3];
		}
	}

	public void Button1(){
		if (buttons[0].tag == RA.slots [x].tag) {
			RA.slots[x].GetComponent<Renderer>().material = RA.materials[x];
			Debug.Log ("Benar");
			revealation();
			x++;
		} else {
			x = 0;
			RA.next = 0;
			RA.generateTexture();
			Debug.Log ("Salah");
		}
	}

	public void Button2(){
		if (buttons[1].tag == RA.slots [x].tag) {
			RA.slots[x].GetComponent<Renderer>().material = RA.materials[x];
			Debug.Log ("Benar");
			revealation();
			x++;
		} else {
			x = 0;
			RA.next = 0;
			RA.generateTexture();
			Debug.Log ("Salah");
		}
	}

	public void Button3(){
		if (buttons[2].tag == RA.slots [x].tag) {
			RA.slots[x].GetComponent<Renderer>().material = RA.materials[x];
			Debug.Log ("Benar");
			revealation();
			x++;
		} else {
			x = 0;
			RA.next = 0;
			RA.generateTexture();
			Debug.Log ("Salah");
		}
	}

	public void Button4(){
		if (buttons[3].tag == RA.slots [x].tag) {
			RA.slots[x].GetComponent<Renderer>().material = RA.materials[x];
			Debug.Log ("Benar");
			revealation();
			x++;
		} else {
			x = 0;
			RA.next = 0;
			RA.generateTexture();
			Debug.Log ("Salah");
		}
	}

	void Update(){
		if (x == 4) {
			Debug.Log("Next Level");
			x = 0;
			RA.next = 0;
			RA.generateTexture();
		}
	}
}
