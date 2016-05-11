using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class changeLevel : MonoBehaviour {

	GameObject soundObjectDino, soundObjectAngsa, soundObjectManusia;
	AudioSource audioSourceDino, audioSourceAngsa, audioSourceManusia;

	public GameObject tulang, tulang1, tulang2, tulang3 , tulang4, organ, organ1, organ2, PrevButtonTulang, NextButtonTulang, NextButtonOrgan, DescriptionCorrect, DescriptionWrong, current;
	public GameObject TextTanya, TextTanya1, TextTanya2, TextTanya3, TextTanya4;
	public int currentLevelTulang = 0, currentLevelOrgan = 0;
	public bool correct = false, wrong = false;
	public static float cooldown = 3f;
	MemoryGame memoryGame;
	MemoryGameH1 memoryGameH1;
	MemoryGameH2 memoryGameH2;
	MemoryGameH3 memoryGameH3;
	SelectObject selectObject;
	RandomizeCard randomCard;
	
	void Start(){
		randomCard = FindObjectOfType<RandomizeCard> ();
		selectObject = FindObjectOfType<SelectObject> ();
		memoryGame = FindObjectOfType<MemoryGame> ();
		memoryGameH1 = FindObjectOfType<MemoryGameH1> ();
		memoryGameH2 = FindObjectOfType<MemoryGameH2> ();
		memoryGameH3 = FindObjectOfType<MemoryGameH3> ();
		soundObjectDino = GameObject.Find("DinosaurusSource");
		audioSourceDino = soundObjectDino.GetComponent<AudioSource>();
		soundObjectAngsa = GameObject.Find("AngsaSource");
		audioSourceAngsa = soundObjectAngsa.GetComponent<AudioSource>();
		soundObjectManusia = GameObject.Find("ManusiaSource");
		audioSourceManusia = soundObjectManusia.GetComponent<AudioSource>();
		organ.SetActive(true);
		organ1.SetActive(false);
		organ2.SetActive(false);
		tulang.SetActive(true);
		tulang1.SetActive(false);
		tulang2.SetActive(false);
		tulang3.SetActive(false);
		tulang4.SetActive(false);
		//organ.GetComponent<MemoryGame>().enabled = true;
		//organ1.GetComponent<MemoryGame> ().enabled = false;
		//organ2.GetComponent<MemoryGame>().enabled = false;
		PrevButtonTulang.SetActive (false);
		NextButtonTulang.SetActive (false);
		NextButtonOrgan.SetActive (false);
		DescriptionCorrect.SetActive (false);

	}

	public void FinishLevel(){ //jika semua kartu telah habis dan level ini bukan level terakhir maka tombol next muncul.
		if (currentLevelOrgan != 2) {
			NextButtonOrgan.SetActive (true);
		}
	}
	
	public void nextPageTulang(){ //jika tombol terpilih paka akan pindah ke level selanjutnya
		currentLevelTulang += 1;
		switch (currentLevelTulang) {
		case 1:
			Debug.Log ("NextPage 1");
			TextTanya.SetActive(false);

			tulang.SetActive(false);
			tulang1.SetActive(true);
			tulang2.SetActive(false);
			tulang3.SetActive(false);
			tulang4.SetActive(false);
			break;
		case 2:
			Debug.Log ("NextPage 2");
			TextTanya1.SetActive(false);
			
			tulang.SetActive(false);
			tulang1.SetActive(false);
			tulang2.SetActive(true);
			tulang3.SetActive(false);
			tulang4.SetActive(false);
			break;
		case 3:
			Debug.Log ("NextPage 3");
			TextTanya2.SetActive(false);

			tulang.SetActive(false);
			tulang1.SetActive(false);
			tulang2.SetActive(false);
			tulang3.SetActive(true);
			tulang4.SetActive(false);
			break;
		case 4:
			Debug.Log ("NextPage 4");
			TextTanya3.SetActive(false);
			tulang.SetActive(false);
			tulang1.SetActive(false);
			tulang2.SetActive(false);
			tulang3.SetActive(false);
			tulang4.SetActive(true);
			break;
		}
		correct = false;
		wrong = false;
		PrevButtonTulang.SetActive (false);
		NextButtonTulang.SetActive (false);
		DescriptionCorrect.SetActive(false);
		selectObject.Kepala.SetActive (false);
		selectObject.kakiKiri.SetActive (false);
		selectObject.kakiKanan.SetActive (false);
		selectObject.rusuk.SetActive (false);
		selectObject.pelvis.SetActive (false);
		selectObject.tanganKiri.SetActive (false);
		selectObject.tanganKanan.SetActive (false);
		//selectObject.backgroundBone.SetActive(false);

	}
	
	public void prevPageTulang(){ //jika tombol terpilih maka kembali ke level sebelumnya.
		currentLevelTulang -= 1;
		switch (currentLevelTulang) {
		case 0:
			Debug.Log ("PrevPage 0");
			TextTanya1.SetActive(false);

			tulang.SetActive(true);
			tulang1.SetActive(false);
			tulang2.SetActive(false);
			tulang3.SetActive(false);
			tulang4.SetActive(false);
			break;
		case 1:
			Debug.Log ("PrevPage 1");
			TextTanya2.SetActive(false);

			tulang.SetActive(false);
			tulang1.SetActive(true);
			tulang2.SetActive(false);
			tulang3.SetActive(false);
			tulang4.SetActive(false);
			break;
		case 2:
			Debug.Log ("PrevPage 2");
			TextTanya3.SetActive(false);

			tulang.SetActive(false);
			tulang1.SetActive(false);
			tulang2.SetActive(true);
			tulang3.SetActive(false);
			tulang4.SetActive(false);
			break;
		case 3:
			Debug.Log ("PrevPage 3");
			TextTanya4.SetActive(false);

			tulang.SetActive(false);
			tulang1.SetActive(false);
			tulang2.SetActive(false);
			tulang3.SetActive(true);
			tulang4.SetActive(false);
			break;
		}
		correct = false;
		wrong = false;
		PrevButtonTulang.SetActive (false);
		NextButtonTulang.SetActive (false);
		DescriptionCorrect.SetActive(false);
		selectObject.Kepala.SetActive (false);
		selectObject.kakiKiri.SetActive (false);
		selectObject.kakiKanan.SetActive (false);
		selectObject.rusuk.SetActive (false);
		selectObject.pelvis.SetActive (false);
		selectObject.tanganKiri.SetActive (false);
		selectObject.tanganKanan.SetActive (false);
	}

	public void nextPageOrgan(){ //jika tombol terpilih maka akan pindah ke level selanjutnya.
		NextButtonOrgan.SetActive (false);
		memoryGame.CardRemaining = 6;
		currentLevelOrgan += 1;
		switch (currentLevelOrgan) {
		case 1:
			organ.SetActive(false);
			organ1.SetActive(true);
			organ2.SetActive(false);
			randomCard.generateArray();
			//organ.GetComponent<MemoryGame>().enabled = false;
			//organ1.GetComponent<MemoryGame>().enabled = true;
			//organ2.GetComponent<MemoryGame>().enabled = false;
			break;
		case 2:
			organ.SetActive(false);
			organ1.SetActive(false);
			organ2.SetActive(true);
			randomCard.generateArray();
			//memoryGame.boxContainer.Clear ();
			//organ.GetComponent<MemoryGame>().enabled = false;
			//organ1.GetComponent<MemoryGame>().enabled = false;
			//organ2.GetComponent<MemoryGame>().enabled = true;
			break;
		}
	}


	public void QuitGame(){ //jik tombol terpilih maka akan keluar aplikasi.
		Application.Quit ();
	}

	
	void Update(){ //jika tulang yang terpilih maka akan menjalankan courotine dan boolean akan di reset.
		if (wrong || correct) {
			Debug.Log ("Courotine");
			StartCoroutine ("soundLength");
			//soundLength();
			wrong = false;
			correct = false;
		}

		/*if (correct) {

		}*/


	}

	public IEnumerator soundLength(){ // jika tulang yang terpilih benar maka akan menambilkan 3d object dan suara serta text penjelasan.
		if (correct) {				  // jika tulang yang terpilih salah maka akan muncul suara.

			if (current.tag == "Manusia") {
				audioSourceManusia.Play();
				DescriptionCorrect.SetActive(true);
				yield return new WaitForSeconds(cooldown);
				audioSourceManusia.Stop();
				PrevButtonTulang.SetActive (false);
				NextButtonTulang.SetActive (false);
				Debug.Log("object 3d disembunyikan");
			}

			if (currentLevelTulang == 0) {
				Debug.Log("page 0");
				PrevButtonTulang.SetActive (false);
				NextButtonTulang.SetActive (true);
			} 
			else if (currentLevelTulang == 1) {
				Debug.Log("page 1");
				PrevButtonTulang.SetActive (true);
				NextButtonTulang.SetActive (true);
			}
			else if (currentLevelTulang == 2) {
				Debug.Log("page 2");
				PrevButtonTulang.SetActive (true);
				NextButtonTulang.SetActive (true);
			}
			else if (currentLevelTulang == 3) {
				Debug.Log("page 3");
				PrevButtonTulang.SetActive (true);
				NextButtonTulang.SetActive (true);
			}
			else if (currentLevelTulang == 4) {
				Debug.Log("page 4");
				NextButtonTulang.SetActive (false);
				PrevButtonTulang.SetActive (true);
			} 
			correct = false;
			Debug.Log (current);
		}

		if (wrong) {
			
			if (current.tag == "Dinosaurus") {
				audioSourceDino.Play();
				DescriptionWrong.SetActive(true);
				yield return new WaitForSeconds(cooldown);
				DescriptionWrong.SetActive(false);
				audioSourceDino.Stop();
			}

			if (current.tag == "Angsa") {
				audioSourceAngsa.Play();
				DescriptionWrong.SetActive(true);
				yield return new WaitForSeconds(cooldown);
				DescriptionWrong.SetActive(false);
				audioSourceAngsa.Stop();
			}
			wrong = false;
		}
	}

	public void ExitObject(){
		memoryGame.exitObject ();
		//Time.timeScale = 1;
	}

	//-----------------------------//
	//Halaman ! Bab 2
	public void SelectObjectOrgan(){
		memoryGameH1.CloseOrganObject();
	}

	public void NextObjectCardF(){
		memoryGameH1.nextObjectCardF();
		//Time.timeScale = 1;
	}

	//-----------------------------//
	//Halaman 2 Bab 2
	public void SelectObjectOrganH2(){
		memoryGameH2.CloseOrganObjectS();
	}

	public void NextObjectCardS(){
		memoryGameH2.nextObjectCardS();
		//Time.timeScale = 1;
	}

	//-----------------------------//
	//Halaman 3 Bab 3
	public void SelectObjectOrganH3(){
		memoryGameH3.CloseOrganObjectT();
	}

	public void NextObjectCardT(){
		memoryGameH3.nextObjectCardT();
		//Time.timeScale = 1;
	}


}
