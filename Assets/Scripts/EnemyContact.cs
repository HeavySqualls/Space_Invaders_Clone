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
    
    void OnTriggerEnter(Collider other)
    {		
        if (other.gameObject.tag == "Player")
        {
            print("Touched Enemy");
            GameManager.instance.PlayerHealth();
        }	
		
        if (other.gameObject.tag == "ammo1")
        {
            PlayerScore.playerScore += 10;
            enemyHealth--;
            
            if (PlayerScore.playerScore == rewardPoint1)
            {
                Instantiate(healthDrop, transform.position, transform.rotation);
            }
            
            if (PlayerScore.playerScore == rewardPoint2)
            {
                Instantiate(ammoDrop, transform.position, transform.rotation);
            }
            
            if (enemyHealth <= 0)
            {
                Destroy(other.gameObject);
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
                Destroy(gameObject);
            }
        }
    }
}
