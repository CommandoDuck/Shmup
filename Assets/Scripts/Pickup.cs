using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	public int healAmount;
	HealthScript healthScript;

	// Use this for initialization
	void Start () {
		healthScript =  GameObject.Find("Player").GetComponent<HealthScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("got health");
			healthScript.AddHealth(healAmount);
			Destroy(gameObject);
		}
	}
}
