﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
	void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
}
