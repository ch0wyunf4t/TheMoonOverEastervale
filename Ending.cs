using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{

    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public GameObject eleven;
    public GameObject image;
    public AudioSource music1;
    public AudioSource theme;

    public GameObject title;
    [SerializeField]
    private string sceneToLoad;

    void Start()
    {
        one.SetActive(false);
        StartCoroutine(WaitForSec());

    }

    IEnumerator WaitForSec()
    {
        image.SetActive(true);
        one.SetActive(true);
        yield return new WaitForSeconds(8);
        Destroy(one);
        two.SetActive(true);
        yield return new WaitForSeconds(8);
        Destroy(two);
        three.SetActive(true);
        yield return new WaitForSeconds(8);
        Destroy(three);
        four.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(four);
        five.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(five);
        six.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(six);
        seven.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(seven);
        eight.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(eight);
        nine.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(nine);
        ten.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(ten);
        music1.Stop();
        theme.Play();
        eleven.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(eleven);
        Destroy(image);

        title.SetActive(true);

        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(sceneToLoad);

    }
}