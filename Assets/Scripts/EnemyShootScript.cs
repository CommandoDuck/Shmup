using UnityEngine;
using System.Collections;

public class EnemyShootScript : MonoBehaviour {

	public int shotDelay;
	public GameObject bullet;
	public Transform[] spawnLocation;
	private int _shotTimer = 0;
	HealthScript healthScript;
	
	// Use this for initialization
	void Start () {
		healthScript = gameObject.GetComponent<HealthScript>();
	}
	
	void Update () 
	{
		if(_shotTimer < 0 && !healthScript.isDead)	
		{
			for(int i = 0; i < spawnLocation.Length; i++)
			{
				GameObject shot = Instantiate(bullet, spawnLocation[i].position, spawnLocation[i].rotation) as GameObject;
				_shotTimer = shotDelay;	
			}					

		}
		else 
		{
			_shotTimer--;
		}
	}
}
