using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    [SerializeField] GameObject bala;

    [SerializeField] float timeBetweenShoot;
    [SerializeField] float timeToReload;

    [SerializeField] int maxBullets;
    [SerializeField] int bulletsLeft;

    [SerializeField] AudioSource m_Shoot;
    [SerializeField] AudioSource m_NoMoreBullets;

    void Awake()
    {
        m_Shoot = GetComponent<AudioSource>();
        m_NoMoreBullets = GetComponent<AudioSource>();
        bulletsLeft = maxBullets;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!IsInvoking())
            {
                if (bulletsLeft >= 1)
                {
                    Shoot();
                    m_Shoot.Play();
                }
                else
                {
                    m_NoMoreBullets.Play();
                    // a message telling "No more bullets, reload"
                }
            }
        }
        else if (Input.GetButtonDown("Reload"))
        {
            Invoke("Reloading", timeToReload);
        }
    }

    void Shoot()
    {
        Instantiate(bala, transform.position, transform.rotation);
        bulletsLeft--;
    }

    void Reloading()
    {
        bulletsLeft = maxBullets;
    }
}
