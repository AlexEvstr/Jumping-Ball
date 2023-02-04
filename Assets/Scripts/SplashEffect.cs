using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashEffect : MonoBehaviour
{
    public GameObject prefabSplash;

    private void OnCollisionEnter(Collision other)
    {
        GameObject newsplash = Instantiate(prefabSplash);
        newsplash.transform.position = new Vector3(transform.position.x, other.transform.position.y + 0.4f, transform.position.z);
        newsplash.transform.parent = other.transform;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        Destroy(newsplash, 10);
    }
}
