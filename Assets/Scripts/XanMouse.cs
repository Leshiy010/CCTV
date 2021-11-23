using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XanMouse : MonoBehaviour
{

    public Camera xan;
    float xRot;
    float yRot;
    public float sensivity = 5f;
    public GameObject xanGameObject;
    float xRotCurrent;
    float yRotCurrent;
    public float smoothTime = 0.1f;
    float currentVelocityX;
    float currentVelocityY;

    public Camera PlayerCam;


    private void Update()
    {
        if (PlayerCam.enabled == false) Mouse();
    }

    void Mouse()
    {
        xRot += Input.GetAxis("Mouse X") * sensivity;
        yRot += Input.GetAxis("Mouse Y") * sensivity;
        yRot = Mathf.Clamp(yRot, -90, 90);

        xRotCurrent = Mathf.SmoothDamp(xRotCurrent, xRot, ref currentVelocityX, smoothTime);
        yRotCurrent = Mathf.SmoothDamp(yRotCurrent, yRot, ref currentVelocityY, smoothTime);


        xan.transform.rotation = Quaternion.Euler(-yRotCurrent, xRotCurrent, 0f);
        xanGameObject.transform.rotation = Quaternion.Euler(0f, xRotCurrent, 0f);


    }

}
