using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject Player;
    public GameObject Background;
    public GameObject MainMenuCanvas;


    private void Start()
    {
        Background.SetActive(true);
        MainMenuCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    void Room()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Background.SetActive(false);
        MainMenuCanvas.SetActive(false);
    }

    void OpenSpace()
    {
        Vector3 position = new Vector3(1f, 1f, -50f);
        Player.transform.position = position;
        Background.SetActive(false);
        MainMenuCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }

    void Exit()
    {
        Application.Quit();
    }
}
