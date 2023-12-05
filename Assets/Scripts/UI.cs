using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject canvas;

    public void StartButton()
    {
        canvas.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
