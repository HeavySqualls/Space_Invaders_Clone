using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
	public float speed;

	public Transform target;

	public Transform myTransform;

	void Update()
	{
		if (GameManager.isPlayerDead == true)
		{
			target = null;
		}
		else
		{
			myTransform = FindObjectOfType<TargetPlayer>().transform;
			target = FindObjectOfType<PlayerController>().transform;
			Vector3 targetDir = transform.position - target.position;
			targetDir.z = 0f;
			transform.Translate(targetDir.normalized*speed*Time.deltaTime);
		}
	}
}