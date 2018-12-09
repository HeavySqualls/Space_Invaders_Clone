using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthNodes : MonoBehaviour
{   
    public int health;
    public int numOfHealth;

    public Image[] healthIcons;
    public Sprite fullHealth;
    public Sprite emptyHealth;

    void Update()
    {
        health = gameObject.GetComponent<GameManager>().healthValue;
        
        if (health > numOfHealth)
        {
            health = numOfHealth;
        }
        
        for (int i = 0; i < healthIcons.Length; i++)
        {
            if (i < health)
            {
                healthIcons[i].sprite = fullHealth;
            }
            else
            {
                healthIcons[i].sprite = emptyHealth;
            }
            
            if (i < numOfHealth)
            {
                healthIcons[i].enabled = true;
            }
            else
            {
                healthIcons[i].enabled = false;
            }
        }
    }
}
