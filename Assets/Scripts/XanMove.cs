using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XanMove : MonoBehaviour
{
    public static float xan_x_Move;
    public static float xan_z_Move;
    public static float xan_y_Move;
    public float speed;
    CharacterController xan;
    Vector3 xan_move_Direction;

    public Camera PlayerCam;


    void Start()
    {
        xan = GetComponent<CharacterController>();

        //player.transform.position += new Vector3(0f, 200f * InputScale.InputChestHeight, 0f);

    }


    void Update()
    {

        if (PlayerCam.enabled == true) speed = 0f;
        else speed = 20f;
        
        xan_x_Move = Input.GetAxis("Horizontal");
        xan_z_Move = Input.GetAxis("Vertical");
        xan_y_Move = -(Input.GetAxis("Mouse ScrollWheel"));
        xan_y_Move = xan_y_Move * 40f;

        xan_move_Direction = new Vector3(xan_x_Move, xan_y_Move, xan_z_Move);
        xan_move_Direction = transform.TransformDirection(xan_move_Direction);
        xan.Move(xan_move_Direction * speed *  Time.deltaTime);

    }
}
