using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

    public int wood = 0;

    public int stone = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void IncreaseResource(int item)
    {
        item++;
    }
}
