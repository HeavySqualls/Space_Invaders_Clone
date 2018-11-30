using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContact : MonoBehaviour
{	
    public float enemyHealth = 1;
    
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
            if (enemyHealth <= 0)
            {
                //TODO - DESTROY AMMO1
                Destroy(other);
                Destroy(gameObject);
            }
        }
		
        if (other.gameObject.tag == "ammo2")
        {
            PlayerScore.playerScore += 10;
            enemyHealth--;
            if (enemyHealth <= 0)
            {
                //TODO - DESTROY AMMO2
                Destroy(gameObject);
           
            }
        }
    }
}
