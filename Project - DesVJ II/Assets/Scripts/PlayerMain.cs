using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    // Movement Things

    [SerializeField] float movementSpeed;

    [SerializeField] float rotationSpeed;

    // Weapon things

    [SerializeField] GameObject bala;

    [SerializeField] int balasRestantes;

    [SerializeField] float firstShoot;

    [SerializeField] float timeBetweenShoot;

    // Functions

    private void Awake()
    {
        Invoke("Disparar", firstShoot);
        print(balasRestantes);
    }

    private void Update ()
    {
        float movZ = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, movZ);

        float rotY = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotY, 0);

        if (Input.GetButtonDown("Fire1")) {
            if (balasRestantes >= 1)
                Disparar();
            else
                print("No more bullets, pick more or you will die");
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "BulletKit")
        {
            balasRestantes += 15;

            Destroy(col.gameObject);
        }
           
    }

    private void Disparar()
    {
        GameObject go = Instantiate(bala);
        go.transform.position = transform.position;
        go.transform.rotation = transform.rotation;

        balasRestantes--;

        print(balasRestantes);
    }
}
