using UnityEngine;
using System.Collections;

public class SelectObject : MonoBehaviour {

	//private Vector3 screenPoint;
	//private Vector3 offset;

	//public GameObject backgroundBone;
	public GameObject Kepala, tanganKiri, tanganKanan, rusuk, pelvis, kakiKiri, kakiKanan;
	//public GameObject gui;
	changeLevel guis;
	Touch touch;
	//public GameObject text;
	
	
	void Start(){
		Debug.Log ("Start");

		Kepala.SetActive (false);
		kakiKiri.SetActive (false);
		kakiKanan.SetActive (false);
		rusuk.SetActive (false);
		pelvis.SetActive (false);
		tanganKiri.SetActive (false);
		tanganKanan.SetActive (false);
		//guis = gui.GetComponent<changeLevel> ();
		guis = FindObjectOfType<changeLevel> ();
		//backgroundBone.SetActive (false);
	}

	/*void OnMouseUp(){
		text.SetActive (false);
	}*/

	void OnMouseDown()
	{
		//text.SetActive (true);
		/*screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		
		screenPoint = Input.mousePosition + screenPoint;
		
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));*/
		//Debug.Log ("CLICK ME");
		guis.current = transform.gameObject;


		if (this.tag == "Manusia") {
			Debug.Log("object 3d tampil");
			//backgroundBone.SetActive (true);
			if(transform.parent.tag == "1"){
				Debug.Log (" parent 1");
				Kepala.SetActive(true);
			}
			if(transform.parent.tag == "2"){
				Debug.Log ("parent 2");
				rusuk.SetActive(true);
			}
			if(transform.parent.tag == "3"){
				Debug.Log ("parent 3");
				tanganKiri.SetActive(true);
				tanganKanan.SetActive(true);
			}
			if(transform.parent.tag == "4"){
				Debug.Log ("parent 4");
				pelvis.SetActive(true);
			}
			if(transform.parent.tag == "5"){
				Debug.Log ("parent 5");
				kakiKiri.SetActive(true);
				kakiKanan.SetActive(true);
			}
			guis.correct = true;
			transform.parent.gameObject.SetActive (false);
		}

		else{
			guis.wrong = true;
		}
	}

	/*void OnMouseDrag()
	{
		//text.SetActive (true);
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
		//Debug.Log ("DRAG ME");
	}*/
}
