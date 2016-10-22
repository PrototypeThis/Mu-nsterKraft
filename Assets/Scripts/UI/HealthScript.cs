//Coded by Bradley Case

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Takes player component health and maxHealth to display as text in the User Interface.
public class HealthScript : MonoBehaviour
{
    private Text someText;
    private float amount;
    private float maxAmount;

    public Player player;

	void Start ()
    {
        someText = GetComponent<Text>(); //gets text component from UI.
    }
	
	void Update ()
    {
        amount = player.health;         //gets data from player component
        maxAmount = player.maxHealth;   //gets data from player component

        someText.text = "Health: " + amount + "/" + maxAmount;
    }
}
