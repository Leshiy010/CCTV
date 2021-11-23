using UnityEngine;
using System.Collections;

public class SwitchCamera : MonoBehaviour
{
    public Camera PlayerCam;
    public Camera XanCam;

    public GameObject Back;
    public GameObject Front;
    public GameObject Left;
    public GameObject Right;
    public GameObject Roof;

    public Material Wall100;
    public Material Wall30;

    public GameObject Player;
    public GameObject Xan;

    public Transform xPointer;

    public int counter;

    public bool test;

    void Start()
    {
        counter = 1;
    }

    void Update()
    {



        if (counter > 1) counter = 0;

        if (counter == 0)
        {
            PlayerCam.enabled = false;
            XanCam.enabled = true;
            Back.GetComponent<Renderer>().material = Wall30;
            Front.GetComponent<Renderer>().material = Wall30;
            Left.GetComponent<Renderer>().material = Wall30;
            Right.GetComponent<Renderer>().material = Wall30;
            Roof.GetComponent<Renderer>().material = Wall30;
        }

        if (counter == 1)
        {
            PlayerCam.enabled = true;
            XanCam.enabled = false;
            Back.GetComponent<Renderer>().material = Wall100;
            Front.GetComponent<Renderer>().material = Wall100;
            Left.GetComponent<Renderer>().material = Wall100;
            Right.GetComponent<Renderer>().material = Wall100;
            Roof.GetComponent<Renderer>().material = Wall100;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ++counter;
        }

    }
}

