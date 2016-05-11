using UnityEngine;
using System.Collections;

public class PilihObject : MonoBehaviour {
	
	public GameObject ResetCapsule;
	public GameObject ResetSphere;

	

	void OnTriggerStay(Collider other){
		if (other.tag == "Cube") {
			Debug.Log ("SAMA !!!");
		} else if(other.tag == "Sphere"){
			Debug.Log ("BEDA Sphere !!!");
			other.transform.localPosition = ResetSphere.transform.localPosition;
		} else if(other.tag == "Capsule"){
			Debug.Log ("BEDA Capsule !!!");
			other.transform.localPosition = ResetCapsule.transform.localPosition;
		}
	}


}
