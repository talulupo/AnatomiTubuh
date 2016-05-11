using UnityEngine;
using System.Collections;

public class MemoryGameH2 : MonoBehaviour {

	public GameObject NextObjectH2;
	public GameObject BackgroundPanel;
	public GameObject closeOrgan;
	public GameObject cardOrgan, cardOrgan1, cardOrgan2;
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
	dontClickS divDontClickS;
	//bool destroyed = false;

	// Use this for initialization
	public void Start () {
		divDontClickS = GameObject.Find ("clickDivs").GetComponent<dontClickS>();
		//boxList = boxObject.GetComponentsInChildren<BoxCollider> ();
		//boxContainer = new List<BoxCollider> (boxObject.GetComponentsInChildren<BoxCollider> ());
		//boxContainer = new List<BoxCollider> (boxList);
		//gameCard = FindObjectOfType<TouchCard> ();
		ChangeLevel = FindObjectOfType<changeLevel>();
		soundObjectCard = GameObject.Find("CardFlip");
		audioSourceCard = soundObjectCard.GetComponent<AudioSource>();
		NextObjectH2.SetActive (false);
		BackgroundPanel.SetActive (false);
		closeOrgan.SetActive (false);
		cardOrgan.SetActive (false);
		cardOrgan1.SetActive (false);
		cardOrgan2.SetActive (false);
	}


	/*void OnDestroy(){
		destroyed = true;
	}*/

	// untuk memasukkan kartu kedalam game object kartu
	public void assign(GameObject card){

		Debug.Log ("ASSIGN!!!");
		if (card != null /*&& !card.CompareTag("Benar")*/) { //jika kartu 1 masih kosong maka akan di assign ke kartu 1.
			if (card1 == null) {
				if(divDontClickS.divClick){
					audioSourceCard.Play();
					Debug.Log ("Assign new card onto card 1");
					card1 = card;
					anim1 = card.GetComponent<Animator> ();
					anim1.SetBool ("Flipped", true);
				}
			} else { //jika kartu 1 telah terisi maka kartu yang diisi adalah kartu 2.
				if(divDontClickS.divClick){
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
				divDontClickS.divClick = false;
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

				NextObjectH2.SetActive (true);
				switch(card1.tag){
				case "paruparu":
					organT[0].SetActive(true);
					break;
				case "jantung":
					organT[1].SetActive(true);
					break;
				case "ginjal":
					organT[2].SetActive(true);
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

	public void nextObjectCardS(){
		//BackgroundPanel.SetActive(false);
		organT[0].SetActive(false);
		organT[1].SetActive(false);
		organT[2].SetActive(false);
		NextObjectH2.SetActive (false);
		divDontClickS.divClick = true;
		//SortingCard ();

		/*foreach(BoxCollider boxCol in boxContainer){
				boxCol.enabled = true;
		}*/
		//boxList = boxContainer.ToArray ();
		//jika semua kartu sudah terpilih
		if (CardRemaining == 0) {
			//ChangeLevel.FinishLevel();
			BackgroundPanel.SetActive(true);
			cardOrgan.SetActive (true);
			cardOrgan1.SetActive (true);
			cardOrgan2.SetActive (true);

		}

	}


	public void ObjectOrgan2(GameObject cardOrgan2){
		if (divDontClickS.divClick) {
			switch (cardOrgan2.tag) {
			case "paruparu":
				divDontClickS.divClick = false;
				organT [0].SetActive (true);
				closeOrgan.SetActive (true);
				break;
			case "jantung":
				divDontClickS.divClick = false;
				organT [1].SetActive (true);
				closeOrgan.SetActive (true);
				break;
			case "ginjal":
				divDontClickS.divClick = false;
				organT [2].SetActive (true);
				closeOrgan.SetActive (true);
				break;
			}
		}

	}


	public void CloseOrganObjectS(){
		organT[0].SetActive(false);
		organT[1].SetActive(false);
		organT[2].SetActive(false);
		closeOrgan.SetActive (false);
		divDontClickS.divClick = true;
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
