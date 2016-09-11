/*
 *Player Script
 * Miguel Torres
 */

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public enum PlayerState
    {
        Attack,
        Eat,
        Sleep,
        Spell,
        SuckBlood,
    }

    #region stats

    public float health;       //the player's health
    public float maxHealth;    //the player's max health

    public float hunger;        //the player's hunger level
    public float maxHunger;     //the max amount of hunger a player has
    public float hungerDecayRate;   //how quickly player hunger depletes

    public float power;         //the player's power points
    public float maxPower;      //the player's max power points

    public float stamina;       //the player's stamina
    public float maxStamina;    //the player's max stamina
    public float staminaDecayRate;  //how fast stamina decays

    public float experience;    //how much experience a player has

    public int level;           //the player's level
            
    public float gatheringRate; //how many resources a player can gather from a resource point

    public float gatherDistance;

    public float speed;

    #endregion

    #region Inventory
    public float tree = 0.0f;
    public float rock = 0.0f;

    #endregion

    void Start()
    {
        
    }

    void Update()
    {
        ReduceHunger();
    }

    /// <summary>
    /// Reduces hunger by hungerDecayRate
    /// </summary>
    private void ReduceHunger()
    {
        hunger = hunger - hungerDecayRate * Time.deltaTime;
    }

    public void ReduceStamina()
    {
        stamina = stamina - staminaDecayRate * Time.deltaTime;
    }

    public void Gather(float resourceAmount)
    {


    }

}
