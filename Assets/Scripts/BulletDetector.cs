using UnityEngine;
using System.Collections;

public class BulletDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Bullet" || other.tag == "EnemyBullet")
		{
			Debug.Log("Herro");
			Destroy(other.gameObject);
		}
	}
}
