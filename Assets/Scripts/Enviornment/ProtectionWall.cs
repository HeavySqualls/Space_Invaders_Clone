using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtectionWall : MonoBehaviour
{

	public GameObject dealthParticles;
	public float health = 1;


	void Update()
	{
		if (health <= 0)
		{
			Instantiate(dealthParticles, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy1")
		{
			health--;
		}
		
		if (other.gameObject.tag == "Enemy2")
		{
			health--;
		}
	}
}
