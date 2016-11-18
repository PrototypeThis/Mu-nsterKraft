using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed;
    public float movementSpeed;

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }
    }
}
