using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickRotate : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0f, .2f, .1f));
    }
}