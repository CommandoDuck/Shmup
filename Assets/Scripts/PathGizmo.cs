using UnityEngine;
using System.Collections;

public class PathGizmo : MonoBehaviour {

	public Transform[] path;
	public Color pathColor = Color.cyan;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnDrawGizmos() {
		
		iTween.DrawPath(path,pathColor);
		foreach(Transform child in transform){
			Gizmos.color = pathColor;
			Gizmos.DrawCube(child.transform.position, new Vector3(0.3f, 0.3f, 0.3f));
		}
	}

}
