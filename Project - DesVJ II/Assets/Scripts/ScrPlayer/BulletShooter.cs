using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    [SerializeField] GameObject bala;

    [SerializeField] float timeBetweenShoot;

    [SerializeField] int balasRestantes;

    [SerializeField] AudioSource m_Shoot;
    [SerializeField] AudioSource m_NoMoreBullets;

    public int BalasRestantes
    {
        get { return balasRestantes; }
        set { balasRestantes = value; }
    }

    void Awake()
    {
        m_Shoot = GetComponent<AudioSource>();
        m_NoMoreBullets = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (balasRestantes >= 1)
            {
                Disparar();
                m_Shoot.Play();
            }
            else
                m_NoMoreBullets.Play();
        }
    }

    void Disparar()
    {
        Instantiate(bala, transform.position, transform.rotation);
        balasRestantes--;
    }
}
