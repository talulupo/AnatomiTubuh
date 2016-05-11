using UnityEngine;
using System.Collections;

public class MemoryGameH3 : MonoBehaviour {
	public GameObject NextObjectH3;
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
	dontClickT divDontClickT;
	//bool destroyed = false;

	// Use this for initialization
	public void Start () {
		divDontClickT = GameObject.Find ("clickDivt").GetComponent<dontClickT>();
		//boxList = boxObject.GetComponentsInChildren<BoxCollider> ();
		//boxContainer = new List<BoxCollider> (boxObject.GetComponentsInChildren<BoxCollider> ());
		//boxContainer = new List<BoxCollider> (boxList);
		//gameCard = FindObjectOfType<TouchCard> ();
		ChangeLevel = FindObjectOfType<changeLevel>();
		soundObjectCard = GameObject.Find("CardFlip");
		audioSourceCard = soundObjectCard.GetComponent<AudioSource>();
		NextObjectH3.SetActive (false);
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
				if(divDontClickT.divClick){
					audioSourceCard.Play();
					Debug.Log ("Assign new card onto card 1");
					card1 = card;
					anim1 = card.GetComponent<Animator> ();
					anim1.SetBool ("Flipped", true);
				}
			} else { //jika kartu 1 telah terisi maka kartu yang diisi adalah kartu 2.
				if(divDontClickT.divClick){
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
				divDontClickT.divClick = false;
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

				NextObjectH3.SetActive (true);
				switch(card1.tag){
				case "ususkecil":
					organT[0].SetActive(true);
					break;
				case "ususbesar":
					organT[1].SetActive(true);
					break;
				case "hati":
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

	public void nextObjectCardT(){
		//BackgroundPanel.SetActive(false);
		organT[0].SetActive(false);
		organT[1].SetActive(false);
		organT[2].SetActive(false);
		NextObjectH3.SetActive (false);
		divDontClickT.divClick = true;
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


	public void ObjectOrgan3(GameObject cardOrgan3){
		if (divDontClickT.divClick) {
			switch (cardOrgan3.tag) {
			case "ususkecil":
				divDontClickT.divClick = false;
				organT [0].SetActive (true);
				closeOrgan.SetActive (true);
				break;
			case "ususbesar":
				divDontClickT.divClick = false;
				organT [1].SetActive (true);
				closeOrgan.SetActive (true);
				break;
			case "hati":
				divDontClickT.divClick = false;
				organT [2].SetActive (true);
				closeOrgan.SetActive (true);
				break;
			}
		}

	}


	public void CloseOrganObjectT(){
		organT[0].SetActive(false);
		organT[1].SetActive(false);
		organT[2].SetActive(false);
		closeOrgan.SetActive (false);
		divDontClickT.divClick = true;
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
