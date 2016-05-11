using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class TestDrop : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
	public Image containerImage;
	public Image receivingImage;
	private Color normalColor;
	public Color highlightColor = Color.yellow;
	GameObject obj = null;
	public int complete = 0;
	//List<Sprite> listTag;
	public Sprite contoh;
	public bool img1 = true;
	public bool img2 = true;
	complete cm;

	
	void Start(){
		obj = this.gameObject;
		cm = GameObject.Find ("GameReference").GetComponent<complete> ();
	}
	

	public void OnEnable ()
	{
		if (containerImage != null) {
			normalColor = containerImage.color;
		}
	}
	
	public void OnDrop(PointerEventData data)
	{
		var imgTag = data.pointerDrag.GetComponent<TesDrag> ();
		if (imgTag.imageTag == obj.tag) {
			containerImage.color = normalColor;
			if (receivingImage == null)
				return;
			Sprite dropSprite = GetDropSprite (data);

			if (dropSprite != null){
				receivingImage.overrideSprite = dropSprite;
				receivingImage.color = new Color(255f,255f,255f,255f);
				if(receivingImage.sprite.Equals(contoh)){
					if(this.gameObject.tag == "1" && img1 == true){
						Debug.Log ("Gambar 1");
						img1 = false;
						cm.indexPuzzle++;
					}
					if(this.gameObject.tag == "2" && img2 == true){
						Debug.Log ("Gambar 2");
						img2 = false;
						cm.indexPuzzle++;
					}
				}

			}

		}
	}


	public void OnPointerEnter(PointerEventData data)
	{
		if (containerImage == null)
			return;
		
		Sprite dropSprite = GetDropSprite (data);
		if (dropSprite != null)
			containerImage.color = highlightColor;
	}
	
	public void OnPointerExit(PointerEventData data)
	{
		if (containerImage == null)
			return;
		
		containerImage.color = normalColor;
	}
	
	private Sprite GetDropSprite(PointerEventData data)
	{

		var originalObj = data.pointerDrag;
		if (originalObj == null)
			return null;
		
		var dragMe = originalObj.GetComponent<TesDrag>();
		if (dragMe == null)
			return null;
		
		var srcImage = originalObj.GetComponent<Image>();
		if (srcImage == null)
			return null;
		contoh = srcImage.sprite;

		return srcImage.sprite;
	}
}
