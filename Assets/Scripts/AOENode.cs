using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AOENode : MonoBehaviour
{   
	public int aoe;
	public int numOfammo;

	public Image[] ammoIcons;
	public Sprite fullammo;
	public Sprite emptyAmmo;

	void Update()
	{
		aoe = gameObject.GetComponent<GameManager>().aoeNode;
        
		if (aoe > numOfammo)
		{
			aoe = numOfammo;
		}
        
		for (int i = 0; i < ammoIcons.Length; i++)
		{
			if (i < aoe)
			{
				ammoIcons[i].sprite = fullammo;
			}
			else
			{
				ammoIcons[i].sprite = emptyAmmo;
			}
            
			if (i < numOfammo)
			{
				ammoIcons[i].enabled = true;
			}
			else
			{
				ammoIcons[i].enabled = false;
			}
		}
	}
}