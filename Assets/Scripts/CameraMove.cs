using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public Vector3 moveSpeed = new Vector3 (0,0.0005f,0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(moveSpeed);
	}
}
