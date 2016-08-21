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



    public float minFov = 15f;
    public float maxFov = 90f;
    public float sensitivity = 10f;


    public float MaxHP;
    public float HP;
    public float MaxMana;       //Mana, magic, etc.
    public float Mana;
    public float MaxHunger;
    public float Hunger;
    public float HungeringRate;
    public float MaxStamina;
    public float Stamina;


    public GameObject amera;
    public float speed = 20.0F;
    public float jumpSpeed = 20.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    private int mouseXSpeedMod = 100;



    //public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = Camera.main.transform.position - transform.position;
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


        float rotx = Input.GetAxis("Mouse X") * mouseXSpeedMod * Mathf.Deg2Rad;
        transform.Rotate(Vector3.up, rotx);
    }


    void LateUpdate()
    {
        Camera.main.transform.position = transform.position + offset;

        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
    }



}
