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

