using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 0.1f;
	public Vector3 centerPt;
	public float radius;
	public Animator anim;
	public HealthScript healthScript;
	private bool _isDead;

	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
		healthScript = healthScript.GetComponent<HealthScript>();
	}


	// Update is called once per frame
	void Update ()
	{

		_isDead = healthScript.isDead;
		if(!_isDead)
		{
			Vector3 moveDir = new Vector3 (Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
			
			//moveDir.y = Input.GetAxis("Vertical") * speed;
			//moveDir.x = Input.GetAxis("Horizontal") * speed;
			
			
			//Vector3 newPos = transform.position + moveDir;
			//Vector3 offset = newPos - centerPt;
			Vector3 parentPos = transform.parent.transform.position;
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, (parentPos.x -5.5f), (parentPos.x + 5.5f)), Mathf.Clamp(transform.position.y, (parentPos.y - 4.4f), (parentPos.y - 0.5f)), 0);

			anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
			
			this.transform.Translate(moveDir);
			//Debug.Log(Input.GetAxis("Horizontal"));
			if(Input.GetAxis("Horizontal") < 0)
			{
				Vector3 rotation = new Vector3(-180, 0, 0);
				//Quaternion rotator = ;
				//transform.rotation.x = rotator;
				Debug.Log(transform.rotation);
				
			}
		}

	}
}
