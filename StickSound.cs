using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip pickupNoise;

    void OnTriggerEnter(Collider player)
    {
        audioSource.PlayOneShot(pickupNoise);
    }
}
