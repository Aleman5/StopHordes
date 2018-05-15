﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPUI : MonoBehaviour
{
    private Image image;

    [SerializeField] Health health;

    private void Start()
    {
        health.OnHealthChanged.AddListener(RefreshHealth);
        RefreshHealth();
    }
    private void RefreshHealth()
    {
        image.fillAmount = health.Mount;
    }
}
