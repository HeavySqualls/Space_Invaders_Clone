using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

	public float ammoSpeed = 1;
	
	void OnTriggerEnter(Collider other)
	{
		PlayerController playerController = other.GetComponent<PlayerController>();
			
		if (playerController)
		{
			print("refill aoe");
			playerController.RefillAmmo();
			Destroy(gameObject);
		}	
	}

	void Update()
	{
		transform.Translate(new Vector3(0, ammoSpeed, 0) * Time.deltaTime);
	}
}
