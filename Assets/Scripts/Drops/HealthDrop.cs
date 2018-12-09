using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{
	public float healthSpeed = 1;
	
	void OnTriggerEnter(Collider other)
	{
		PlayerController playerController = other.GetComponent<PlayerController>();
		int healthPoints = GameManager.instance.healthValue;
			
		if (playerController && healthPoints < 5)
		{
			print("touched");
			playerController.RefillHealth();
			Destroy(gameObject);
		}	
	}

	void Update()
	{
		transform.Translate(new Vector3(0, healthSpeed, 0) * Time.deltaTime);	
	}
}