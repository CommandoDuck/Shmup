using UnityEngine;
using System.Collections;

public class FlightPath : MonoBehaviour {

	//public Transform[] path;
	public float time;
	public float delay;
	public PathGizmo pathScript;


	// Use this for initialization
	void Start () {
		pathScript = pathScript.GetComponent<PathGizmo>();
		Transform[] path = pathScript.path;
		iTween.MoveTo(gameObject, iTween.Hash("path", path, "isLocal", true, "movetopath", false, "time", time, "delay", delay, "easeType", "linear"));
	}
	
	// Update is called once per frame
	void Update () {

	}

	


}
