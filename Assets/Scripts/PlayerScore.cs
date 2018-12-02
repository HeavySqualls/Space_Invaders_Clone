using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
	public static PlayerScore instance {get; private set;}
	public Text scoreText;
	public static float playerScore = 0;
	public float scoreGoal = 20f;

	// Use this for initialization
	void Start () 
	{
		scoreText = GetComponent<Text>();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		scoreText.text = "SCORE: " + playerScore;

		if (playerScore >= scoreGoal)
		{
			GameManager.isPlayerWon = true;

		}
	}	
}
