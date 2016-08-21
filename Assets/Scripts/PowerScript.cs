//Coded by Bradley Case

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Takes player component power and maxPower to display as text in the User Interface.
public class PowerScript : MonoBehaviour
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
        amount = player.Power;          //gets data from player component
        maxAmount = player.MaxPower;    //gets data from player component

        someText.text = "Power: " + amount + "/" + maxAmount;
    }
}
