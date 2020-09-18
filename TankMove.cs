using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    public GameObject thePlayer;
    public bool isMoving;

    public float horizontalMove;
    public float verticalMove;


    void Update()
    {


        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 90;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 4;
            thePlayer.transform.Rotate(0, horizontalMove, 0);
            thePlayer.transform.Translate(0, 0, verticalMove);





        }
        else
        {
            isMoving = false;
        }
    }



}
