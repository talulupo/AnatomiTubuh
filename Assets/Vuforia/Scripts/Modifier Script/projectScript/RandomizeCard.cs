using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class RandomizeCard : MonoBehaviour {

	public GameObject cardLayout;
	public GameObject cardLayout1;
	public GameObject cardLayout2;

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
		GameObject Jantung = GameObject.Find ("JantungCard");
		GameObject Paruparu = GameObject.Find ("ParuparuCard");
		GameObject UsusBesar = GameObject.Find ("UsusBesarCard");
		GameObject Jantung2 = GameObject.Find ("JantungCard2");
		GameObject UsusBesar2 = GameObject.Find ("UsusBesarCard2");
		GameObject Paruparu2 = GameObject.Find ("ParuparuCard2");
		GameObject UsusKecil = GameObject.Find ("UsusKecilCard");
		GameObject Ginjal = GameObject.Find ("GinjalCard");
		GameObject Ginjal2 = GameObject.Find ("GinjalCard2");
		GameObject Hati = GameObject.Find ("HatiCard");
		GameObject UsusKecil2 = GameObject.Find ("UsusKecilCard2");
		GameObject Hati2 = GameObject.Find ("HatiCard2");
		GameObject Lambung = GameObject.Find ("LambungCard");
		GameObject Otak = GameObject.Find ("OtakCard");
		GameObject KandungKemih = GameObject.Find ("KandungKemihCard");
		GameObject Lambung2 = GameObject.Find ("LambungCard2");
		GameObject Otak2 = GameObject.Find ("OtakCard2");
		GameObject KandungKemih2 = GameObject.Find ("KandungKemih2");
		GameObject Slot1 = GameObject.Find ("Slot1");
		GameObject Slot2 = GameObject.Find ("Slot2");
		GameObject Slot3 = GameObject.Find ("Slot3");
		GameObject Slot4 = GameObject.Find ("Slot4");
		GameObject Slot5 = GameObject.Find ("Slot5");
		GameObject Slot6 = GameObject.Find ("Slot6");

		
		arrayTransform = new GameObject[] {Slot1,Slot2,Slot3,Slot4,Slot5,Slot6};

		if (cardLayout.activeInHierarchy) {
			arrayObj = new GameObject[] {Jantung, Paruparu, UsusBesar, Jantung2, UsusBesar2, Paruparu2};
			Debug.Log("cardLayout");
		}
		if (cardLayout1.activeInHierarchy) {
			arrayObj = new GameObject[] {UsusKecil, Ginjal, Ginjal2, Hati, UsusKecil2, Hati2};
			Debug.Log("cardLayout1");
		}
		if (cardLayout2.activeInHierarchy) {
			arrayObj = new GameObject[] {Lambung, Otak, KandungKemih, Lambung2, Otak2, KandungKemih2};
			Debug.Log("cardLayout2");
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
