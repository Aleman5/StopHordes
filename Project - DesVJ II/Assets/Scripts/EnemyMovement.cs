using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField] float speed;

    void Awake()
    {
        transform.LookAt(player);
    }

	void Update ()
    {
        transform.LookAt(player);

        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
}
