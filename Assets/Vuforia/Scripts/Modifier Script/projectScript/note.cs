using UnityEngine;
using System.Collections;

public class note : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		 transform.Translate(new Vector3(0,-3,0) * Time.deltaTime);
	}
}
