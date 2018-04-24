using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float mount;

    public float Mount
    {
        get { return mount; }
        set
        {
            mount = value;
            if (mount <= 0)
            {
                mount = 0;
                Destroy(gameObject);
            }
        }
    }
}
