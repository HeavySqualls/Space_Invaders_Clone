using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileControl : MonoBehaviour
{
	public float bulletSpeed = 20;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Base")
		{
			print("Shot own base");
			Destroy(gameObject);
		}
	}
	
	void Update ()
	{
		//SET BULLET SPEED
		transform.Translate(new Vector3(0, bulletSpeed, 0) * Time.deltaTime);
		Destroy(gameObject, 1);
	}
}
