using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Move : MonoBehaviour
{
    public GameObject Background;
    public GameObject MatrixInput;
    public static float xRot;
    float yRot;
    public Camera player;
    public float sensivity = 5f;
    public GameObject playerGameObject;
    float xRotCurrent;
    float yRotCurrent;
    public float smoothTime = 0.1f;
    float currentVelocityX;
    float currentVelocityY;

    public GameObject InputRotTrigger;
    public GameObject InputRotTrigger2;
    public GameObject InputRotTrigger3;
    public GameObject InputRotTrigger4;
    public GameObject InputRotTrigger5;
    public GameObject InputRotTrigger6;
    public GameObject InputRotTrigger7;
    public GameObject InputRotTrigger8;

    public Camera XanCam;


    private void Update()
    {
        if (!Background.activeSelf && !InputRotTrigger.activeSelf && !InputRotTrigger2.activeSelf && !InputRotTrigger3.activeSelf && !InputRotTrigger4.activeSelf && !InputRotTrigger5.activeSelf && !InputRotTrigger6.activeSelf && !InputRotTrigger7.activeSelf && !InputRotTrigger8.activeSelf)
        {
            if (XanCam.enabled == false) MouseMove();
        }
            

    }

    void MouseMove()
    {
        xRot += Input.GetAxis("Mouse X") * sensivity;
        yRot += Input.GetAxis("Mouse Y") * sensivity;
        yRot = Mathf.Clamp(yRot, -90, 90);

        xRotCurrent = Mathf.SmoothDamp(xRotCurrent, xRot, ref currentVelocityX, smoothTime);
        yRotCurrent = Mathf.SmoothDamp(yRotCurrent, yRot, ref currentVelocityY, smoothTime);


        player.transform.rotation = Quaternion.Euler(-yRotCurrent, xRotCurrent, 0f);
        playerGameObject.transform.rotation = Quaternion.Euler(0f, xRotCurrent, 0f);


    }

}
