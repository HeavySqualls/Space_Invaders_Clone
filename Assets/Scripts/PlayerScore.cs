using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
	public Text scoreText;
	public static float playerScore = 0;

	// Use this for initialization
	void Start () 
	{
		scoreText = GetComponent<Text>();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		scoreText.text = "SCORE: " + playerScore;
	}	
}
