using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/Mouse Look")]
public class SkyCamera : MonoBehaviour {

	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 15F;
	float rotationY = 0F;
	float rotationX = 0F;

	void Update ()
	{
		if(GameControler.gameOver != true){
			if (axes == RotationAxes.MouseXAndY){
			rotationX += 0.05f ;
			transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
			}
			else if (axes == RotationAxes.MouseX){
				transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
			}
		}
	}

	void Start ()
	{
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
	}
}