using UnityEngine;
using System.Collections;

public class ObjectAppears : MonoBehaviour {

	void Update(){
		transform.rotation = Camera.main.transform.rotation;
	}
}
