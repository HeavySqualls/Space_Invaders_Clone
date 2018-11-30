using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEControl : MonoBehaviour {


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
		Destroy(gameObject, 0.75f);
	}
}
