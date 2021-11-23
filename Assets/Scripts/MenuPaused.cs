using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPaused : MonoBehaviour
{
    public GameObject ViewPanel;
    public GameObject menuPaused;
    public Crosshair crosshair;
    [SerializeField] KeyCode keyMenuPaused;
    bool isMenuPaused = false;

    private void Start()
    {
        crosshair.enabled = false;
        menuPaused.SetActive(true);

    }

    private void Update()
    {
        ActiveMenu();

    }

    private void ActiveMenu()
    {
        if (Input.GetKeyDown(keyMenuPaused) && !ViewPanel.activeSelf)
        {
            isMenuPaused = !isMenuPaused;
        }

        if (isMenuPaused)
        { //Pausa activna 
            menuPaused.SetActive(true);
            crosshair.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;

        }
        else
        { // Pausa vikluchena 
            menuPaused.SetActive(false);
            if (!ViewPanel.activeSelf)
            { //Skrivaem kursor
                Cursor.lockState = CursorLockMode.Locked;
                crosshair.enabled = true;
            }



            Time.timeScale = 1f;

        }
    }


    public void MenuPausedContinue()
    {
        isMenuPaused = false;
    }

    public void MenuPausedExit()
    {
        Application.Quit();
    }


}
