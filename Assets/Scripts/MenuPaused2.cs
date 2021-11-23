using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPaused2 : MonoBehaviour
{
    public GameObject ViewPanel;
    public GameObject menuPaused;
    public GameObject Background;
    public GameObject MatrixPanel;
    public GameObject Matrixes;
    public GameObject Help;

    [SerializeField] KeyCode keyMenuPaused;

    public GameObject Player;





    private void Start()
    {
        menuPaused.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyMenuPaused) && !Matrixes.activeSelf && !Help.activeSelf)
        {
            Pause();
        }
    }



    public void Pause()
    {
        if (menuPaused.activeSelf)
        {
            Background.SetActive(false);
            menuPaused.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;

        }
        else
        {
            Background.SetActive(true);
            menuPaused.SetActive(true);
            Cursor.lockState = CursorLockMode.None;

        }
    }

    public void MenuPausedExit()
    {
        Application.Quit();
    }

    public void Continue()
    {
        Background.SetActive(false);
        menuPaused.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

   
}

  
