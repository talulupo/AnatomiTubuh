using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TextManager : MonoBehaviour {



	void Start(){
		if (this.tag == "Cube") {
			this.transform.localPosition = new Vector3 (transform.parent.position.x - 3f, transform.parent.position.y + 0.3f, transform.parent.position.z + 1.5f);
		}

		if (this.tag == "Capsule") {
			this.transform.localPosition = new Vector3 (transform.parent.position.x + 0.2f, transform.parent.position.y + 0.3f, transform.parent.position.z + 1.5f);
		}

		if (this.tag == "Sphere") {
			this.transform.localPosition = new Vector3 (transform.parent.position.x + 3.7f, transform.parent.position.y - 0.2f, transform.parent.position.z + 1.5f);
		}

		/*if (TouchSystem.clicked == false) {
			Debug.Log ("Hide");
			this.gameObject.SetActive (false);
		}

		if(TouchSystem.clicked == true){
			Debug.Log("show");
			this.gameObject.SetActive(true);
		}*/
	}
	
}
