using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveDisableUI : MonoBehaviour
{
    [SerializeField] Text text;

    bool e;

    void Start()
    {
        text = GetComponent<Text>();
        e = true;
    }

    public void ChangeActive()
    {
        text.gameObject.SetActive(!text.gameObject.activeSelf);
    }
}
