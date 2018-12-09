using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtectionWall : MonoBehaviour
{

	public float health = 3;


	void Update()
	{
		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}
}
