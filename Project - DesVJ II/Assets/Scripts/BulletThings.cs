using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletThings : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    [SerializeField] float lifeTime;

    private void Update ()
    {
        transform.Translate(0, 0, movementSpeed * Time.deltaTime);

        Invoke("EndLife", lifeTime);
	}

    private void EndLife()
    {
        Destroy(gameObject);
    }
}
