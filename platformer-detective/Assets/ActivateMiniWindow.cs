using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMiniWindow : MonoBehaviour
{
    void Start()
    {
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
