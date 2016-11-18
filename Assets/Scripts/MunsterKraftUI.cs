using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MunsterKraftUI : MonoBehaviour
{
    public Player player;

    public GameObject healthBar;
    Image healthBarImage;

    public GameObject staminaBar;
    Image staminaBarImage;

    public GameObject powerBar;
    Image powerBarImage;

    public GameObject hungerBar;
    Image hungerBarImage;


    public GameObject actionBar1;
    public GameObject actionBar2;
    public GameObject actionBar3;
    public GameObject actionBar4;
    public GameObject actionBar5;
    public GameObject actionBar6;
    public GameObject actionBar7;
    public GameObject actionBar8;
    public GameObject actionBar9;
    public GameObject actionBar0;

    // Use this for initialization
    void Start ()
    {
        healthBarImage = healthBar.GetComponent<Image>();
        staminaBarImage = staminaBar.GetComponent<Image>();
        powerBarImage = powerBar.GetComponent<Image>();
        hungerBarImage = hungerBar.GetComponent<Image>();

        actionBar1 = GameObject.Find("ActionBar1");
        actionBar2 = GameObject.Find("ActionBar2");
        actionBar3 = GameObject.Find("ActionBar3");
        actionBar4 = GameObject.Find("ActionBar4");
        actionBar5 = GameObject.Find("ActionBar5");
        actionBar6 = GameObject.Find("ActionBar6");
        actionBar7 = GameObject.Find("ActionBar7");
        actionBar8 = GameObject.Find("ActionBar8");
        actionBar9 = GameObject.Find("ActionBar9");
        actionBar0 = GameObject.Find("ActionBar0");
    }
	
	// Update is called once per frame
	void Update ()
    {
        UpdatePlayerStats();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            actionBar1.GetComponentInChildren<Item>().Use();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            actionBar2.GetComponentInChildren<Item>().Use();
        }
    }

    public void UpdatePlayerStats()
    {
        healthBarImage.fillAmount = player.GetHealth() / player.GetMaxHealth();
        staminaBarImage.fillAmount = player.GetStamina() / player.GetMaxStamina();
        powerBarImage.fillAmount = player.GetPower() / player.GetMaxPower();
        hungerBarImage.fillAmount = player.GetHunger() / player.GetMaxHunger();
    }

//
}
