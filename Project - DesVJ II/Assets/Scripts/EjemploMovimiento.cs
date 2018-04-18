using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploMovimiento : MonoBehaviour {

    [SerializeField] float movementSpeed;

    [SerializeField] float rotation;

    private void Update()
    {
        if(Input.GetButton("MoveForward"))
            transform.Translate(0, 0, movementSpeed * Time.deltaTime);
        if (Input.GetButton("MoveBackward"))
            transform.Translate(0, 0, -movementSpeed * Time.deltaTime);
        if (Input.GetButton("MoveLeft"))
            transform.Rotate(0, -rotation * Time.deltaTime, 0);
        else if (Input.GetButton("MoveRight"))
            transform.Rotate(0, rotation * Time.deltaTime, 0);
    }
}
