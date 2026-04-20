using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
  
        IEnumerator Lifetime()
        {
            yield return new WaitForSeconds(3);
            Destroy(gameObject);
        }

        StartCoroutine(Lifetime());
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Light>().enabled = false;
        }
    }
}
