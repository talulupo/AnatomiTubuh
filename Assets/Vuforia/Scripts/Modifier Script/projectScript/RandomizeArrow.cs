using UnityEngine;
using System.Collections;


public class RandomizeArrow : MonoBehaviour {

	public Material defaults;
	public Material[] materials;
	private int index;
	public int next;
	public GameObject[] slots;
	GameObject slot1,slot2,slot3,slot4;

	void Start(){
		index = 0;
		next = 0;
		slot1 = GameObject.Find ("Slot1");
		slot2 = GameObject.Find ("Slot2");
		slot3 = GameObject.Find ("Slot3");
		slot4 = GameObject.Find ("Slot4");
		slots = new GameObject[]{slot1,slot2,slot3,slot4};
		generateTexture ();
	}

	public void generateTexture(){
		for (int x=0; x < materials.Length; x++) {
			RandomTexture();
		}
		StartCoroutine ("RememberingSection");

	}

	public IEnumerator RememberingSection(){
		yield return new WaitForSeconds (2f);
		for (int x=0; x < materials.Length; x++) {
			slots[x].GetComponent<Renderer>().material = defaults;
		}
	}
	


	public void RandomTexture(){
		index = Random.Range (0, materials.Length);
		slots[next].GetComponent<Renderer>().material = materials[index];
		if (index == 0) {
			slots[next].tag = "1";
		}
		else if (index == 1) {
			slots[next].tag = "2";
		}
		else if (index == 2) {
			slots[next].tag = "3";
		}
		else if (index == 3) {
			slots[next].tag = "4";
		}
		next++;
	}
}
