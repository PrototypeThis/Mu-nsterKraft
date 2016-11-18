using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float health;
    public float maxHealth;

    public float stamina;
    public float maxStamina;

    public float power;
    public float maxPower;

    public float hunger;
    public float maxHunger;
    public float hungerIncreaseRate;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        IncreaseHunger();
    }

    #region Getters
    public float GetHealth()
    {
        return health;
    }
    public float GetMaxHealth()
    {
        return maxHealth;
    }
    public float GetStamina()
    {
        return stamina;
    }
    public float GetMaxStamina()
    {
        return maxStamina;
    }
    public float GetPower()
    {
        return power;
    }
    public float GetMaxPower()
    {
        return maxPower;
    }
    public float GetHunger()
    {
        return hunger;
    }
    public float GetMaxHunger()
    {
        return maxHunger;
    }

    #endregion

    #region Setters

    public void SetHealth(float aHealth)
    {
        health = aHealth;
    }

    public void SetHunger(float aHunger)
    {
        hunger = aHunger;
    }

    #endregion

    public void IncreaseHunger()
    {
        if (hunger < maxHunger)
        {
            hunger += hungerIncreaseRate * Time.deltaTime;
        }
    }

    public void ModifyHealth(float increment)
    {
        SetHealth(GetHealth() + increment);
    }

    public void ModifyHunger(float increment)
    {
        SetHunger(GetHunger() + increment);
    }
}
