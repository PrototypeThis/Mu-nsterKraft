using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour
{
    public GameObject target; //the gameObject the camera is following (player)
    public float damping = 1;   //used to smooth out the camera movement
    public Vector3 offset;             //the position the camera will sit, relative to the target


	void Start ()
    {
       // offset = target.transform.position - transform.position;    //sets the initial offset to this objects location when game starts
	}
	
	void LateUpdate ()
    {
        float desiredAngle = target.transform.eulerAngles.y;    //gets the angle of the target
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0); //turns the rotation of the angle into Quaternion

        transform.position = target.transform.position - (rotation * offset);

        transform.LookAt(target.transform);
	
	}
}
