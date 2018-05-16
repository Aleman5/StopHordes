using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySacrifice : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] AudioSource death;

    [SerializeField] ParticleSystem particles;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            death.Play();
            ParticleSystem parti = Instantiate(particles, transform.position, transform.rotation);
            //parti.Play();
            Destroy(gameObject);
        }
    }
}
