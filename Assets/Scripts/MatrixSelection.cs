using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MatrixSelection : MonoBehaviour
{
    public GameObject InputBackground;

    public GameObject MatrixPanel;
    public GameObject MatrixPanel2;
    public GameObject MatrixPanel3;
    public GameObject MatrixPanel4;
    public GameObject MatrixPanel5;
    public GameObject MatrixPanel6;
    public GameObject MatrixPanel7;
    public GameObject MatrixPanel8;

    public GameObject Matrixes;

    public Button Matrix1;
    public Button Matrix2;
    public Button Matrix3;
    public Button Matrix4;
    public Button Matrix5;
    public Button Matrix6;
    public Button Matrix7;
    public Button Matrix8;
    public Button Matrix9;
    public Button Matrix10;
    public float MatrixHeight;
    public static float MatrixWidth;
    public static float FocalLength;
    public float Range;
    public static float Resolution;

    public Button Matrix1_2;
    public Button Matrix2_2;
    public Button Matrix3_2;
    public Button Matrix4_2;
    public Button Matrix5_2;
    public Button Matrix6_2;
    public Button Matrix7_2;
    public Button Matrix8_2;
    public Button Matrix9_2;
    public Button Matrix10_2;
    public float MatrixHeight_2;
    public static float MatrixWidth_2;
    public static float FocalLength_2;
    public float Range_2;
    public static float Resolution_2;

    public Button Matrix1_3;
    public Button Matrix2_3;
    public Button Matrix3_3;
    public Button Matrix4_3;
    public Button Matrix5_3;
    public Button Matrix6_3;
    public Button Matrix7_3;
    public Button Matrix8_3;
    public Button Matrix9_3;
    public Button Matrix10_3;
    public float MatrixHeight_3;
    public static float MatrixWidth_3;
    public static float FocalLength_3;
    public float Range_3;
    public static float Resolution_3;

    public Button Matrix1_4;
    public Button Matrix2_4;
    public Button Matrix3_4;
    public Button Matrix4_4;
    public Button Matrix5_4;
    public Button Matrix6_4;
    public Button Matrix7_4;
    public Button Matrix8_4;
    public Button Matrix9_4;
    public Button Matrix10_4;
    public float MatrixHeight_4;
    public static float MatrixWidth_4;
    public static float FocalLength_4;
    public float Range_4;
    public static float Resolution_4;

    public Button Matrix1_5;
    public Button Matrix2_5;
    public Button Matrix3_5;
    public Button Matrix4_5;
    public Button Matrix5_5;
    public Button Matrix6_5;
    public Button Matrix7_5;
    public Button Matrix8_5;
    public Button Matrix9_5;
    public Button Matrix10_5;
    public float MatrixHeight_5;
    public static float MatrixWidth_5;
    public static float FocalLength_5;
    public float Range_5;
    public static float Resolution_5;

    public Button Matrix1_6;
    public Button Matrix2_6;
    public Button Matrix3_6;
    public Button Matrix4_6;
    public Button Matrix5_6;
    public Button Matrix6_6;
    public Button Matrix7_6;
    public Button Matrix8_6;
    public Button Matrix9_6;
    public Button Matrix10_6;
    public float MatrixHeight_6;
    public static float MatrixWidth_6;
    public static float FocalLength_6;
    public float Range_6;
    public static float Resolution_6;

    public Button Matrix1_7;
    public Button Matrix2_7;
    public Button Matrix3_7;
    public Button Matrix4_7;
    public Button Matrix5_7;
    public Button Matrix6_7;
    public Button Matrix7_7;
    public Button Matrix8_7;
    public Button Matrix9_7;
    public Button Matrix10_7;
    public float MatrixHeight_7;
    public static float MatrixWidth_7;
    public static float FocalLength_7;
    public float Range_7;
    public static float Resolution_7;

    public Button Matrix1_8;
    public Button Matrix2_8;
    public Button Matrix3_8;
    public Button Matrix4_8;
    public Button Matrix5_8;
    public Button Matrix6_8;
    public Button Matrix7_8;
    public Button Matrix8_8;
    public Button Matrix9_8;
    public Button Matrix10_8;
    public float MatrixHeight_8;
    public static float MatrixWidth_8;
    public static float FocalLength_8;
    public float Range_8;
    public static float Resolution_8;

    float activecount;

    public static bool MainMenuActive;



    public void SelectMatrix1()
    {
        MatrixHeight = 9.6f;
        MatrixWidth = 12.8f;
        FocalLength = 2.8f;
        Range = 6f;
        Resolution = 380f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);

        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }

    public void SelectMatrix2()
    {
        MatrixHeight = 6.4f;
        MatrixWidth = 4.8f;
        FocalLength = 4f;
        Range = 9f;
        Resolution = 400f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);

        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }

    public void SelectMatrix3()
    {
        MatrixHeight = 4.8f;
        MatrixWidth = 3.6f;
        FocalLength = 6f;
        Range = 10f;
        Resolution = 390f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);

        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }

    public void SelectMatrix4()
    {
        MatrixHeight = 2.4f;
        MatrixWidth = 3.2f;
        FocalLength = 8f;
        Range = 4f;
        Resolution = 420f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);

        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }

    public void SelectMatrix5()
    {
        MatrixHeight = 8.8f;
        MatrixWidth = 6.6f;
        FocalLength = 12f;
        Range = 7f;
        Resolution = 410f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);

        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }

    public void SelectMatrix6()
    {
        MatrixHeight = 17.8f;
        MatrixWidth = 10f;
        FocalLength = 16f;
        Range = 8f;
        Resolution = 305f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);

        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }

    public void SelectMatrix7()
    {
        MatrixHeight = 23.6f;
        MatrixWidth = 15.5f;
        FocalLength = 25f;
        Range = 130f;
        Resolution = 310f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);

        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }

    public void SelectMatrix8()
    {
        MatrixHeight = 24.89f;
        MatrixWidth = 18.66f;
        FocalLength = 50f;
        Range = 100f;
        Resolution = 315f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);

        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }

    public void SelectMatrix9()
    {
        MatrixHeight = 28.7f;
        MatrixWidth = 19.1f;
        FocalLength = 75f;
        Range = 90f;
        Resolution = 300f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);


        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }

    public void SelectMatrix10()
    {
        MatrixHeight = 36f;
        MatrixWidth = 24f;
        FocalLength = 100f;
        Range = 80f;
        Resolution = 320f;
        MatrixPanel.SetActive(false);
        MatrixPanel2.SetActive(true);

        Debug.Log("Выбрана матрица" + Matrix1);
        Debug.Log("Высота матрицы" + MatrixHeight);
        Debug.Log("Ширина матрицы" + MatrixWidth);
        Debug.Log("Фокусное расстояние" + FocalLength);
        Debug.Log("Дальность" + Range);
        Debug.Log("Разрешение линий" + Resolution);
    }


    public void SelectMatrix1_2()
    {
        MatrixHeight_2 = 9.6f;
        MatrixWidth_2 = 12.8f;
        FocalLength_2 = 2.8f;
        Range_2 = 6f;
        Resolution_2 = 380f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);

    }

    public void SelectMatrix2_2()
    {
        MatrixHeight_2 = 6.4f;
        MatrixWidth_2 = 4.8f;
        FocalLength_2 = 4f;
        Range_2 = 9f;
        Resolution_2 = 400f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);

    }

    public void SelectMatrix3_2()
    {
        MatrixHeight_2 = 4.8f;
        MatrixWidth_2 = 3.6f;
        FocalLength_2 = 6f;
        Range_2 = 10f;
        Resolution_2 = 390f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);
    }

    public void SelectMatrix4_2()
    {
        MatrixHeight_2 = 2.4f;
        MatrixWidth_2 = 3.2f;
        FocalLength_2 = 8f;
        Range_2 = 4f;
        Resolution_2 = 420f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);
    }

    public void SelectMatrix5_2()
    {
        MatrixHeight_2 = 8.8f;
        MatrixWidth_2 = 6.6f;
        FocalLength_2 = 12f;
        Range_2 = 7f;
        Resolution_2 = 410f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);
    }

    public void SelectMatrix6_2()
    {
        MatrixHeight_2 = 17.8f;
        MatrixWidth_2 = 10f;
        FocalLength_2 = 16f;
        Range_2 = 8f;
        Resolution_2 = 305f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);
    }

    public void SelectMatrix7_2()
    {
        MatrixHeight_2 = 23.6f;
        MatrixWidth_2 = 15.5f;
        FocalLength_2 = 25f;
        Range_2 = 130f;
        Resolution_2 = 310f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);
    }

    public void SelectMatrix8_2()
    {
        MatrixHeight_2 = 24.89f;
        MatrixWidth_2 = 18.66f;
        FocalLength_2 = 50f;
        Range_2 = 100f;
        Resolution_2 = 315f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);
    }

    public void SelectMatrix9_2()
    {
        MatrixHeight_2 = 28.7f;
        MatrixWidth_2 = 19.1f;
        FocalLength_2 = 75f;
        Range_2 = 90f;
        Resolution_2 = 300f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);
    }

    public void SelectMatrix10_2()
    {
        MatrixHeight_2 = 36f;
        MatrixWidth_2 = 24f;
        FocalLength_2 = 100f;
        Range_2 = 80f;
        Resolution_2 = 320f;
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(true);
    }

    public void SelectMatrix1_3()
    {
        MatrixHeight_3 = 9.6f;
        MatrixWidth_3 = 12.8f;
        FocalLength_3 = 2.8f;
        Range_3 = 6f;
        Resolution_3 = 380f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);

    }

    public void SelectMatrix2_3()
    {
        MatrixHeight_3 = 6.4f;
        MatrixWidth_3 = 4.8f;
        FocalLength_3 = 4f;
        Range_3 = 9f;
        Resolution_3 = 400f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);

    }

    public void SelectMatrix3_3()
    {
        MatrixHeight_3 = 4.8f;
        MatrixWidth_3 = 3.6f;
        FocalLength_3 = 6f;
        Range_3 = 10f;
        Resolution_3 = 390f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);
    }

    public void SelectMatrix4_3()
    {
        MatrixHeight_3 = 2.4f;
        MatrixWidth_3 = 3.2f;
        FocalLength_3 = 8f;
        Range_3 = 4f;
        Resolution_3 = 420f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);
    }

    public void SelectMatrix5_3()
    {
        MatrixHeight_3 = 8.8f;
        MatrixWidth_3 = 6.6f;
        FocalLength_3 = 12f;
        Range_3 = 7f;
        Resolution_3 = 410f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);
    }

    public void SelectMatrix6_3()
    {
        MatrixHeight_3 = 17.8f;
        MatrixWidth_3 = 10f;
        FocalLength_3 = 16f;
        Range_3 = 8f;
        Resolution_3 = 305f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);
    }

    public void SelectMatrix7_3()
    {
        MatrixHeight_3 = 23.6f;
        MatrixWidth_3 = 15.5f;
        FocalLength_3 = 25f;
        Range_3 = 130f;
        Resolution_3 = 310f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);
    }

    public void SelectMatrix8_3()
    {
        MatrixHeight_3 = 24.89f;
        MatrixWidth_3 = 18.66f;
        FocalLength_3 = 50f;
        Range_3 = 100f;
        Resolution_3 = 315f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);
    }

    public void SelectMatrix9_3()
    {
        MatrixHeight_3 = 28.7f;
        MatrixWidth_3 = 19.1f;
        FocalLength_3 = 75f;
        Range_3 = 90f;
        Resolution_3 = 300f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);
    }

    public void SelectMatrix10_3()
    {
        MatrixHeight_3 = 36f;
        MatrixWidth_3 = 24f;
        FocalLength_3 = 100f;
        Range_3 = 80f;
        Resolution_3 = 320f;
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(true);
    }

    public void SelectMatrix1_4()
    {
        MatrixHeight_4 = 9.6f;
        MatrixWidth_4 = 12.8f;
        FocalLength_4 = 2.8f;
        Range_4 = 6f;
        Resolution_4 = 380f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);

    }

    public void SelectMatrix2_4()
    {
        MatrixHeight_4 = 6.4f;
        MatrixWidth_4 = 4.8f;
        FocalLength_4 = 4f;
        Range_4 = 9f;
        Resolution_4 = 400f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);

    }

    public void SelectMatrix3_4()
    {
        MatrixHeight_4 = 4.8f;
        MatrixWidth_4 = 3.6f;
        FocalLength_4 = 6f;
        Range_4 = 10f;
        Resolution_4 = 390f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);
    }

    public void SelectMatrix4_4()
    {
        MatrixHeight_4 = 2.4f;
        MatrixWidth_4 = 3.2f;
        FocalLength_4 = 8f;
        Range_4 = 4f;
        Resolution_4 = 420f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);
    }

    public void SelectMatrix5_4()
    {
        MatrixHeight_4 = 8.8f;
        MatrixWidth_4 = 6.6f;
        FocalLength_4 = 12f;
        Range_4 = 7f;
        Resolution_4 = 410f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);
    }

    public void SelectMatrix6_4()
    {
        MatrixHeight_4 = 17.8f;
        MatrixWidth_4 = 10f;
        FocalLength_4 = 16f;
        Range_4 = 8f;
        Resolution_4 = 305f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);
    }

    public void SelectMatrix7_4()
    {
        MatrixHeight_4 = 23.6f;
        MatrixWidth_4 = 15.5f;
        FocalLength_4 = 25f;
        Range_4 = 130f;
        Resolution_4 = 310f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);
    }

    public void SelectMatrix8_4()
    {
        MatrixHeight_4 = 24.89f;
        MatrixWidth_4 = 18.66f;
        FocalLength_4 = 50f;
        Range_4 = 100f;
        Resolution_4 = 315f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);
    }

    public void SelectMatrix9_4()
    {
        MatrixHeight_4 = 28.7f;
        MatrixWidth_4 = 19.1f;
        FocalLength_4 = 75f;
        Range_4 = 90f;
        Resolution_4 = 300f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);
    }

    public void SelectMatrix10_4()
    {
        MatrixHeight_4 = 36f;
        MatrixWidth_4 = 24f;
        FocalLength_4 = 100f;
        Range_4 = 80f;
        Resolution_4 = 320f;
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(true);
    }

    public void SelectMatrix1_5()
    {
        MatrixHeight_5 = 9.6f;
        MatrixWidth_5 = 12.8f;
        FocalLength_5 = 2.8f;
        Range_5 = 6f;
        Resolution_5 = 380f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);

    }

    public void SelectMatrix2_5()
    {
        MatrixHeight_5 = 6.4f;
        MatrixWidth_5 = 4.8f;
        FocalLength_5 = 4f;
        Range_5 = 9f;
        Resolution_5 = 400f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);

    }

    public void SelectMatrix3_5()
    {
        MatrixHeight_5 = 4.8f;
        MatrixWidth_5 = 3.6f;
        FocalLength_5 = 6f;
        Range_5 = 10f;
        Resolution_5 = 390f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);
    }

    public void SelectMatrix4_5()
    {
        MatrixHeight_5 = 2.4f;
        MatrixWidth_5 = 3.2f;
        FocalLength_5 = 8f;
        Range_5 = 4f;
        Resolution_5 = 420f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);
    }

    public void SelectMatrix5_5()
    {
        MatrixHeight_5 = 8.8f;
        MatrixWidth_5 = 6.6f;
        FocalLength_5 = 12f;
        Range_5 = 7f;
        Resolution_5 = 410f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);
    }

    public void SelectMatrix6_5()
    {
        MatrixHeight_5 = 17.8f;
        MatrixWidth_5 = 10f;
        FocalLength_5 = 16f;
        Range_5 = 8f;
        Resolution_5 = 305f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);
    }

    public void SelectMatrix7_5()
    {
        MatrixHeight_5 = 23.6f;
        MatrixWidth_5 = 15.5f;
        FocalLength_5 = 25f;
        Range_5 = 130f;
        Resolution_5 = 310f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);
    }

    public void SelectMatrix8_5()
    {
        MatrixHeight_5 = 24.89f;
        MatrixWidth_5 = 18.66f;
        FocalLength_5 = 50f;
        Range_5 = 100f;
        Resolution_5 = 315f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);
    }

    public void SelectMatrix9_5()
    {
        MatrixHeight_5 = 28.7f;
        MatrixWidth_5 = 19.1f;
        FocalLength_5 = 75f;
        Range_5 = 90f;
        Resolution_5 = 300f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);
    }

    public void SelectMatrix10_5()
    {
        MatrixHeight_5 = 36f;
        MatrixWidth_5 = 24f;
        FocalLength_5 = 100f;
        Range_5 = 80f;
        Resolution_5 = 320f;
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(true);
    }

    public void SelectMatrix1_6()
    {
        MatrixHeight_6 = 9.6f;
        MatrixWidth_6 = 12.8f;
        FocalLength_6 = 2.8f;
        Range_6 = 6f;
        Resolution_6 = 380f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);

    }

    public void SelectMatrix2_6()
    {
        MatrixHeight_6 = 6.4f;
        MatrixWidth_6 = 4.8f;
        FocalLength_6 = 4f;
        Range_6 = 9f;
        Resolution_6 = 400f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);

    }

    public void SelectMatrix3_6()
    {
        MatrixHeight_6 = 4.8f;
        MatrixWidth_6 = 3.6f;
        FocalLength_6 = 6f;
        Range_6 = 10f;
        Resolution_6 = 390f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);
    }

    public void SelectMatrix4_6()
    {
        MatrixHeight_6 = 2.4f;
        MatrixWidth_6 = 3.2f;
        FocalLength_6 = 8f;
        Range_6 = 4f;
        Resolution_6 = 420f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);
    }

    public void SelectMatrix5_6()
    {
        MatrixHeight_6 = 8.8f;
        MatrixWidth_6 = 6.6f;
        FocalLength_6 = 12f;
        Range_6 = 7f;
        Resolution_6 = 410f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);
    }

    public void SelectMatrix6_6()
    {
        MatrixHeight_6 = 17.8f;
        MatrixWidth_6 = 10f;
        FocalLength_6 = 16f;
        Range_6 = 8f;
        Resolution_6 = 305f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);
    }

    public void SelectMatrix7_6()
    {
        MatrixHeight_6 = 23.6f;
        MatrixWidth_6 = 15.5f;
        FocalLength_6 = 25f;
        Range_6 = 130f;
        Resolution_6 = 310f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);
    }

    public void SelectMatrix8_6()
    {
        MatrixHeight_6 = 24.89f;
        MatrixWidth_6 = 18.66f;
        FocalLength_6 = 50f;
        Range_6 = 100f;
        Resolution_6 = 315f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);
    }

    public void SelectMatrix9_6()
    {
        MatrixHeight_6 = 28.7f;
        MatrixWidth_6 = 19.1f;
        FocalLength_6 = 75f;
        Range_6 = 90f;
        Resolution_6 = 300f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);
    }

    public void SelectMatrix10_6()
    {
        MatrixHeight_6 = 36f;
        MatrixWidth_6 = 24f;
        FocalLength_6 = 100f;
        Range_6 = 80f;
        Resolution_6 = 320f;
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(true);
    }

    public void SelectMatrix1_7()
    {
        MatrixHeight_7 = 9.6f;
        MatrixWidth_7 = 12.8f;
        FocalLength_7 = 2.8f;
        Range_7 = 6f;
        Resolution_7 = 380f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);

    }

    public void SelectMatrix2_7()
    {
        MatrixHeight_7 = 6.4f;
        MatrixWidth_7 = 4.8f;
        FocalLength_7 = 4f;
        Range_7 = 9f;
        Resolution_7 = 400f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);

    }

    public void SelectMatrix3_7()
    {
        MatrixHeight_7 = 4.8f;
        MatrixWidth_7 = 3.6f;
        FocalLength_7 = 6f;
        Range_7 = 10f;
        Resolution_7 = 390f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);
    }

    public void SelectMatrix4_7()
    {
        MatrixHeight_7 = 2.4f;
        MatrixWidth_7 = 3.2f;
        FocalLength_7 = 8f;
        Range_7 = 4f;
        Resolution_7 = 420f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);
    }

    public void SelectMatrix5_7()
    {
        MatrixHeight_7 = 8.8f;
        MatrixWidth_7 = 6.6f;
        FocalLength_7 = 12f;
        Range_7 = 7f;
        Resolution_7 = 410f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);
    }

    public void SelectMatrix6_7()
    {
        MatrixHeight_7 = 17.8f;
        MatrixWidth_7 = 10f;
        FocalLength_7 = 16f;
        Range_7 = 8f;
        Resolution_7 = 305f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);
    }

    public void SelectMatrix7_7()
    {
        MatrixHeight_7 = 23.6f;
        MatrixWidth_7 = 15.5f;
        FocalLength_7 = 25f;
        Range_7 = 130f;
        Resolution_7 = 310f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);
    }

    public void SelectMatrix8_7()
    {
        MatrixHeight_7 = 24.89f;
        MatrixWidth_7 = 18.66f;
        FocalLength_7 = 50f;
        Range_7 = 100f;
        Resolution_7 = 315f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);
    }

    public void SelectMatrix9_7()
    {
        MatrixHeight_7 = 28.7f;
        MatrixWidth_7 = 19.1f;
        FocalLength_7 = 75f;
        Range_7 = 90f;
        Resolution_7 = 300f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);
    }

    public void SelectMatrix10_7()
    {
        MatrixHeight_7 = 36f;
        MatrixWidth_7 = 24f;
        FocalLength_7 = 100f;
        Range_7 = 80f;
        Resolution_7 = 320f;
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(true);
    }

    public void SelectMatrix1_8()
    {
        MatrixHeight_8 = 9.6f;
        MatrixWidth_8 = 12.8f;
        FocalLength_8 = 2.8f;
        Range_8 = 6f;
        Resolution_8 = 380f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);
    }

    public void SelectMatrix2_8()
    {
        MatrixHeight_8 = 6.4f;
        MatrixWidth_8 = 4.8f;
        FocalLength_8 = 4f;
        Range_8 = 9f;
        Resolution_8 = 400f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);
    }

    public void SelectMatrix3_8()
    {
        MatrixHeight_8 = 4.8f;
        MatrixWidth_8 = 3.6f;
        FocalLength_8 = 6f;
        Range_8 = 10f;
        Resolution_8 = 390f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);
    }

    public void SelectMatrix4_8()
    {
        MatrixHeight_8 = 2.4f;
        MatrixWidth_8 = 3.2f;
        FocalLength_8 = 8f;
        Range_8 = 4f;
        Resolution_8 = 420f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);
    }

    public void SelectMatrix5_8()
    {
        MatrixHeight_8 = 8.8f;
        MatrixWidth_8 = 6.6f;
        FocalLength_8 = 12f;
        Range_8 = 7f;
        Resolution_8 = 410f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);
    }

    public void SelectMatrix6_8()
    {
        MatrixHeight_8 = 17.8f;
        MatrixWidth_8 = 10f;
        FocalLength_8 = 16f;
        Range_8 = 8f;
        Resolution_8 = 305f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);
    }

    public void SelectMatrix7_8()
    {
        MatrixHeight_8 = 23.6f;
        MatrixWidth_8 = 15.5f;
        FocalLength_8 = 25f;
        Range_8 = 130f;
        Resolution_8 = 310f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);
    }

    public void SelectMatrix8_8()
    {
        MatrixHeight_8 = 24.89f;
        MatrixWidth_8 = 18.66f;
        FocalLength_8 = 50f;
        Range_8 = 100f;
        Resolution_8 = 315f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);
    }

    public void SelectMatrix9_8()
    {
        MatrixHeight_8 = 28.7f;
        MatrixWidth_8 = 19.1f;
        FocalLength_8 = 75f;
        Range_8 = 90f;
        Resolution_8 = 300f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);
    }

    public void SelectMatrix10_8()
    {
        MatrixHeight_8 = 36f;
        MatrixWidth_8 = 24f;
        FocalLength_8 = 100f;
        Range_8 = 80f;
        Resolution_8 = 320f;
        MatrixPanel8.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Matrixes.SetActive(false);

    }

    private void Start()
    {
        MatrixPanel.SetActive(true);
        MatrixPanel2.SetActive(false);
        MatrixPanel3.SetActive(false);
        MatrixPanel4.SetActive(false);
        MatrixPanel5.SetActive(false);
        MatrixPanel6.SetActive(false);
        MatrixPanel7.SetActive(false);
        MatrixPanel8.SetActive(false);
        
        MainMenuActive = true;
        InputBackground.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
    }




}
