using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using EZCameraShake;

public class Health : MonoBehaviour
{
    [SerializeField] float mount;
    [SerializeField] Camera camera;

    [SerializeField] UnityEvent onHealthChanged;

    public UnityEvent OnHealthChanged
    {
        get { return onHealthChanged; }
    }

    public float Mount
    {
        get { return mount; }
        set
        {
            mount = value;
            if (mount <= 0)
            {
                mount = 0;
                if (camera)
                {
                    camera.transform.SetParent(null);
                    OnHealthChanged.Invoke();
                }
                Destroy(gameObject);
            }
            else if (camera)
            {
                CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
                OnHealthChanged.Invoke();
            }
        }
    }
}
