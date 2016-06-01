using UnityEngine;
using System.Collections;

public class SpawnArea : MonoBehaviour {

	EnemySpawner spawner;

	void OnDrawGizmos ()
	{
		Gizmos.color = new Color(0, 1, 1, 0.5f);
		Gizmos.DrawCube(transform.position, new Vector3(10,2,1));
	}

	public void SpawnChilren()
	{
		foreach(Transform child in transform)
		{
			if(child.tag == "Spawner")
			{
				spawner = child.GetComponent<EnemySpawner>();
				spawner.SpawnEnemy();
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "SpawnTrigger")
		{
			SpawnChilren();
		}
	}
}
