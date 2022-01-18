using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemScripting : MonoBehaviour
{
    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps.Play();

        Destroy(gameObject, ps.main.duration);
    }
}
