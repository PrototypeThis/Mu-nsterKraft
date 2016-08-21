using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public float tDist; //distance to player
	public float pDist; //distance to patrol object
	public float aggrDist; //variable to set how far away player is when enemy first detects and looks at them
	public float aDist; //variable to set how far away player is when enemy decides to attack
	public float eMove; //enemy speed
	public float rPatrol; //how far away from patrol object to patrol
	public float damping; //variable to change speed of rotation, higher number = faster rotation
	public Transform fpsTarget; //player object
	Rigidbody rb;
	public GameObject patrolTarget; //object to patrol around
	public float hpMax; //highest hp possible
	public float hp; //current hp
	public float atDam; //attack damage
	public float atRate; //attack rate
	public float atTime; //attack timer


	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		hp = hpMax;
	}
	
	// Update is called once per frame
	void Update () 
	{
		atTime += Time.deltaTime; //attack timer

		tDist = Vector3.Distance (fpsTarget.position, transform.position); //gets distance to player from enemy
		pDist = Vector3.Distance (patrolTarget.transform.position, transform.position); //gets distance to patrol target from enemy
		if (tDist <= aggrDist) //checks if distance to player is less than aggro distance
		{
			chase (); //enemy chases the player
		} 
		if (tDist > aggrDist && pDist <= rPatrol) //checks to see if enemy is within patrol perimeter
		{
			patrol (); //enemy patrols around a gameObject
		}

		if (tDist > aggrDist && pDist > rPatrol) //checks to see if enemy is outside of patrol perimeter and not chasing
		{
			pReturn(); //returns enemy to patrol point
		}

	}
	void chase()
	{
		Quaternion rotation = Quaternion.LookRotation (fpsTarget.position - transform.position); //gets enemy to face the player
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime+damping);//actual rotation of enemy, damping used to smooth rotation
		rb.AddForce(transform.forward * eMove); //moves the enemy straight forwards at the speed set by enemyMovementSpeed

	}

	void patrol()
	{
		Quaternion rotation = Quaternion.LookRotation (patrolTarget.transform.position - transform.position); //gets enemy to face the player
		rotation *= Quaternion.Euler(0, -90, 0); //modifies where the enemy is looking while patrolling
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime+damping);//actual rotation of enemy, damping used to smooth rotation
		transform.RotateAround(patrolTarget.transform.position,Vector3.up, eMove/10); //moves the enemy around the object placed in patrolTarget
	}

	void pReturn()
	{
		Quaternion rotation = Quaternion.LookRotation (patrolTarget.transform.position - transform.position); //gets enemy to face the player
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime+damping);//actual rotation of enemy, damping used to smooth rotation
		rb.AddForce(transform.forward * eMove); //moves the enemy straight forwards at the speed set by enemyMovementSpeed
	}

	void OnTriggerEnter(Collider other) //detects collisions with objects
	{
		if (other.tag == "Player" && atTime>=atRate) //detects if collision is with object tagged "Player"
		{
			atTime = 0;
			Debug.Log ("ATTACK"); //will print attack if true
		}
	}
}
