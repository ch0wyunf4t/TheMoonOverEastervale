using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    public GameObject stick;
    public bool isAttacking = false;
    public AudioSource hit;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isAttacking == false)
            {
                StartCoroutine(AttackingAni());
            }


        }


        IEnumerator AttackingAni()
        {
            isAttacking = true;
            hit.Play();
            stick.GetComponent<Animator>().Play("attack");
            yield return new WaitForSeconds(0.45f);
            stick.GetComponent<Animator>().Play("Idle");
            isAttacking = false;
        }


    }
}