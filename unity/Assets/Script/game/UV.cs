using UnityEngine;
using System.Collections;

public class UV : MonoBehaviour
{

	public Rect rect;
	private Material _material;
	private int textureWidth, textureHeight;

	void Start()
	{
		_material = GetComponent<Renderer>().material;
		Texture texture = _material.mainTexture;
		textureWidth = texture.width;
		textureHeight = texture.height;
		Debug.Log(textureWidth + "/" + textureHeight);
	}
		
	void Update()
	{
		Vector2 offset, scale;
		offset = new Vector2( rect.x / textureWidth,  rect.y / textureHeight);
		scale = new Vector2( rect.width / textureWidth, rect.height / textureHeight);
		_material.SetTextureOffset("_MainTex", offset);
		_material.SetTextureScale("_MainTex", scale);
	}
}