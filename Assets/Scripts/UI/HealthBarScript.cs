using UnityEngine;
using System.Collections;

public class HealthBarScript : MonoBehaviour {

    public float amount = 0.0f;
    public float maxAmount = 0.0f;

    public Player player;

    RectTransform thisRectTransform;
	void Start ()
    {
        
	}
	
	void Update ()
    {
        amount = player.health;
        maxAmount = player.maxHealth;

       // GetComponent<Transform>().
    }
}
