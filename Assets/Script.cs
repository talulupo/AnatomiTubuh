using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script : MonoBehaviour {

	public GameObject PrevButton, NextButton;
	public Text NomorText; 
	public int currentLevelTulang = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void nextPageTulang(){ //jika tombol terpilih maka akan pindah ke level selanjutnya
		currentLevelTulang++;
		switch (currentLevelTulang) {
		case 1:
			Debug.Log ("NextPage 1");
			NomorText.text = currentLevelTulang.ToString();
			break;
		case 2:
			Debug.Log ("NextPage 2");
			NomorText.text = currentLevelTulang.ToString();
			break;
		case 3:
			Debug.Log ("NextPage 3");
			NomorText.text = currentLevelTulang.ToString();
			break;
		case 4:
			Debug.Log ("NextPage 4");
			NomorText.text = currentLevelTulang.ToString();
			break;
		}
	}
	
	public void prevPageTulang(){ //jika tombol terpilih maka kembali ke level sebelumnya.
		currentLevelTulang--;
		switch (currentLevelTulang) {
		case 0:
			Debug.Log ("PrevPage 0");
			NomorText.text = currentLevelTulang.ToString();
			break;
		case 1:
			Debug.Log ("PrevPage 1");
			NomorText.text = currentLevelTulang.ToString();
			break;
		case 2:
			Debug.Log ("PrevPage 2");
			NomorText.text = currentLevelTulang.ToString();
			break;
		case 3:
			Debug.Log ("PrevPage 3");
			NomorText.text = currentLevelTulang.ToString();
			break;
		}
	}
}
