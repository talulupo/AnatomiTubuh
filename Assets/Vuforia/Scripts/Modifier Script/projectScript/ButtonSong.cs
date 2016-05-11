using UnityEngine;
using System.Collections;

public class ButtonSong : MonoBehaviour {

	public int WhichButton = 1;
	public Transform GO;
	MainCodeRhytmGame MainCode;


	// Use this for initialization
	void Start () {
		MainCode = FindObjectOfType<MainCodeRhytmGame> ();
		if (WhichButton == 1) {
			GO = GameObject.Find ("RedNoteButton").transform;
		}
		if (WhichButton == 2) {
			GO = GameObject.Find ("BlueNoteButton").transform;
		}
		if (WhichButton == 3) {
			GO = GameObject.Find ("GreenNoteButton").transform;
		}
		if (WhichButton == 4) {
			GO = GameObject.Find ("YellowNoteButton").transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetButtonDown ("1")) {
			if(WhichButton == 1){
				//Red Button
				if(transform.position.y <= GO.position.y){
					Destroy(gameObject);
					MainCode.score += 100;
				}
			}

		}
		if (Input.GetButtonDown ("2")) {
			if(WhichButton == 2){
				//Blue Button
				if(transform.position.y <= GO.position.y){
					Destroy(gameObject);
					MainCode.score += 100;
				}
			}
			
		}
		if (Input.GetButtonDown ("3")) {
			if(WhichButton == 3){
				//Green Button
				if(transform.position.y <= GO.position.y){
					Destroy(gameObject);
					MainCode.score += 100;

				}
			}
			
		}
		if (Input.GetButtonDown ("4")) {
			if(WhichButton == 4){
				//Yellow Button
				if(transform.position.y <= GO.position.y){
					Destroy(gameObject);
					MainCode.score += 100;
				}
			}
			
		}
	}
}
