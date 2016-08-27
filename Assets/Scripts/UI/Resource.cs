using UnityEngine;
using System.Collections;

public class Resource : MonoBehaviour {

	public enum ResourceState
	{
		Full,

		Half,

		Depleted

	}

	public ResourceState state = ResourceState.Full;

	public int gatherPoints = 0;
	public int gatherLimit = 3;		//the number of times a player can gather from this node
	public float timeToRespawn = 5.0f;		//the number of seconds it takes for this node to respawn 
	public float respawnTimer;	//the respawn timer
	public bool isEmpty;		//sets whether a player can gather from this node or not

	// Use this for initialization
	void Start () {
		respawnTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		switch (state) 
		{
		case ResourceState.Full:
			break;
		case ResourceState.Half:
			break;
		case ResourceState.Depleted:
			Depleted (); 
			break;
		}
		if (Input.GetKeyDown(KeyCode.Space))
			{
				gatherPoints++;
			}
		if (gatherPoints >= gatherLimit) 
		{
			state = ResourceState.Depleted;
		}
	}

	/// <summary>
	/// Deplete changes mesh when 
	/// </summary>
	private void Depleted()
	{
		respawnTimer += Time.deltaTime;

		if (respawnTimer > timeToRespawn)
		{
			respawnTimer = 0.0f;
			state = ResourceState.Full;
			gatherPoints = 0;
		}
	}
}
