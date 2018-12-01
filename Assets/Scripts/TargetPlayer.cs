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
		target = FindObjectOfType<PlayerController>().transform;
		transform.LookAt(target);
		transform.Translate(Vector3.forward*2*Time.deltaTime);
	}
	/*// The target marker.
	public Transform target;
	public float speed = 2;

	void Update()
	{
		Vector3 targetDir = target.position - transform.position;
		float angle = Mathf.Atan2(targetDir.z, targetDir.y) * Mathf.Rad2Deg - 90f;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);
		
		// Move in direction
		transform.Translate(Vector3.up * Time.deltaTime * speed);
	}*/
}