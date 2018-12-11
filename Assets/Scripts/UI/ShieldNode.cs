using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldNode : MonoBehaviour
{
	public AudioClip refilled;
	
	public float shield;
	public Image shieldSprite;

	private bool _isPlaying;
	
	void Update ()
	{
		shield = gameObject.GetComponent<GameManager>().shieldNode;

		if (shield == 0f && !_isPlaying)
		{
//			_isPlaying = true;
//			gameObject.GetComponent<AudioSource>().clip = refilled;
//			gameObject.GetComponent<AudioSource>().PlayOneShot(refilled);
//	
			shieldSprite.enabled = true;

//			_isPlaying = false;
		}
		else
		{
			shieldSprite.enabled = false;
		}
	}
	
}
