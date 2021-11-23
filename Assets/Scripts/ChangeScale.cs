using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public GameObject Room;
    private Vector3 scale;
    private Vector3 testscale;


    private void Start()
    {
        scale = new Vector3(InputScale.InputChestLength, InputScale.InputChestHeight, InputScale.InputChestWidth);
        Room.transform.localScale = scale;

    }

}
