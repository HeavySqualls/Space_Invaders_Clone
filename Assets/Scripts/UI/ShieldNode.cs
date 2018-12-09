using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldNode : MonoBehaviour
{

	public float shield;
	public Image shieldSprite;
	
	void Update ()
	{
		shield = gameObject.GetComponent<GameManager>().shieldNode;

		if (shield == 0f)
		{
			shieldSprite.enabled = true;
		}
		else
		{
			shieldSprite.enabled = false;
		}
	}
}
