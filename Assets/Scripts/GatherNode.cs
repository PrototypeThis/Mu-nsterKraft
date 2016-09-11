using UnityEngine;
using System.Collections;

public class GatherNode : MonoBehaviour {

    public enum NodeState
    {
        Full,

        Half,

        Empty
    }
    public NodeState state;

    public float resourceAmount;  //how many resources are left in the node
    public float maxResourceAmount;   //the max amount of resources 
    public float regenRate;     //how fast the resource regenerations

    // Use this for initialization
    void Start () {
        state = NodeState.Full;
	}
	
	// Update is called once per frame
	void Update () {
       
        switch (state)
        {
            case NodeState.Full:
                break;
            case NodeState.Half:
                NodeRegen();
                break;
            case NodeState.Empty:
                NodeRegen();
                break;
        }

        //Global transitions
        if(resourceAmount < (maxResourceAmount / 2) && state != NodeState.Half)
        {
            state = NodeState.Half;
        }
        if(resourceAmount < (maxResourceAmount / 4) && state != NodeState.Empty)
        {
            state = NodeState.Empty;
        }
	}

    private void NodeRegen()
    {
        resourceAmount += regenRate * Time.deltaTime;
    }


    /// <summary>
    /// Called by PlayerController when Player is gathering.
    /// </summary>
    /// <param name="gatheringRate"></param>
    public float DecreaseResource(float gatheringRate)
    {
        float resourcesToReturn = 0.0f;
        if (resourceAmount >= 0 && state != NodeState.Empty)
        {
            resourcesToReturn += gatheringRate * Time.deltaTime;

            resourceAmount -= resourcesToReturn;
            return resourcesToReturn;
        }

        else return 0.0f;
    }
}
