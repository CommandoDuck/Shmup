using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {

	public int shotDelay;
	public GameObject bullet;
	public Transform spawnLocation;
	private int _shotTimer;
	HealthScript healthScript;

	// Use this for initialization
	void Start () {
		healthScript = gameObject.GetComponent<HealthScript>();
	}
	
	void Update () 
	{
		if(_shotTimer < 0 && !healthScript.isDead)	
		{
			if(Input.GetButton("Jump"))
			{
				GameObject shot = Instantiate(bullet, spawnLocation.position, spawnLocation.rotation) as GameObject;
				_shotTimer = shotDelay;
			}
		}
		else 
		{
			_shotTimer--;
		}
	}
}
