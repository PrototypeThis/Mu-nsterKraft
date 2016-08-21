//Edited by Bradley Case

using UnityEngine;
using System.Collections;
//Bradley Added ---------------------------------------------------------------------------------------------
using System.Collections.Generic; // added to use generic list.

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

	public float MaxHP;
    public float HP;
	public float MaxMana;		//Mana, magic, etc.
	public float Mana;

	public float MaxHunger;		
	public float Hunger;
	public float HungeringRate;

	public float MaxStamina;
	public float Stamina;

	public float speed = 20.0F;
	public float jumpSpeed = 20.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

    //Bradley Added --------------------------------------------------------------------------------------------------
    public float MaxPower; //added as major stat
    public float Power;    //added as major stat

    public List<string> inventory; //Generic list, see void Start() for implementation link and example

    void Start()
    {
        //Bradley Added, inventory example for adding to the list. For more information goto --> https://msdn.microsoft.com/en-us/library/6sh2ey19.aspx
        inventory = new List<string>();
        inventory.Add("Wood: " + 55);
        inventory.Add("Stone: " + 26);
    }

	void Update() 
	{
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) 
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

}

