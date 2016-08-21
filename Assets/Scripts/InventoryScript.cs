//Coded by Bradley Case

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Takes player component Inventory Data to display as text in the User Interface.
public class InventoryScript : MonoBehaviour
{
    private Text someText;

    public Player player;

	void Start ()
    {
        someText = GetComponent<Text>(); //gets text component from UI.
	}
	
	void Update ()
    {
        someText.text = ""; //nulls someText to prevent it from continuing to add more and more items.
        for (int i = 0; i < player.inventory.Count; i++) //Loops to print off player's inventory list ending each item with a new line.
        {
            someText.text += (player.inventory[i] + "\n");
        }
	}
}
