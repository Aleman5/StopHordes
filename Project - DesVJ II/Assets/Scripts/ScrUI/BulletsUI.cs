using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsUI : MonoBehaviour
{
    private Text bulletsUI;

    [SerializeField] BulletShooter shooter;

    private void Start()
    {
        bulletsUI = GetComponent<Text>();
        shooter.OnBulletsChanged.AddListener(RefreshBullets);
        RefreshBullets();
    }
    
    private void RefreshBullets()
    {
        bulletsUI.text = shooter.BulletsLeft.ToString();
    }
}
