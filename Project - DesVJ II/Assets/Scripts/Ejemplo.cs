using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    [SerializeField] float velocity; // Es privada pero se puede editar en el editor.

    [SerializeField] Color color;

    [SerializeField] Vector3 spawnPoint;

    [SerializeField] string name;

    [SerializeField] bool canJump;

    private void Awake()
    {
        print("Awake");
    }

    private void Update()
    {
        print("Update");
    }

    private void OnDestroy()
    {
        print("OnDestroy");
    }

    private void OnBecameInvisible()
    {
        print("OnBecameInvisible");
    }

    private void OnMouseDown()
    {
        print("OnMouseDown");
    }
}
