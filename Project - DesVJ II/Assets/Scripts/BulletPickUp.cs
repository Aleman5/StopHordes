using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var balas = other.GetComponent<BulletShooter>();

        balas.BalasRestantes += 15;
        Destroy(gameObject);
    }
}
