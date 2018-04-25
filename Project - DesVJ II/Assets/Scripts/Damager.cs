using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] float damage;

    void OnTriggerEnter(Collider other)
    {
        var health = other.GetComponent<Health>();
        if (health) health.Mount -= damage;
    }
}
