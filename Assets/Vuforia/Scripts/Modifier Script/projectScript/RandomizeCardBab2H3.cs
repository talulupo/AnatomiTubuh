using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomizeCardBab2H3 : MonoBehaviour {

	public GameObject cardLayoutBab2H3;

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
		if (arrayObj.Length > 0) {
			selectRandom ();
		}
		//random = false;
		//}
	}

	// GENERATE ARRAY
	public void generateArray(){
		GameObject UsusHalus = GameObject.Find ("H3UsusHalusCard");
		GameObject UsusBesar = GameObject.Find ("H3UsusBesarCard");
		GameObject Hati = GameObject.Find ("H3HatiCard");
		GameObject UsusHalus2 = GameObject.Find ("H3UsusHalusCard2");
		GameObject UsusBesar2 = GameObject.Find ("H3UsusBesarCard2");
		GameObject Hati2 = GameObject.Find ("H3HatiCard2");
		GameObject SlotT1 = GameObject.Find ("SlotT1");
		GameObject SlotT2 = GameObject.Find ("SlotT2");
		GameObject SlotT3 = GameObject.Find ("SlotT3");
		GameObject SlotT4 = GameObject.Find ("SlotT4");
		GameObject SlotT5 = GameObject.Find ("SlotT5");
		GameObject SlotT6 = GameObject.Find ("SlotT6");


		arrayTransform = new GameObject[] {SlotT1,SlotT2,SlotT3,SlotT4,SlotT5,SlotT6};

		if (cardLayoutBab2H3.activeInHierarchy) {
			arrayObj = new GameObject[] {UsusHalus, UsusBesar, Hati, UsusHalus2, UsusBesar2, Hati2};
			Debug.Log("cardLayoutBab2H3");
		}


		listTransform = new List<GameObject> (arrayTransform);
		listObj = new List<GameObject> (arrayObj);
	}

	// SELECT OBJECT FROM ARRAYOBJ AND RUN PLACEOBJECT()
	void selectRandom(){
		int rand = Random.Range (0, arrayObj.Length);
		GameObject tempObj = arrayObj [rand];
		placeObject (tempObj);
	}

	// PLACE OBJECT ON POSITION FROM ARRAYINT
	void placeObject(GameObject obj){
		int rand = Random.Range (0, arrayTransform.Length);
		obj.transform.position = arrayTransform [rand].transform.position;
		listTransform.Remove (arrayTransform[rand]);
		Debug.Log (obj);
		listObj.Remove (obj);
		arrayTransform = listTransform.ToArray ();
		arrayObj = listObj.ToArray ();
	}
}