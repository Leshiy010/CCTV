using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public GameObject Background;
    public float speed_Move;
    public float speed_run;
    public float speed_Current;
    public float jump;
    public float gravity = 1;
    public static float x_Move;
    public static float z_Move;
    CharacterController player;
    Vector3 move_Direction;
    public GameObject MatrixInput;
    public GameObject InputRotTrigger;
    public GameObject InputRotTrigger2;
    public GameObject InputRotTrigger3;
    public GameObject InputRotTrigger4;
    public GameObject InputRotTrigger5;
    public GameObject InputRotTrigger6;
    public GameObject InputRotTrigger7;
    public GameObject InputRotTrigger8;

    public Camera XanCam;

    void Start()
    {
        player = GetComponent<CharacterController>();

       //player.transform.position += new Vector3(0f, 200f * InputScale.InputChestHeight, 0f);

    }

     void Update()
    {
        if (!Background.activeSelf && !InputRotTrigger.activeSelf && !InputRotTrigger2.activeSelf && !InputRotTrigger3.activeSelf && !InputRotTrigger4.activeSelf && !InputRotTrigger5.activeSelf && !InputRotTrigger6.activeSelf && !InputRotTrigger7.activeSelf && !InputRotTrigger8.activeSelf)
        {
            if (XanCam.enabled == false) Move();
        }
    }

    void Move()
    {
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        if (player.isGrounded)
        {
            move_Direction = new Vector3(x_Move, 0f, z_Move);
            move_Direction = transform.TransformDirection(move_Direction);

            if (Input.GetKey(KeyCode.LeftControl)) {
                player.height = 1.4f;
            }
            else
            {
                player.height = 1.8f;
            }
        }
        move_Direction.y -= gravity;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed_Current = speed_run;

        }
        else
        {
            speed_Current = speed_Move;
        }
        player.Move(move_Direction * speed_Current * Time.deltaTime);

    }
}
