using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OnlineBtn : MonoBehaviour
{
    public GameObject OnlineList;

    public void ToggleOnlineList()
    {
        if (OnlineList.activeInHierarchy == true)
        {
            OnlineList.gameObject.SetActive(false);
        }
        else
        {
            OnlineList.gameObject.SetActive(true);
        }
    }
}
