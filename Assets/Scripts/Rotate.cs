using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float rotationsPerMinute = 10f;

	void Update () 
	{
		transform.Rotate(0, 0, rotationsPerMinute* Time.deltaTime);
	}
}
