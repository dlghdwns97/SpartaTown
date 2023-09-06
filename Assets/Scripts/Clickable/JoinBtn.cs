using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class JoinBtn : MonoBehaviour
{
    public InputField NameSpace;
    public string playerName;
    public Text Name;
    public Canvas Join;
    public Canvas IngameName;
    public Text OnlineText;
    void Awake()
    {
        playerName = NameSpace.GetComponent<InputField>().text;
    }
    public void GameStart()
    {
        Join.gameObject.SetActive(false);
        Name.text = playerName;
    }
    public void IsFilled()
    {
        playerName = NameSpace.text;

        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }
    public void AddOnlineList()
    {
        OnlineText.text = "";
        OnlineText.text += playerName + "\n";
        OnlineText.text += "NPC 123\n";
    }
    public void ToggleNameChange()
    {
        IngameName.gameObject.SetActive(true);
    }
    public void ChangeName()
    {
        IngameName.gameObject.SetActive(false);
        Name.text = playerName;
        AddOnlineList();
    }
}
