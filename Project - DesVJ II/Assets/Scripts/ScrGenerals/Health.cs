using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Health : MonoBehaviour
{
    [SerializeField] float mount;
    [SerializeField] Camera camera;

    public float Mount
    {
        get { return mount; }
        set
        {
            mount = value;
            if (mount <= 0)
            {
                if (camera)
                    camera.transform.SetParent(null);
                mount = 0;
                Destroy(gameObject);
            }
            else if (camera)
                CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        }
    }
}
