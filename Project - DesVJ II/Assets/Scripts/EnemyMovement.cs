using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform player;
    public Transform Player
    {
        set{ player = value; }
    }

    [SerializeField] float speed;

	void Update ()
    {
        if (player)
        {
            transform.LookAt(player);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
