using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;

	public GameObject rotationTarget;
	public float rotationSpeed = 15.0f;
	public float defaultScaleX , defaultScaleY , defaultScaleZ;
	public float currentScaleX, currentScaleY , currentScaleZ;
	
	float initialFingersDistance;
	Vector3 initialScale;
	
	void FixedUpdate () {
		// rotate object if 1 finger on touch
		if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			Debug.Log( rotationTarget.transform.rotation.y + ":"+touchDeltaPosition.x );
			rotationTarget.transform.Rotate(Vector3.forward * -touchDeltaPosition.x  * Time.deltaTime * rotationSpeed );
		}
		
		// resize object if 2 fingers on touch
		if(Input.touchCount == 2)
		{ 
			Vector3 pos = rotationTarget.transform.localPosition;
			Touch touch0 = Input.GetTouch(0);
			Touch touch1 = Input.GetTouch(1);
			
			// zoom in or zoom out object if each finger move
			if(touch0.phase == TouchPhase.Moved && touch1.phase == TouchPhase.Moved)
			{
				// calculate 2 fingers distance
				Vector2 prevDist = (touch0.position - touch0.deltaPosition) - (touch1.position - touch1.deltaPosition);
				Vector2 curDist = touch0.position - touch1.position;
				float delta = curDist.magnitude - prevDist.magnitude;
				
				if(delta > 0)
				{
					if(defaultScaleX >= currentScaleX * 4){
						
					}
					if(defaultScaleX < currentScaleX - 0.1){
						
					}
					if(defaultScaleX >= currentScaleX){
						
						defaultScaleX = defaultScaleX + 5f;
						defaultScaleY = defaultScaleY + 5f;
						defaultScaleZ = defaultScaleZ + 5f;
						//pos.y = defaultScaleY / 2;
						rotationTarget.transform.localPosition = pos;
						rotationTarget.transform.localScale = new Vector3(defaultScaleX,defaultScaleY,defaultScaleZ); 
					}
					if(defaultScaleX <= currentScaleX){
						
						defaultScaleX = defaultScaleX + 5f;
						defaultScaleY = defaultScaleY + 5f;
						defaultScaleZ = defaultScaleZ + 5f;
						//pos.y = defaultScaleY / 2;
						rotationTarget.transform.localPosition = pos;
						rotationTarget.transform.localScale = new Vector3(defaultScaleX,defaultScaleY,defaultScaleZ); 
					}
				}
				
				if(delta < 0){
					
					if(defaultScaleX <= currentScaleX){
						
					}
					if(defaultScaleX > currentScaleX){
						
						defaultScaleX = defaultScaleX - 5f;
						defaultScaleY = defaultScaleY - 5f;
						defaultScaleZ = defaultScaleZ - 5f;
						//pos.y = defaultScaleY / 2;
						rotationTarget.transform.localPosition = pos;
						rotationTarget.transform.localScale = new Vector3(defaultScaleX,defaultScaleY,defaultScaleZ);
					}
				} 
			}
		}
	}
	

	/*void OnMouseDown(){
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		
		screenPoint = Input.mousePosition + screenPoint;
		
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	void OnMouseDrag(){
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}*/
}
