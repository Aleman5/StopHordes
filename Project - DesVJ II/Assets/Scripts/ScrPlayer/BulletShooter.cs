using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulletShooter : MonoBehaviour
{
    [SerializeField] GameObject bala;

    [SerializeField] AudioSource m_Shoot;
    [SerializeField] AudioSource m_NoMoreBullets;

    [SerializeField] float timeBetweenShoot;
    [SerializeField] float timeToReload;

    [SerializeField] int maxBullets;
    [SerializeField] int bulletsLeft;

    [SerializeField] UnityEvent onBulletsChanged;

    public UnityEvent OnBulletsChanged
    {
        get { return onBulletsChanged; }
    }

    public int BulletsLeft
    {
        get { return bulletsLeft; }
        private set
        {
            bulletsLeft = value;
            OnBulletsChanged.Invoke();
        }
    }

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
                if (bulletsLeft > 0)
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
        BulletsLeft--;
    }

    void Reloading()
    {
        BulletsLeft = maxBullets;
    }
}
