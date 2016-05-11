using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomizeCardBab2H2 : MonoBehaviour {
	public GameObject cardLayoutBab2H2;

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
		GameObject Paruparu = GameObject.Find ("H2ParuparuCard");
		GameObject Jantung = GameObject.Find ("H2JantungCard");
		GameObject Ginjal = GameObject.Find ("H2GinjalCard");
		GameObject Paruparu2 = GameObject.Find ("H2ParuparuCard2");
		GameObject Jantung2 = GameObject.Find ("H2JantungCard2");
		GameObject Ginjal2 = GameObject.Find ("H2GinjalCard2");
		GameObject SlotS1 = GameObject.Find ("SlotS1");
		GameObject SlotS2 = GameObject.Find ("SlotS2");
		GameObject SlotS3 = GameObject.Find ("SlotS3");
		GameObject SlotS4 = GameObject.Find ("SlotS4");
		GameObject SlotS5 = GameObject.Find ("SlotS5");
		GameObject SlotS6 = GameObject.Find ("SlotS6");


		arrayTransform = new GameObject[] {SlotS1,SlotS2,SlotS3,SlotS4,SlotS5,SlotS6};

		if (cardLayoutBab2H2.activeInHierarchy) {
			arrayObj = new GameObject[] {Paruparu, Jantung, Ginjal, Paruparu2, Jantung2, Ginjal2};
			Debug.Log("cardLayoutBab2H2");
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