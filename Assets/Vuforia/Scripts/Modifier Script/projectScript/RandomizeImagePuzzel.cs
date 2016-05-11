using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomizeImagePuzzel : MonoBehaviour {
	public GameObject puzzelImageLayout;

	GameObject[] arrayObj;
	GameObject[] arrayTransform;
	List<GameObject> listTransform;
	List<GameObject> listObj;

	//public bool random = false;


	void Start () {
		generateArray ();
	}

	void FixedUpdate(){
		//if (random) {
		if (arrayObj.Length > 1) {
			selectRandom ();
		}
		//random = false;
		//}
	}

	// GENERATE ARRAY
	public void generateArray(){
		GameObject Satu = GameObject.Find ("ImagePuzzel1");
		GameObject Dua = GameObject.Find ("ImagePuzzel2");
		GameObject Tiga = GameObject.Find ("ImagePuzzel3");
		GameObject Empat = GameObject.Find ("ImagePuzzel4");
		GameObject Lima = GameObject.Find ("ImagePuzzel5");
		GameObject Enam = GameObject.Find ("ImagePuzzel6");
		GameObject Tujuh = GameObject.Find ("ImagePuzzel7");
		GameObject Delapan = GameObject.Find ("ImagePuzzel8");
		GameObject Sembilan = GameObject.Find ("ImagePuzzel9");
		GameObject SlotP1 = GameObject.Find ("SlotP1");
		GameObject SlotP2 = GameObject.Find ("SlotP2");
		GameObject SlotP3 = GameObject.Find ("SlotP3");
		GameObject SlotP4 = GameObject.Find ("SlotP4");
		GameObject SlotP5 = GameObject.Find ("SlotP5");
		GameObject SlotP6 = GameObject.Find ("SlotP6");
		GameObject SlotP7 = GameObject.Find ("SlotP7");
		GameObject SlotP8 = GameObject.Find ("SlotP8");
		GameObject SlotP9 = GameObject.Find ("SlotP9");


		arrayTransform = new GameObject[] {SlotP1,SlotP2,SlotP3,SlotP4,SlotP5,SlotP6,SlotP7,SlotP8,SlotP9};

		if (puzzelImageLayout.activeInHierarchy) {
			arrayObj = new GameObject[] {Satu, Dua, Tiga, Empat, Lima, Enam, Tujuh,  Delapan, Sembilan};
			Debug.Log("puzzelImageLayout");
		}


		listTransform = new List<GameObject> (arrayTransform);
		listObj = new List<GameObject> (arrayObj);
	}

	// SELECT OBJECT FROM ARRAYOBJ AND RUN PLACEOBJECT()
	void selectRandom(){
		int rand = Random.Range (1, arrayObj.Length);
		GameObject tempObj = arrayObj [rand];
		placeObject (tempObj);
	}

	// PLACE OBJECT ON POSITION FROM ARRAYINT
	void placeObject(GameObject obj){
		int rand = Random.Range (1, arrayTransform.Length);
		obj.transform.position = arrayTransform [rand].transform.position;
		listTransform.Remove (arrayTransform[rand]);
		Debug.Log (obj);
		listObj.Remove (obj);
		arrayTransform = listTransform.ToArray ();
		arrayObj = listObj.ToArray ();
	}
}
