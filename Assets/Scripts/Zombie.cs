using UnityEngine;
using System.Collections;

public class Zombie : Steering
{

    public float health;
    public float chaseDistance;
    public float attackDistance;

    public enum ZombieState
    {
        Idle,
        Chase,
        Attack
    }

    public ZombieState state;

	// Use this for initialization
	void Start ()
    {
        maxSpeed = 10;
        target = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        switch (state)
        {
            case ZombieState.Idle:
                Idle();
                break;
            case ZombieState.Chase:
                Chase();
                break;
            case ZombieState.Attack:
                break;
        }
        Locomotion();
	}

    void Idle()
    {
        Stop();
    }

    void Chase()
    {
        pursuit = true;
    }

    void Attack()
    {

    }
}
