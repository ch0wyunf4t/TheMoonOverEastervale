using System.Collections;
using UnityEngine;
public class EnemyDamage : MonoBehaviour
{
    private int hitNumber;
    public GameObject being;
    public GameObject fx;




    private void OnEnable()
    {
        hitNumber = 0;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.transform.CompareTag("stick"))
        {
            hitNumber++;

            if (hitNumber == 3)
            {
                fx.transform.position = new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z);
                fx.SetActive(true);
                being.SetActive(false);
                StartCoroutine(RemoveBeing());
            }
        }
    }

    IEnumerator RemoveBeing()
    {

        yield return new WaitForSeconds(2);
        Destroy(being);
        Destroy(fx);
    }

}