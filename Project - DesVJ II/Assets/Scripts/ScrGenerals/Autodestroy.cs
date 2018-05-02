using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestroy : MonoBehaviour
{
    [SerializeField] float time;

    void Awake()
    {
        Invoke("DestroyMySelf", time);
    }

    void DestroyMySelf()
    {
        Destroy(gameObject);
    }
}
