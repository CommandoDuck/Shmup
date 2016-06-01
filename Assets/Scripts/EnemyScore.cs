using UnityEngine;
using System.Collections;

public class EnemyScore : MonoBehaviour {

	public int scoreAmount;
	ScoreScript scoreScript;

	// Use this for initialization
	void Start () {
		scoreScript = GameObject.Find("Score").GetComponent<ScoreScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
