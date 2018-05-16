using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnersLeftUI : MonoBehaviour
{
    private Text spawnsLeft;

    private void Start()
    {
        spawnsLeft = GetComponent<Text>();
    }

    void Update ()
    {
        spawnsLeft.text = ManagerSpawner.Instance.ActiveSpawners.Count.ToString();
    }
}
