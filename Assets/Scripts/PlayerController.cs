using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Networking;

public class PlayerController : MonoBehaviour
{
// MOVEMENT VARS
	public float speed = 1;
	private Vector3 playerPos = new Vector3(0, 5f, 0);
	
// SHOOT BULLET VARS
	public GameObject bullet1;	
	public GameObject bullet2;
	[SerializeField] int numberofProjectiles;
	private Vector3 startPoint;
	private float radius;
	public int aoeNumber = 4;
	public float coolDown = 1;
	public float coolDownTimer;

// MAKES THE CLASS A SINGLETON TO BE EASILY ACCESSED BY OTHER CLASSES
	public static PlayerController Instance {get; private set;}

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}
	
	void Start()
	{
		radius = 5f;
	}
	
	void Update ()
	{
		// MOVEMENT
		float xPos = transform.position.x + Input.GetAxis("Horizontal") * speed;
		float yPos = transform.position.y + Input.GetAxis("Vertical") * speed;
		playerPos = new Vector3(Mathf.Clamp(xPos, -19f, 19f), Mathf.Clamp(yPos, 5, 37), 0f);
		transform.position = playerPos;
	
		// SHOOTING 
		if (Input.GetButtonUp("Fire1") && coolDownTimer == 0f)
		{
			print("weapon cooled");
			coolDownTimer = coolDown;
			Instantiate(bullet1, transform.position, transform.rotation);
		}	
		
		if (Input.GetButtonUp("Fire2") && coolDownTimer == 0f)
		{
			coolDownTimer = coolDown;
			if (aoeNumber == 0)
			{
				print("No AOE!");
			}
			else
			{
				print("weapon cooled");
				startPoint = playerPos;
				SpawnAOEProjectiles(numberofProjectiles);
				aoeNumber = aoeNumber - 1;
			}
		}

		if (coolDownTimer > 0)
		{
			coolDownTimer -= Time.deltaTime;
		}
		
		if (coolDownTimer < 0)
		{
			coolDownTimer = 0;
		}
	}

	void FireTimer()
	{
			for (int i = 5; i > 0; i--)
			{
				coolDown = coolDown - 1 * Time.deltaTime;
			}
	}

	void SpawnAOEProjectiles(int numberofProjectiles)
	{
		float angleStep = 360f / numberofProjectiles;
		float angle = 0f;
		float moveSpeed = 30f;

		for (int i = 0; i <= numberofProjectiles - 1; i++)
		{
			float projectileDirXposition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
			float projectileDirYposition = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;
			
			Vector3 projectileVector = new Vector3(projectileDirXposition, projectileDirYposition);
			Vector3 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

			var proj = Instantiate(bullet2, startPoint, Quaternion.identity);
			proj.GetComponent<Rigidbody>().velocity = new Vector3(projectileMoveDirection.x, projectileMoveDirection.y);

			angle += angleStep;

		}
	}

	public void RefillAmmo()
	{
		aoeNumber = aoeNumber + 1;
		print(aoeNumber);
	}
	
	public void RefillHealth()
	{
			GameManager.instance.healthValue = GameManager.instance.healthValue + 1;
		
	}
}
