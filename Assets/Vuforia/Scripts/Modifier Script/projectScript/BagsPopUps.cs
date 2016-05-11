using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BagsPopUps : MonoBehaviour {

	//private Vector3 screenPoint;
	//private Vector3 offset;

	Animator anim;

	public GameObject choice;
	public GameObject TulangManusia;
	public GameObject TulangAngsa;
	public GameObject TulangDino;
	public GameObject CanvasBetul, CanvasSalah;
	//Canvas, 
	//Canvas guis;
	//public Text AutoText;
	bool click = false;
	//public GameObject gui;
	public static float cooldown = 3f;
	public GameObject text;

	void Start(){
		anim = choice.GetComponent<Animator> ();
		TulangManusia.SetActive (false);
		TulangAngsa.SetActive (false);
		TulangDino.SetActive (false);
		//CanvasBetul = Canvas.transform.FindChild("OdiBetul").gameObject;
		//CanvasSalah = Canvas.transform.FindChild("OdiSalah").gameObject;
		//guis = FindObjectOfType<Canvas> ();
		//AutoText.enabled = false;
		Debug.Log ("Start");
		//guis = gui.GetComponent<changeLevel> ();
		//guis = FindObjectOfType<changeLevel> ();
	}
	
	/*void OnMouseUp(){
		text.SetActive (false);
	}*/

	void Update(){
		transform.rotation = Camera.main.transform.rotation;
		if (CanvasSalah.activeSelf) {
			TulangManusia.transform.gameObject.tag = "Untagged";
			TulangAngsa.transform.gameObject.tag = "Untagged";
			TulangDino.transform.gameObject.tag = "Untagged";
		} else {
			TulangManusia.transform.gameObject.tag = "Manusia";
			TulangAngsa.transform.gameObject.tag = "Angsa";
			TulangDino.transform.gameObject.tag = "Dinosaurus";
		}
	}

	void OnMouseDown()
	{
		//text.SetActive (true);
		/*screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		
		screenPoint = Input.mousePosition + screenPoint;
		
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));*/
		//Debug.Log ("CLICK ME");
		//guis.current = transform.gameObject;
		
		if (this.tag == "Bag") {
			if (CanvasBetul.activeSelf) {
				click = false;
				choice.SetActive (false);
			} else {
				click = true;
				choice.SetActive (true);
			}
			/*if (!choice.activeSelf) {
				choice.SetActive (true);
			}*/
			Debug.Log ("Come in");
			int rand = Random.Range (1,4);
			anim.SetInteger("Pilihan", rand);
		}

		if(click == true){
			TulangManusia.SetActive (true);
			TulangAngsa.SetActive (true);
			TulangDino.SetActive (true);
			text.SetActive (true);
		}
	}

	public IEnumerator Tunggu(){
		yield return new WaitForSeconds(cooldown);
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
