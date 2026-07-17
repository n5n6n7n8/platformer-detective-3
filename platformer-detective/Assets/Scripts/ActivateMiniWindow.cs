using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMiniWindow : MonoBehaviour
{
    public GameObject miniWindow;
    void Start()
    {
        miniWindow.SetActive(false);
        gameObject.SetActive(false);
    }
    public void hideWindow()
    {
        gameObject.SetActive(false);
    }
    public void showWindow()
    {
        gameObject.SetActive(true);
    }
}
