using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

	public Vector2 moveDirection = new Vector2(0.1f, 0);
	public int Damage = 1;

	// Use this for initialization
	void Start () {
		Destroy(this.gameObject, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(moveDirection);
	}
}
