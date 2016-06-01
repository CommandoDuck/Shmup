using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	
	public int health = 1;
	public string hurtTag;
	public GameObject hitEffect;
	public GameObject theGuy;
	public GameObject deathEffect;
	Animator anim;
	public bool isDead = false;
	public AudioSource deathExplosion;
	public HealthGUI healthGUIScript;
	public int scoreAmount;
	ScoreScript scoreScript;
	public GameObject[] pickUps;
	
	// Use this for initialization
	void Start () {
		
		healthGUIScript = GameObject.Find("HealthContainer").gameObject.GetComponent<HealthGUI>();
		scoreScript = GameObject.Find("Score").GetComponent<ScoreScript>();
		anim = gameObject.GetComponentInChildren<Animator>();
		healthGUIScript.UpdateHealth();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		GameObject bullet = other.gameObject;
		if(other.gameObject.tag == hurtTag && !isDead){			
			GameObject hitThing = Instantiate(hitEffect, bullet.transform.position, bullet.transform.rotation) as GameObject;
			Destroy(hitThing, .1f);
			Destroy(bullet);
			BulletMove bulletScript = bullet.GetComponent<BulletMove>();
			health -= bulletScript.Damage;
			healthGUIScript.UpdateHealth();
			if(health <= 0)
			{
				isDead = true;
				anim.SetTrigger("isDead");
				deathExplosion.Play();
				scoreScript.AddScore(scoreAmount);

				//GameObject explosion = Instantiate(deathEffect, theGuy.transform.position, theGuy.transform.rotation) as GameObject;
				//theGuy.SetActive(false);
			}
		}
	}
	
	public void DestroySelf()
	{
		Application.LoadLevel("GameOver");
		Destroy(this.gameObject);
	}
	
	public void AddHealth (int amount)
	{
		Debug.Log("healed");
		health += amount;
	}
}
