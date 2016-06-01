using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthGUI : MonoBehaviour {

	HealthScript healthScript;
	private int _currentHealth;
	public Image[] healthBars;
	public Sprite fullBar;
	public Sprite emptyBar;

	// Use this for initialization
	void Start () {
		healthScript = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<HealthScript>();
        Debug.Log(healthScript);
	}

	void Update()
	{
		UpdateHealth();
	}

	public void UpdateHealth () {
		_currentHealth = healthScript.health;
		int i = 0;
		healthBars = gameObject.GetComponentsInChildren<Image>();
		foreach(Image bar in healthBars)
		{
			bar.GetComponent<Image>();
			if(_currentHealth >= (i + 1)) 
			{
				bar.sprite = fullBar;
			}
			else
			{
				bar.sprite = emptyBar;
			}
			i++;
		}
	}
}
