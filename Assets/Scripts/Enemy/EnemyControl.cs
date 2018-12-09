using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
	public float enemyHealth = 1;
	public float enemySpeed = 2;

	public GameObject bullet;

	public float timer;
	public float waitingTime;
	
	void Start () 
	{
		
	}
	

	void Update () 
	{
		transform.Translate(new Vector3(0, enemySpeed, 0) * Time.deltaTime);

		timer += Time.deltaTime;
		if (timer > waitingTime)
		{
			Instantiate(bullet, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
