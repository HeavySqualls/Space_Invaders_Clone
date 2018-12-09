using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldControl : MonoBehaviour {


	void Start () 
	{
		
	}
	
	void Update () 
	{
		Destroy(gameObject, 5);	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "EnemyProjectile")
		{
			Destroy(other.gameObject);
		}
	}
}
