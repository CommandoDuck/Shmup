using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	public HealthScript healthScript;

	// Use this for initialization
	void Start () {
		healthScript = healthScript.GetComponent<HealthScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DestroyParent() {
		healthScript.DestroySelf();
	}
}
