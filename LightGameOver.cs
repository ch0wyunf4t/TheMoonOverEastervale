using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightGameOver : MonoBehaviour
{
    public bool isEnd = false;
    public GameObject fadeObj;

    public AudioSource audioSource;
    public AudioClip messageNoise;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(GameOver());
        }

        IEnumerator GameOver()
        {
            isEnd = true;
            fadeObj.GetComponent<Animator>().Play("fadego");
            audioSource.PlayOneShot(messageNoise);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(4);
        }


    }
}