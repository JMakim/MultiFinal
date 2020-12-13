using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMan : MonoBehaviour
{
    public static UIMan instance;

    public GameObject startMenu;
    public InputField userName;
    public InputField pass;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public void ConnectedToServer()
    {
        startMenu.SetActive(false);
        userName.interactable = false;
        Client.instance.ConnectToServer();
    }

}
