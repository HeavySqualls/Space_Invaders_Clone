using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
	public float enemyHealth = 1;

	public Transform target;

	public Transform myTransform;

	void Update()
	{
		myTransform = FindObjectOfType<TargetPlayer>().transform;
		target = FindObjectOfType<PlayerController>().transform;
		Vector3 targetDir = transform.position - target.position;
		targetDir.z = 0f;
		transform.Translate(targetDir.normalized*2*Time.deltaTime);
	}
}