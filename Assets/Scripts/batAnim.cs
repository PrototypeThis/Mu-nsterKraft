using UnityEngine;
using System.Collections;

public class batAnim : MonoBehaviour {

    public AnimationClip idle;
    public AnimationClip walk;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Animation animControl = transform.GetComponent<Animation>();
        print(animControl);

        animControl.Play("Idle");
	}
}
