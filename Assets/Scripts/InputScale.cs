using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputScale : MonoBehaviour
{

    public GameObject Background;
    public GameObject Room;
    public GameObject OpenSpace;
    public GameObject MatrixPanel;
    public GameObject InputScript;
    public GameObject Player;

    private Vector3 scale;
    private Vector3 scaleOpenSpace;

    public InputField InputLength;
    public InputField InputWidth; // Поля ввода данных в String 
    public InputField InputHeight;

    public InputField InputLengthOpenSpace;
    public InputField InputWidthOpenSpace; // Поля ввода данных в String 

    public static float InputChestLength;
    public static float InputChestWidth;   // Переменные которые хранят введенное значение
    public static float InputChestHeight;

    public static float InputChestLengthOpenSpace;
    public static float InputChestWidthOpenSpace;   // Переменные которые хранят введенное значение

    public GameObject Length;
    public GameObject Width;
    public GameObject Height;
    public GameObject EnterScale;
    public GameObject InputText;

    public GameObject LengthOpenSpace;
    public GameObject WidthOpenSpace;
    public GameObject EnterScaleOpenSpace;
    public GameObject InputTextOpenSpace;

    public GameObject OpenSpaceButton;
    public GameObject RoomButton;
    public GameObject ExitButton;
    public GameObject Text1;
    public GameObject Text2;

    public GameObject OpenSpaceGO;

    public GameObject RoomMenu;

    public GameObject Warning;
    public GameObject WarningOpenSpace;

    public GameObject Pillars;

    public GameObject HelpButton;
    public GameObject BackButton;
    public GameObject Sign1;
    public GameObject Sign2;
    public GameObject HelpText;
    public GameObject NextButton;
    public GameObject FirstPage;
    public GameObject SecondPage;
    public GameObject ThirdPage;
    public GameObject ThirdPage2;
    public int BackCounter;



    

    [SerializeField] private GameObject ViewPanel;

    [SerializeField] KeyCode keyInput;




    private void Start()
    {
        BackCounter = 0;
        Background.SetActive(true);
        HelpText.SetActive(false);
        BackButton.SetActive(false);
        NextButton.SetActive(false);
        FirstPage.SetActive(false);
        SecondPage.SetActive(false);
        ThirdPage.SetActive(false);
        ThirdPage2.SetActive(false);

        Length.SetActive(false);
        Width.SetActive(false);
        Height.SetActive(false);
        EnterScale.SetActive(false);
        InputText.SetActive(false);

        LengthOpenSpace.SetActive(false);
        WidthOpenSpace.SetActive(false);
        EnterScaleOpenSpace.SetActive(false);
        InputTextOpenSpace.SetActive(false);

        RoomMenu.SetActive(false);

        Warning.SetActive(false);
        WarningOpenSpace.SetActive(false);
        
    }


    public void RoomButtonClick()
    {
        Cursor.lockState = CursorLockMode.None;
        RoomButton.SetActive(false);
        OpenSpaceButton.SetActive(false);
        ExitButton.SetActive(false);
        Text1.SetActive(false);
        Text2.SetActive(false);

        Length.SetActive(true);
        Width.SetActive(true);
        Height.SetActive(true);
        EnterScale.SetActive(true);
        InputText.SetActive(true);

        OpenSpaceGO.SetActive(false);

        RoomMenu.SetActive(true);
        HelpButton.SetActive(false);
    }

    public void OpenSpaceButtonClick()
    {

        Cursor.lockState = CursorLockMode.None;
        RoomButton.SetActive(false);
        OpenSpaceButton.SetActive(false);
        ExitButton.SetActive(false);
        Text1.SetActive(false);
        Text2.SetActive(false);
        HelpButton.SetActive(false);

        LengthOpenSpace.SetActive(true);
        WidthOpenSpace.SetActive(true);
        EnterScaleOpenSpace.SetActive(true);
        InputTextOpenSpace.SetActive(true);

        Room.SetActive(false);
    }

    public void HelpButtonClick()
    {
        ++BackCounter;
        FirstPage.SetActive(true);
        SecondPage.SetActive(false);
        HelpText.SetActive(true);
        RoomButton.SetActive(false);
        OpenSpaceButton.SetActive(false);
        Sign1.SetActive(false);
        Sign2.SetActive(false);
        ExitButton.SetActive(false);
        HelpButton.SetActive(false);
        BackButton.SetActive(true);
        NextButton.SetActive(true);
        
    }

    public void NextButtonClick()
    {
        ++BackCounter;
        if (BackCounter == 1)
        {
            FirstPage.SetActive(true);
            SecondPage.SetActive(false);
            ThirdPage.SetActive(false);
            ThirdPage2.SetActive(false);
            NextButton.SetActive(true);
        }
        if (BackCounter == 2)
        {
            FirstPage.SetActive(false);
            SecondPage.SetActive(true);
            ThirdPage.SetActive(false);
            ThirdPage2.SetActive(false);
            NextButton.SetActive(true);
        }

        if (BackCounter == 3)
        {
            FirstPage.SetActive(false);
            SecondPage.SetActive(false);
            ThirdPage.SetActive(true);
            ThirdPage2.SetActive(true);
            NextButton.SetActive(false);
        }
        
    }

    private void Update()
    {
        if (BackCounter > 3) BackCounter = 3;
        if (BackCounter < 0) BackCounter = 0;
    }

    public void BackButtonClick()
    {
        --BackCounter;
        if (BackCounter == 1)
        {
            FirstPage.SetActive(true);
            SecondPage.SetActive(false);
            ThirdPage.SetActive(false);
            ThirdPage2.SetActive(false);
            NextButton.SetActive(true);
        }
        if (BackCounter == 2)
        {
            FirstPage.SetActive(false);
            SecondPage.SetActive(true);
            ThirdPage.SetActive(false);
            ThirdPage2.SetActive(false);
            NextButton.SetActive(true);
        }

        if (BackCounter == 3)
        {
            FirstPage.SetActive(false);
            SecondPage.SetActive(false);
            ThirdPage.SetActive(true);
            ThirdPage2.SetActive(true);
            NextButton.SetActive(false);
        }
        if (BackCounter == 0)
        {
            RoomButton.SetActive(true);
            OpenSpaceButton.SetActive(true);
            Sign1.SetActive(true);
            Sign2.SetActive(true);
            ExitButton.SetActive(true);
            HelpButton.SetActive(true);
            HelpText.SetActive(false);
            BackButton.SetActive(false);
            NextButton.SetActive(false);
        }
        
    }

    public void ExitButtonClick()
    {
        Cursor.lockState = CursorLockMode.None;
        Application.Quit();
    }

    public void SetScaleOpenSpace()
    {
        if ((InputLengthOpenSpace.text == "" || InputWidthOpenSpace.text == ""))
        {
            WarningOpenSpace.SetActive(true);
        }
        else
        {
            InputChestLengthOpenSpace = float.Parse(InputLengthOpenSpace.text);
            InputChestWidthOpenSpace = float.Parse(InputWidthOpenSpace.text);
            if ((InputChestLengthOpenSpace >= 3 && InputChestWidthOpenSpace >= 3) && (InputChestLengthOpenSpace <= 50 && InputChestWidthOpenSpace <= 50))
            {
                WarningOpenSpace.SetActive(false);
                LengthOpenSpace.SetActive(false);
                WidthOpenSpace.SetActive(false);
                EnterScaleOpenSpace.SetActive(false);
                InputTextOpenSpace.SetActive(false);

                Background.SetActive(false);
                ViewPanel.SetActive(false);

                scaleOpenSpace = new Vector3(InputScale.InputChestLengthOpenSpace, 1f, InputScale.InputChestWidthOpenSpace);
                OpenSpace.transform.localScale = scaleOpenSpace;
            }
            else WarningOpenSpace.SetActive(true);
        }
    }

            public void SetScaleRoom()
    {       
            if ((InputLength.text == "" || InputWidth.text == "" || InputHeight.text == ""))
            {
        }
            else
            {
                InputChestLength = float.Parse(InputLength.text);
                InputChestWidth = float.Parse(InputWidth.text);
                InputChestHeight = float.Parse(InputHeight.text);
                if ((InputChestLength >= 3 && InputChestWidth >= 3 && InputChestHeight >= 3) && (InputChestLength <= 20 && InputChestWidth <= 20 && InputChestHeight <= 20))
            {
                Warning.SetActive(false);
                Length.SetActive(false);
                Width.SetActive(false);
                Height.SetActive(false);
                EnterScale.SetActive(false);
                InputText.SetActive(false);

                Background.SetActive(false);
                ViewPanel.SetActive(false);

                scale = new Vector3(InputScale.InputChestLength, InputScale.InputChestHeight, InputScale.InputChestWidth);
                Room.transform.localScale = scale;
            }
                else Warning.SetActive(true);

        }

    }
}