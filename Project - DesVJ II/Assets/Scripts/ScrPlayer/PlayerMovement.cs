using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float movSpeed;
    [SerializeField] float rotSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = float.MaxValue;
    }

    private void Update ()
    {
        Vector3 movement = Input.GetAxis("Vertical") * transform.forward * movSpeed
                         + Input.GetAxis("Horizontal") * transform.right * movSpeed;
        movement.y = rb.velocity.y; // Es para la gravedad
        rb.velocity = movement;

        Vector3 rotation = new Vector3(0, Input.GetAxis("Mouse X") * rotSpeed, 0);
        rb.angularVelocity = rotation;
    }
}
