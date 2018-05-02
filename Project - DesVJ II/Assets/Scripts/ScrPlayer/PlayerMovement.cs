using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    private void Update ()
    {
        float movWS = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, movWS);

        float movAD = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        transform.Translate(movAD, 0, 0);

        
    }
}
