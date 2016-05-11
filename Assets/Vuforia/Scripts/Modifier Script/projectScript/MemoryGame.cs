using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MemoryGame : MonoBehaviour {

	public GameObject CloseObject;
	public GameObject BackgroundPanel;
	GameObject soundObjectCard;
	AudioSource audioSourceCard;
	public GameObject card1,card2;
	public Animator anim1, anim2;
	public int CardRemaining = 6;
	//TouchCard gameCard;
	changeLevel ChangeLevel;
	public GameObject[] organT = {};
	//public BoxCollider[] boxList = {};
	//public List<BoxCollider> boxContainer;
	public GameObject boxObject;
	dontClick justDontClick;
	//bool destroyed = false;

	// Use this for initialization
	public void Start () {
		justDontClick = GameObject.Find ("clickableReference").GetComponent<dontClick>();
		//boxList = boxObject.GetComponentsInChildren<BoxCollider> ();
		//boxContainer = new List<BoxCollider> (boxObject.GetComponentsInChildren<BoxCollider> ());
		//boxContainer = new List<BoxCollider> (boxList);
		//gameCard = FindObjectOfType<TouchCard> ();
		ChangeLevel = FindObjectOfType<changeLevel>();
		soundObjectCard = GameObject.Find("CardFlip");
		audioSourceCard = soundObjectCard.GetComponent<AudioSource>();
		CloseObject.SetActive (false);
		BackgroundPanel.SetActive (false);
	}


	/*void OnDestroy(){
		destroyed = true;
	}*/

	// untuk memasukkan kartu kedalam game object kartu
	public void assign(GameObject card){
		
		Debug.Log ("ASSIGN!!!");
		if (card != null /*&& !card.CompareTag("Benar")*/) { //jika kartu 1 masih kosong maka akan di assign ke kartu 1.
			if (card1 == null) {
				if(justDontClick.clickable){
				audioSourceCard.Play();
					Debug.Log ("Assign new card onto card 1");
				card1 = card;
				anim1 = card.GetComponent<Animator> ();
				anim1.SetBool ("Flipped", true);
				}
			} else { //jika kartu 1 telah terisi maka kartu yang diisi adalah kartu 2.
				if(justDontClick.clickable){
				audioSourceCard.Play();
				Debug.Log ("Assign new card onto card 2");
				card2 = card;
				anim2 = card.GetComponent<Animator> ();
				anim2.SetBool ("Flipped", true);
				}
			}
		}
		//jika kartu 1 telah diisi dan kartu yang dipilih bukan diri sendiri
		if (card1 != null && card1 != card) {
			StartCoroutine ("compare");
		}
	}

	//fungsi pembanding antar 2 kartu
	IEnumerator compare(){
		yield return new WaitForSeconds (1f);
		if (card1 != null && card2 != null) {
			if (card1.tag == card2.tag) {
				justDontClick.clickable = false;
				Debug.Log ("MATCH !!!");
				/*foreach(BoxCollider boxCol in boxContainer){
					boxCol.enabled = false;
				}*/	
				/*card1.tag = "Benar";
				card2.tag = "Benar";
				card1 = null;
				card2 = null;
				anim1 = null;
				anim2 = null;*/
				Destroy (card1);
				Destroy (card2);



				CardRemaining -= 2;

				CloseObject.SetActive (true);
				switch(card1.tag){
				case "jantung":
					organT[0].SetActive(true);
					break;
				case "ususbesar":
					organT[1].SetActive(true);
					break;
				case "paruparu":
					organT[2].SetActive(true);
					break;
				case "ususkecil":
					organT[3].SetActive(true);
					break;
				case "ginjal":
					organT[4].SetActive(true);
					break;
				case "hati":
					organT[5].SetActive(true);
					break;
				case "lambung":
					organT[6].SetActive(true);
					break;
				case "otak":
					organT[7].SetActive(true);
					break;
				case "uterus":
					organT[8].SetActive(true);
					break;
				}
				//Time.timeScale = 0;
			} else {
				Debug.Log ("NOT MATCH!!!");
				anim1.SetBool ("Flipped", false);
				anim2.SetBool ("Flipped", false);
				card1 = null;
				card2 = null;
			}
			//boxList = boxContainer.ToArray();
		}


	}

	public void exitObject(){
		//BackgroundPanel.SetActive(false);
		organT[0].SetActive(false);
		organT[1].SetActive(false);
		organT[2].SetActive(false);
		organT[3].SetActive(false);
		organT[4].SetActive(false);
		organT[5].SetActive(false);
		organT[6].SetActive(false);
		organT[7].SetActive(false);
		organT[8].SetActive(false);
		CloseObject.SetActive (false);
		justDontClick.clickable = true;
		//SortingCard ();

		/*foreach(BoxCollider boxCol in boxContainer){
				boxCol.enabled = true;
		}*/
		//boxList = boxContainer.ToArray ();
		//jika semua kartu sudah terpilih
		if (CardRemaining == 0) {
			//ChangeLevel.FinishLevel();
			BackgroundPanel.SetActive(true);
		}

	}

	/*void SortingCard(){
		for(var i = boxContainer.Count - 1; i > -1; i--)
		{
			//Debug.Log ("index : " + boxContainer.Count);
			if (boxList[i] == null){
				boxContainer.RemoveAt(i);
				Debug.Log ("TEST");
				//Debug.Log ("Destroy" + boxContainer[i]);
			}
			Debug.Log ("index : " + boxContainer.Count);
		}
	}*/

}
