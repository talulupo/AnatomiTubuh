using UnityEngine;
using System.Collections;

public class RotateDefaultTulang : MonoBehaviour {
	public GameObject rotationTarget;
	public float speedRotate = 5f;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(0, speedRotate, 0) * Time.deltaTime);
	}


	void FixedUpdate(){
		if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			Debug.Log( rotationTarget.transform.rotation.y + ":"+touchDeltaPosition.x );
			rotationTarget.transform.Rotate(Vector3.forward * -touchDeltaPosition.x  * Time.deltaTime * speedRotate );
		}
	}
}
