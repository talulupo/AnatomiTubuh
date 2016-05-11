using UnityEngine;
using System.Collections;

public class PlaySong : MonoBehaviour {

	public GameObject RedNote;
	public GameObject BlueNote;
	public GameObject GreenNote;
	public GameObject YellowNote;


	// Use this for initialization
	public void Start () {
		StartCoroutine ("PlayingSong");
	}
	
	// Update is called once per frame
	IEnumerator PlayingSong () {
		Instantiate (RedNote,new Vector3 (-1, 6, 0), Quaternion.Euler (0, 0, 0));
		yield return new WaitForSeconds (.2f);
		Instantiate (BlueNote,new Vector3 (0, 6, 0), Quaternion.Euler (0, 0, 0));
		yield return new WaitForSeconds (.5f);
		Instantiate (GreenNote,new Vector3 (1, 6, 0), Quaternion.Euler (0, 0, 0));
		yield return new WaitForSeconds (.3f);
		Instantiate (YellowNote,new Vector3 (2, 6, 0), Quaternion.Euler (0, 0, 0));
	}
}
