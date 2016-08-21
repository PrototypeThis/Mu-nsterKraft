//Coded by Bradley Case

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Takes player component hunger and maxHunger to display as text in the User Interface.
public class HungerScript : MonoBehaviour
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
        amount = player.Hunger;         //gets data from player component
        maxAmount = player.MaxHunger;   //gets data from player component

        someText.text = "Hunger: " + amount + "/" + maxAmount;
    }
}
