using System.Collections;
using UnityEngine;
public class EnemyHit : MonoBehaviour
{
    private int hitNumber;
    public AudioSource hitSource;
    public AudioClip hitClip;




    private void OnEnable()
    {
        hitNumber = 0;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.transform.CompareTag("stick"))
        {
            StartCoroutine(PlayHit());

        }
    }

    IEnumerator PlayHit()
    {
        hitSource.PlayOneShot(hitClip);
        yield return new WaitForSeconds(.1f);
    }

}