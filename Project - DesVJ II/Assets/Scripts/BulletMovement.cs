using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    private void Update ()
    {
        transform.Translate(0, 0, movementSpeed * Time.deltaTime);
	}
}
