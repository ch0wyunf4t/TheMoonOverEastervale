using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivatestick : MonoBehaviour
{
    public GameObject stickObj;

    void Update()

    {
        StartCoroutine(StickExpire());

    }



    IEnumerator StickExpire()
    {
        yield return new WaitForSeconds(4);
        Destroy(stickObj);
    }
}
