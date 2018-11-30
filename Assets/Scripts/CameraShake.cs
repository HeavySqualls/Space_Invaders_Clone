using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	public void ShakeScreen(float intensity, float duration)
	{
		iTween.ShakePosition(gameObject, new Vector3(intensity, intensity, 0), duration);
	}
}
