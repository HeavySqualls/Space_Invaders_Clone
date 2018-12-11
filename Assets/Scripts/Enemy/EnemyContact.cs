using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContact : MonoBehaviour
{	
    public float enemyHealth = 1;
    public GameObject healthDrop;
    public GameObject ammoDrop;
    public int rewardPoint1 = 220;
    public int rewardPoint2 = 350;

    public GameObject deathParticles;
    
// SCREEN SHAKE VARS
    public float shakeIntensity;
    public float shakeDuration;
    
// SOUND VARS
    public AudioClip tankDeath;
    public AudioClip playerCollide;
    public AudioClip itemDrop;
    
    
    
    void OnTriggerEnter(Collider other)
    {		
        if (other.gameObject.tag == "Player")
        {
            print("Touched Enemy");
            gameObject.GetComponent<AudioSource>().clip = playerCollide;
			gameObject.GetComponent<AudioSource>().PlayOneShot(playerCollide);
            GameManager.instance.PlayerHealth();
        }	
		
        if (other.gameObject.tag == "ammo1")
        {
            PlayerScore.playerScore += 10;
            enemyHealth--;
            
            if (PlayerScore.playerScore == rewardPoint1)
            {
                gameObject.GetComponent<AudioSource>().clip = itemDrop;
                gameObject.GetComponent<AudioSource>().PlayOneShot(itemDrop);
                Instantiate(healthDrop, transform.position, transform.rotation);
            }
            
            if (PlayerScore.playerScore == rewardPoint2)
            {
                gameObject.GetComponent<AudioSource>().clip = itemDrop;
                gameObject.GetComponent<AudioSource>().PlayOneShot(itemDrop);
                Instantiate(ammoDrop, transform.position, transform.rotation);
            }
            
            if (enemyHealth <= 0)
            {
                Destroy(other.gameObject);
                gameObject.GetComponent<AudioSource>().clip = tankDeath;
                gameObject.GetComponent<AudioSource>().PlayOneShot(tankDeath);
                Camera.main.gameObject.GetComponent<CameraShake>().ShakeScreen(shakeIntensity,shakeDuration);
                Instantiate(deathParticles, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
		
        if (other.gameObject.tag == "ammo2")
        {
            if (PlayerScore.playerScore == rewardPoint1)
            {
                Instantiate(healthDrop, transform.position, transform.rotation);
            }
            
            if (PlayerScore.playerScore == rewardPoint2)
            {
                Instantiate(ammoDrop, transform.position, transform.rotation);
            }
            
            PlayerScore.playerScore += 10;
            enemyHealth--;
            
            if (enemyHealth <= 0)
            {
                Destroy(other.gameObject);
                gameObject.GetComponent<AudioSource>().clip = tankDeath;
                gameObject.GetComponent<AudioSource>().PlayOneShot(tankDeath);
                Instantiate(deathParticles, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
