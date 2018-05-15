using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySacrifice : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] AudioSource death;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            death.Play();
            Destroy(gameObject);
        }
    }
}
