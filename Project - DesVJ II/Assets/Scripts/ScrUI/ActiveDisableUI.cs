using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveDisableUI : MonoBehaviour
{
    [SerializeField] Text text;

	public void ChangeActive()
    {
        text.enabled = !text.enabled;
    }
}
