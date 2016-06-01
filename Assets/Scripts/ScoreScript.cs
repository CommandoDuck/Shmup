using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	int score = 0;
	public Text scoreText;

	void Update()
	{
		scoreText.text = ("Score: " + score.ToString());
	}

	public void AddScore(int scoreToAdd)
	{
		score += scoreToAdd;
	}

}
