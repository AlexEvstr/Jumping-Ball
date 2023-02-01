using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashParticleEffect : MonoBehaviour
{
    public GameObject prefabSplashParticleEffect;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject newParticleEffect = Instantiate(prefabSplashParticleEffect);
        newParticleEffect.transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        Destroy(newParticleEffect, 1.5f);
    }
}
