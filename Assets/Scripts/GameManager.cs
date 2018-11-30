using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{	
	//TODO - enemy spawning 
	//TODO - player respawn
	//TODO - player score 

// GAME OBJECT VARS
	public GameObject player;
	public GameObject clonePlayer;

	//public GameObject deathParticles;
	
// SCREEN SHAKE VARS
	//public float shakeIntensity;
	//public float shakeDuration;
	
// PLAYER HEALTH VARS
    public int healthValue;
	
// PLAYER AMMO VARS
	public int aoeNode;
	
// GAME MANAGER VARS
	public static GameManager instance {get; private set;}
	private float resetDelay = 1f;
	private bool gameOverCheck = false;
	public static bool isPlayerDead = false;
	
// TEXT VARS
	public Text gameOver;
	public Text youWon;
	
	void Start ()
	{
		gameOver.enabled = false;
		youWon.enabled = false;
		GameManagerCheck();
		SetUp();
		CheckGameOver();
	}
	
	void Update()
	{
		aoeNode = PlayerController.Instance.aoeNumber;
		
		if (isPlayerDead == true)
		{
			gameOver.enabled = true;
			Time.timeScale = .25f;
			gameOverCheck = true;
			Invoke("Reset", resetDelay);
		}
	}
	
	void GameManagerCheck() 
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}
	
	public void SetUp()
	{	
		clonePlayer = Instantiate(player, transform.position, Quaternion.identity) as GameObject;
	}

	//TODO - player health
	public void PlayerHealth()
	{
		healthValue--;
		print("ouch!");
		
		if (healthValue <= 0)
		{
			print("damn");
			//Instantiate(deathParticles, clonePlayer.transform.position, Quaternion.identity);
			isPlayerDead = true;
			Destroy(clonePlayer);
			//Camera.main.gameObject.GetComponent<CameraShake>().ShakeScreen(shakeIntensity,shakeDuration);
		}
	}
	
	void CheckGameOver()
	{
		//TODO - Create win game function
//		if (bricks < 1)
//		{
//			gameObject.GetComponent<AudioSource>().clip = playerWin;
//			gameObject.GetComponent<AudioSource>().Play();
//			
//			youWon.GetComponent<Text>().enabled = true;
//			Time.timeScale = .25f;
//			Invoke("Reset", resetDelay);
//		}

		
	}
	
	void Reset()
	{
		//TODO - Fix game reset function
		Time.timeScale = 1;
		if (gameOverCheck == true)
		{
			SceneManager.LoadScene(0);
			isPlayerDead = false;
			PlayerScore.playerScore = 0;
		}
//		else
//		{
//			SceneManager.LoadScene(index);
//		}
	}

	
}
