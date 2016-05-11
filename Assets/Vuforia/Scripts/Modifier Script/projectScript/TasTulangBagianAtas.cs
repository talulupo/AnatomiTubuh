using UnityEngine;
using System.Collections;

public class TasTulangBagianAtas : MonoBehaviour {


	Animator anim;
	AudioSource audioSourceCard;
	GameObject soundObjectCard;
	public GameObject gerak;
	public GameObject TulangBagianAtas;
	public GameObject PartikelBintang;
	public Material[] tasMats;
	RotateDefaultTulang rotasitengkorak;
	bool  click = false;
	Material mats;

	// Use this for initialization
	void Start () {
		rotasitengkorak = FindObjectOfType<RotateDefaultTulang> ();
		rotasitengkorak.enabled = false;
		anim = gerak.GetComponent<Animator> ();
		soundObjectCard = GameObject.Find("CardFlip");
		audioSourceCard = soundObjectCard.GetComponent<AudioSource>();
		TulangBagianAtas.SetActive (false);
		PartikelBintang.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		transform.rotation = Camera.main.transform.rotation;
	}

	void OnMouseDown(){
		if(click = true){
			rotasitengkorak.enabled = true;
			PartikelBintang.SetActive (true);
			TulangBagianAtas.SetActive (true);
			audioSourceCard.Play();
			transform.GetComponent<Renderer> ().material = tasMats [0];
			anim.SetBool ("jalan",true);
		}	
	}

}
