using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomizeCardBab2H1 : MonoBehaviour {

	public GameObject cardLayoutBab2H1;

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
		GameObject Lambung = GameObject.Find ("H1LambungCard");
		GameObject Otak = GameObject.Find ("H1OtakCard");
		GameObject UterusCard = GameObject.Find ("H1UterusCard");
		GameObject Lambung2 = GameObject.Find ("H1LambungCard2");
		GameObject Otak2 = GameObject.Find ("H1OtakCard2");
		GameObject UterusCard2 = GameObject.Find ("H1UterusCard2");
		GameObject SlotH1 = GameObject.Find ("SlotH1");
		GameObject SlotH2 = GameObject.Find ("SlotH2");
		GameObject SlotH3 = GameObject.Find ("SlotH3");
		GameObject SlotH4 = GameObject.Find ("SlotH4");
		GameObject SlotH5 = GameObject.Find ("SlotH5");
		GameObject SlotH6 = GameObject.Find ("SlotH6");


		arrayTransform = new GameObject[] {SlotH1,SlotH2,SlotH3,SlotH4,SlotH5,SlotH6};

		if (cardLayoutBab2H1.activeInHierarchy) {
			arrayObj = new GameObject[] {Lambung, Otak, UterusCard, Lambung2, Otak2, UterusCard2};
			Debug.Log("cardLayoutBab2H1");
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
