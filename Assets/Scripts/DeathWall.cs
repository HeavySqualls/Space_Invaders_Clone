using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy1")
        {
            Destroy(other.gameObject);
            GameManager.isPlayerDead = true;
        }
        
        if (other.gameObject.tag == "Enemy2")
        {
            Destroy(other.gameObject);
            GameManager.isPlayerDead = true;
        }
    }
}
