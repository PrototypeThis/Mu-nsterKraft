//Coded by Bradley Case

using UnityEngine;
using UnityEngine.UI;
using System.Collections;


//Takes player component stamina and maxStamina to display as text in the User Interface.
public class StaminaScript : MonoBehaviour
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
        amount = player.stamina;        //gets data from player component
        maxAmount = player.maxStamina;  //gets data from player component

        someText.text = "Stamina: " + amount + "/" + maxAmount;
    }
}
