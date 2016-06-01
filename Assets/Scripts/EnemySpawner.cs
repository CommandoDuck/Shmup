using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyClass;
	FlightPath enemyTween;
	public int enemiesToSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SpawnEnemy ()
	{
		for(int i = 0; i < enemiesToSpawn; i++)
		{
			GameObject enemy = Instantiate(enemyClass, transform.position, transform.rotation) as GameObject;
			enemyTween = enemy.GetComponentInChildren<FlightPath>();
			enemyTween.delay = i;
		}
	}

	void OnDrawGizmos ()
	{
		Gizmos.color = new Color(1, 0, 0, 0.5f);
		Gizmos.DrawCube(transform.position, new Vector3(0.5f,0.5f,0.5f));
	}
}
