using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySacrifice : MonoBehaviour
{
    [SerializeField] GameObject player;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            Destroy(gameObject);
    }
}
