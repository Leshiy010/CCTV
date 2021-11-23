using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RayPoint : MonoBehaviour
{

    public Transform Pointer;
    public Selectable CurrentSelectable;
    public GameObject objToSpawn;

    public GameObject CCTV;
    public Camera camCCTV;
    public GameObject CCTV2;
    public Camera cam2CCTV;
    public GameObject CCTV3;
    public Camera cam3CCTV;
    public GameObject CCTV4;
    public Camera cam4CCTV;
    public GameObject CCTV5;
    public Camera cam5CCTV;
    public GameObject CCTV6;
    public Camera cam6CCTV;
    public GameObject CCTV7;
    public Camera cam7CCTV;
    public GameObject CCTV8;
    public Camera cam8CCTV;


    public RaycastHit hit;
    public RaycastHit CCTVhit;
    public RaycastHit CCTV2hit;
    public RaycastHit CCTV3hit;
    public RaycastHit CCTV4hit;
    public RaycastHit CCTV5hit;
    public RaycastHit CCTV6hit;
    public RaycastHit CCTV7hit;
    public RaycastHit CCTV8hit;

    public RaycastHit GroundHit; // Хитпоинт перпендикулярного луча
    public RaycastHit SecondGroundHit;
    public RaycastHit ThirdGroundHit;
    public RaycastHit FourthGroundHit;
    public RaycastHit FifthGroundHit;
    public RaycastHit SixthGroundHit;
    public RaycastHit SeventhGroundHit;
    public RaycastHit EighthGroundHit;

    public RaycastHit WallHit; // Хит луча до стены из хита перпендикуляра
    public RaycastHit WallHit2;
    public RaycastHit WallHit3;
    public RaycastHit WallHit4;
    public RaycastHit WallHit5;
    public RaycastHit WallHit6;
    public RaycastHit WallHit7;
    public RaycastHit WallHit8;


    public float L; // Расстояние от камеры до наблюдаемого обьекта
    public float H; // Расстояние от пола до объектива 
    public float L1; // Расстояние до стены 
    public float DeadZoneFormula;
    public float MinmalObjectFormula;
    static float horFOV1;

    public float L2; // Расстояние от камеры до наблюдаемого обьекта
    public float H2; // Расстояние от пола до объектива 
    public float L1_2; // Расстояние до стены 
    public float DeadZoneFormula2;
    public float MinmalObjectFormula2;
    public float horFOV2;

    public float L3; // Расстояние от камеры до наблюдаемого обьекта
    public float H3; // Расстояние от пола до объектива 
    public float L1_3; // Расстояние до стены 
    public float DeadZoneFormula3;
    public float MinmalObjectFormula3;
    public float horFOV3;

    public float L4; // Расстояние от камеры до наблюдаемого обьекта
    public float H4; // Расстояние от пола до объектива 
    public float L1_4; // Расстояние до стены 
    public float DeadZoneFormula4;
    public float MinmalObjectFormula4;
    public float horFOV4;

    public float L5; // Расстояние от камеры до наблюдаемого обьекта
    public float H5; // Расстояние от пола до объектива 
    public float L1_5; // Расстояние до стены 
    public float DeadZoneFormula5;
    public float MinmalObjectFormula5;
    public float horFOV5;

    public float L6; // Расстояние от камеры до наблюдаемого обьекта
    public float H6; // Расстояние от пола до объектива 
    public float L1_6; // Расстояние до стены 
    public float DeadZoneFormula6;
    public float MinmalObjectFormula6;
    public float horFOV6;

    public float L7; // Расстояние от камеры до наблюдаемого обьекта
    public float H7; // Расстояние от пола до объектива 
    public float L1_7; // Расстояние до стены 
    public float DeadZoneFormula7;
    public float MinmalObjectFormula7;
    public float horFOV7;

    public float L8; // Расстояние от камеры до наблюдаемого обьекта
    public float H8; // Расстояние от пола до объектива 
    public float L1_8; // Расстояние до стены 
    public float DeadZoneFormula8;
    public float MinmalObjectFormula8;
    public float horFOV8;

    public Camera PlayerCamera;

    public TextMeshProUGUI MinimalObject;
    public TextMeshProUGUI DeadZone;
    public TextMeshProUGUI MinimalObject2;
    public TextMeshProUGUI DeadZone2;
    public TextMeshProUGUI MinimalObject3;
    public TextMeshProUGUI DeadZone3;
    public TextMeshProUGUI MinimalObject4;
    public TextMeshProUGUI DeadZone4;
    public TextMeshProUGUI MinimalObject5;
    public TextMeshProUGUI DeadZone5;
    public TextMeshProUGUI MinimalObject6;
    public TextMeshProUGUI DeadZone6;
    public TextMeshProUGUI MinimalObject7;
    public TextMeshProUGUI DeadZone7;
    public TextMeshProUGUI MinimalObject8;
    public TextMeshProUGUI DeadZone8;

    public Text cam1height;
    public Text cam2height;
    public Text cam3height;
    public Text cam4height;
    public Text cam5height;
    public Text cam6height;
    public Text cam7height;
    public Text cam8height;
    public Text VertFOV1Text;
    public Text VertFOV2Text;
    public Text VertFOV3Text;
    public Text VertFOV4Text;
    public Text VertFOV5Text;
    public Text VertFOV6Text;
    public Text VertFOV7Text;
    public Text VertFOV8Text;
    public Text HorFOV1Text;
    public Text HorFOV2Text;
    public Text HorFOV3Text;
    public Text HorFOV4Text;
    public Text HorFOV5Text;
    public Text HorFOV6Text;
    public Text HorFOV7Text;
    public Text HorFOV8Text;

    public GameObject cam1heightButton;
    public GameObject cam2heightButton;
    public GameObject cam3heightButton;
    public GameObject cam4heightButton;
    public GameObject cam5heightButton;
    public GameObject cam6heightButton;
    public GameObject cam7heightButton;
    public GameObject cam8heightButton;
    public GameObject VertFOV1Button;
    public GameObject VertFOV2Button;
    public GameObject VertFOV3Button;
    public GameObject VertFOV4Button;
    public GameObject VertFOV5Button;
    public GameObject VertFOV6Button;
    public GameObject VertFOV7Button;
    public GameObject VertFOV8Button;
    public GameObject HorFOV1Button;
    public GameObject HorFOV2Button;
    public GameObject HorFOV3Button;
    public GameObject HorFOV4Button;
    public GameObject HorFOV5Button;
    public GameObject HorFOV6Button;
    public GameObject HorFOV7Button;
    public GameObject HorFOV8Button;


    public GameObject InputRotTrigger;
    public GameObject InputRotTrigger2;
    public GameObject InputRotTrigger3;
    public GameObject InputRotTrigger4;
    public GameObject InputRotTrigger5;
    public GameObject InputRotTrigger6;
    public GameObject InputRotTrigger7;
    public GameObject InputRotTrigger8;

    public GameObject Kronshtein;
    public GameObject Kronshtein2;
    public GameObject Kronshtein3;
    public GameObject Kronshtein4;
    public GameObject Kronshtein5;
    public GameObject Kronshtein6;
    public GameObject Kronshtein7;
    public GameObject Kronshtein8;

    public InputField camRotY;
    public InputField camRotZplus;
    public InputField camRotZminus;
    public InputField Kron1;
    public InputField cam2RotY;
    public InputField cam2RotZplus;
    public InputField cam2RotZminus;
    public InputField Kron2;
    public InputField cam3RotY;
    public InputField cam3RotZplus;
    public InputField cam3RotZminus;
    public InputField Kron3;
    public InputField cam4RotY;
    public InputField cam4RotZplus;
    public InputField cam4RotZminus;
    public InputField Kron4;
    public InputField cam5RotY;
    public InputField cam5RotZplus;
    public InputField cam5RotZminus;
    public InputField Kron5;
    public InputField cam6RotY;
    public InputField cam6RotZplus;
    public InputField cam6RotZminus;
    public InputField Kron6;
    public InputField cam7RotY;
    public InputField cam7RotZplus;
    public InputField cam7RotZminus;
    public InputField Kron7;
    public InputField cam8RotY;
    public InputField cam8RotZplus;
    public InputField cam8RotZminus;
    public InputField Kron8;


    float camRotYChest;
    float camRotZplusChest;
    float camRotZminusChest;
    public static float Kron1Chest;
    float cam2RotYChest;
    float cam2RotZplusChest;
    float cam2RotZminusChest;
    public static float Kron2Chest;
    float cam3RotYChest;
    float cam3RotZplusChest;
    float cam3RotZminusChest;
    public static float Kron3Chest;
    float cam4RotYChest;
    float cam4RotZplusChest;
    float cam4RotZminusChest;
    public static float Kron4Chest;
    float cam5RotYChest;
    float cam5RotZplusChest;
    float cam5RotZminusChest;
    public static float Kron5Chest;
    float cam6RotYChest;
    float cam6RotZplusChest;
    float cam6RotZminusChest;
    public static float Kron6Chest;
    float cam7RotYChest;
    float cam7RotZplusChest;
    float cam7RotZminusChest;
    public static float Kron7Chest;
    float cam8RotYChest;
    float cam8RotZplusChest;
    float cam8RotZminusChest;
    public static float Kron8Chest;

    public GameObject Matrix;
    public GameObject Background;

    public GameObject DeadZoneButton;
    public GameObject MinimalObjectButton;
    public GameObject DeadZoneButton2;
    public GameObject MinimalObjectButton2;
    public GameObject DeadZoneButton3;
    public GameObject MinimalObjectButton3;
    public GameObject DeadZoneButton4;
    public GameObject MinimalObjectButton4;
    public GameObject DeadZoneButton5;
    public GameObject MinimalObjectButton5;
    public GameObject DeadZoneButton6;
    public GameObject MinimalObjectButton6;
    public GameObject DeadZoneButton7;
    public GameObject MinimalObjectButton7;
    public GameObject DeadZoneButton8;
    public GameObject MinimalObjectButton8;

    public GameObject FormDescription1;
    public GameObject FormDescription2;
    public GameObject FormDescription3;
    public GameObject FormDescription4;
    public GameObject FormDescription5;
    public GameObject FormDescription6;
    public GameObject FormDescription7;
    public GameObject FormDescription8;


    float count1;
    float count2;
    float count3;
    float count4;
    float count5;
    float count6;
    float count7;
    float count8;

    public void LateUpdate()
    {  
        Ray ray = new Ray(transform.position, transform.forward); // Луч из камеры игрока
        Debug.DrawRay(transform.position, transform.forward * 1000f, Color.red);

        Ray CCTVray = new Ray(camCCTV.transform.position, camCCTV.transform.forward * 100f);  //  Луч из CCTV
        Debug.DrawRay(camCCTV.transform.position, camCCTV.transform.forward * 100f, Color.green);
        Ray CCTV2ray = new Ray(cam2CCTV.transform.position, cam2CCTV.transform.forward * 100f);
        Ray CCTV3ray = new Ray(cam3CCTV.transform.position, cam3CCTV.transform.forward * 100f);
        Ray CCTV4ray = new Ray(cam4CCTV.transform.position, cam4CCTV.transform.forward * 100f);
        Ray CCTV5ray = new Ray(cam5CCTV.transform.position, cam5CCTV.transform.forward * 100f);
        Ray CCTV6ray = new Ray(cam6CCTV.transform.position, cam6CCTV.transform.forward * 100f);
        Ray CCTV7ray = new Ray(cam7CCTV.transform.position, cam7CCTV.transform.forward * 100f);
        Ray CCTV8ray = new Ray(cam8CCTV.transform.position, cam8CCTV.transform.forward * 100f);

        Ray CCTVgroundRay = new Ray(camCCTV.transform.position, Vector3.down); // Перпендикуляр от CCTV до пола
        Debug.DrawRay(camCCTV.transform.position, Vector3.down * 100f, Color.blue);
        Ray CCTV2groundRay = new Ray(cam2CCTV.transform.position, Vector3.down);
        Ray CCTV3groundRay = new Ray(cam3CCTV.transform.position, Vector3.down);
        Ray CCTV4groundRay = new Ray(cam4CCTV.transform.position, Vector3.down);
        Ray CCTV5groundRay = new Ray(cam5CCTV.transform.position, Vector3.down);
        Ray CCTV6groundRay = new Ray(cam6CCTV.transform.position, Vector3.down);
        Ray CCTV7groundRay = new Ray(cam7CCTV.transform.position, Vector3.down);
        Ray CCTV8groundRay = new Ray(cam8CCTV.transform.position, Vector3.down);

        Ray CCTVwallRay = new Ray(GroundHit.point, camCCTV.transform.forward * 100f); // Луч из хита перпендикуляра до стены
        Debug.DrawRay(GroundHit.point, -camCCTV.transform.forward * 100f, Color.red);
        Ray CCTV2wallRay = new Ray(SecondGroundHit.point, cam2CCTV.transform.forward * 100f); // Луч из хита перпендикуляра до стены
        Ray CCTV3wallRay = new Ray(ThirdGroundHit.point, cam3CCTV.transform.forward * 100f); // Луч из хита перпендикуляра до стены
        Ray CCTV4wallRay = new Ray(FourthGroundHit.point, cam4CCTV.transform.forward * 100f); // Луч из хита перпендикуляра до стены
        Ray CCTV5wallRay = new Ray(FifthGroundHit.point, cam5CCTV.transform.forward * 100f); // Луч из хита перпендикуляра до стены
        Ray CCTV6wallRay = new Ray(SixthGroundHit.point, cam6CCTV.transform.forward * 100f); // Луч из хита перпендикуляра до стены
        Ray CCTV7wallRay = new Ray(SeventhGroundHit.point, cam7CCTV.transform.forward * 100f); // Луч из хита перпендикуляра до стены
        Ray CCTV8wallRay = new Ray(EighthGroundHit.point, cam8CCTV.transform.forward * 100f); // Луч из хита перпендикуляра до стены

        float CCTV1VerticalFOV = camCCTV.fieldOfView; // Вытаскиваю поле обзора по вертикали.


        if (Physics.Raycast(CCTVray, out CCTVhit))
        {
            L = (camCCTV.transform.position - CCTVhit.point).magnitude; 
            
        }

        if (Physics.Raycast(CCTVgroundRay, out GroundHit)) // Перпендикуляр от обьекта 
        {
            H = (camCCTV.transform.position - GroundHit.point).magnitude;
           
        }

        if (Physics.Raycast(CCTVwallRay, out WallHit))
        {
            L1 = (GroundHit.point - WallHit.point).magnitude;
            
        }

        //////////////////////////////////////////////////////////////////////

        if (Physics.Raycast(CCTV2ray, out CCTV2hit))
        {
            L2 = (cam2CCTV.transform.position - CCTV2hit.point).magnitude;

        }

        if (Physics.Raycast(CCTV2groundRay, out SecondGroundHit)) // Перпендикуляр от обьекта 
        {
            H2 = (cam2CCTV.transform.position - SecondGroundHit.point).magnitude;

        }

        if (Physics.Raycast(CCTV2wallRay, out WallHit2))
        {
            L1_2 = (SecondGroundHit.point - WallHit2.point).magnitude;

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        if (Physics.Raycast(CCTV3ray, out CCTV3hit))
        {
            L3 = (cam3CCTV.transform.position - CCTV3hit.point).magnitude;

        }

        if (Physics.Raycast(CCTV3groundRay, out ThirdGroundHit)) // Перпендикуляр от обьекта 
        {
            H3 = (cam3CCTV.transform.position - ThirdGroundHit.point).magnitude;

        }

        if (Physics.Raycast(CCTV3wallRay, out WallHit3))
        {
            L1_3 = (ThirdGroundHit.point - WallHit3.point).magnitude;

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (Physics.Raycast(CCTV4ray, out CCTV4hit))
        {
            L4 = (cam4CCTV.transform.position - CCTV4hit.point).magnitude;

        }

        if (Physics.Raycast(CCTV4groundRay, out FourthGroundHit)) // Перпендикуляр от обьекта 
        {
            H4 = (cam4CCTV.transform.position - FourthGroundHit.point).magnitude;

        }

        if (Physics.Raycast(CCTV4wallRay, out WallHit4))
        {
            L1_4 = (FourthGroundHit.point - WallHit4.point).magnitude;

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (Physics.Raycast(CCTV5ray, out CCTV5hit))
        {
            L5 = (cam5CCTV.transform.position - CCTV5hit.point).magnitude;

        }

        if (Physics.Raycast(CCTV5groundRay, out FifthGroundHit)) // Перпендикуляр от обьекта 
        {
            H5 = (cam5CCTV.transform.position - FifthGroundHit.point).magnitude;

        }

        if (Physics.Raycast(CCTV5wallRay, out WallHit5))
        {
            L1_5 = (FifthGroundHit.point - WallHit5.point).magnitude;

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        if (Physics.Raycast(CCTV6ray, out CCTV6hit))
        {
            L6 = (cam6CCTV.transform.position - CCTV6hit.point).magnitude;

        }

        if (Physics.Raycast(CCTV6groundRay, out SixthGroundHit)) // Перпендикуляр от обьекта 
        {
            H6 = (cam6CCTV.transform.position - SixthGroundHit.point).magnitude;

        }

        if (Physics.Raycast(CCTV6wallRay, out WallHit6))
        {
            L1_6 = (SixthGroundHit.point - WallHit6.point).magnitude;

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (Physics.Raycast(CCTVray, out CCTVhit))
        {
            L = (camCCTV.transform.position - CCTVhit.point).magnitude;

        }

        if (Physics.Raycast(CCTV7groundRay, out SeventhGroundHit)) // Перпендикуляр от обьекта 
        {
            H7 = (cam7CCTV.transform.position - SeventhGroundHit.point).magnitude;

        }

        if (Physics.Raycast(CCTV7wallRay, out WallHit7))
        {
            L1_7 = (SeventhGroundHit.point - WallHit7.point).magnitude;

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        if (Physics.Raycast(CCTV8ray, out CCTV8hit))
        {
            L8 = (cam8CCTV.transform.position - CCTV8hit.point).magnitude;

        }

        if (Physics.Raycast(CCTV8groundRay, out EighthGroundHit)) // Перпендикуляр от обьекта 
        {
            H8 = (cam8CCTV.transform.position - EighthGroundHit.point).magnitude;

        }

        if (Physics.Raycast(CCTV8wallRay, out WallHit8))
        {
            L1_8 = (GroundHit.point - WallHit.point).magnitude;

        }

        if (count1 == 1)
        {
            Activation1();
        }

        if (count2 == 1)
        {
            Activation2();
        }

        if (count3 == 1)
        {
            Activation3();
        }

        if (count4 == 1)
        {
            Activation4();
        }

        if (count5 == 1)
        {
            Activation5();
        }

        if (count6 == 1)
        {
            Activation6();
        }

        if (count7 == 1)
        {
            Activation7();
        }

        if (count8 == 1)
        {
            Activation8();
        }

        if (Physics.Raycast(ray, out hit))
        {
            Pointer.position = hit.point;
            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable)
            {

                Vector3 contact = hit.point;
                float count = 1f;
                if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    if (count == 1) {
                        Quaternion rotation = Quaternion.Euler(objToSpawn.transform.eulerAngles.x, objToSpawn.transform.eulerAngles.y, objToSpawn.transform.eulerAngles.z);
                        Instantiate(objToSpawn, contact, rotation);
                    }
                   

                    if (CurrentSelectable && CurrentSelectable != selectable)
                {
                    CurrentSelectable.Deselect();
                }
                CurrentSelectable = selectable;
                selectable.Select();
            } else
            {
                if(CurrentSelectable)
                {
                    CurrentSelectable.Deselect();
                    CurrentSelectable = null;
                }
            }
            } else
        {
            if (CurrentSelectable)
            {
                CurrentSelectable.Deselect();
                CurrentSelectable = null;
            }
        }


            DeadZoneFormula = Kron1Chest + H * Mathf.Tan((camCCTV.transform.eulerAngles.x - CCTV1VerticalFOV) / 2f);
            float DeadZoneFormulaRes = ((int)(DeadZoneFormula * 100)) / 100f;
            DeadZone.text = "Мёртвая зона: " + Mathf.Abs(DeadZoneFormulaRes).ToString() + " м.";

            MinmalObjectFormula = (150f * (L / MatrixSelection.Resolution)) * Mathf.Tan(CCTV1VerticalFOV / 2f);
            float MinimalObjectFormulaRes = ((int)(MinmalObjectFormula * 100)) / 100f;
            MinimalObject.text = "Минимальный размер различимого объекта: " + Mathf.Abs(MinimalObjectFormulaRes).ToString() + " см.";
            float height1 = ((int)(H * 100)) / 100f;
            cam1height.text = "Высота камеры: " + height1 + " м.";
            VertFOV1Text.text = "Результирующий угол обзора α: " + camCCTV.fieldOfView + "°";


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            DeadZoneFormula2 = Kron2Chest + H2 * Mathf.Tan((cam2CCTV.transform.eulerAngles.x - cam2CCTV.fieldOfView) / 2f);
            float DeadZoneFormulaRes2 = ((int)(DeadZoneFormula2 * 100)) / 100f;
            DeadZone2.text = "Мёртвая зона: " + Mathf.Abs(DeadZoneFormulaRes2).ToString() + " м.";

            MinmalObjectFormula2 = (150f * (L2 / MatrixSelection.Resolution_2)) * Mathf.Tan(cam2CCTV.fieldOfView / 2f);
            float MinimalObjectFormulaRes2 = ((int)(MinmalObjectFormula2 * 100)) / 100f;
            MinimalObject2.text = "Минимальный размер различимого объекта: " + Mathf.Abs(MinimalObjectFormulaRes2).ToString() + " см.";
            float height2 = ((int)(H2 * 100)) / 100f;
            cam2height.text = "Высота камеры: " + height2 + " м.";
            VertFOV2Text.text = "Результирующий угол обзора α: " + cam2CCTV.fieldOfView + "°";

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            DeadZoneFormula3 = Kron3Chest + H3 * Mathf.Tan((cam3CCTV.transform.eulerAngles.x - cam3CCTV.fieldOfView) / 2f);
            float DeadZoneFormulaRes3 = ((int)(DeadZoneFormula3 * 100)) / 100f;
            DeadZone3.text = "Мёртвая зона: " + Mathf.Abs(DeadZoneFormulaRes3).ToString() + " м.";

            MinmalObjectFormula3 = (150f * (L3 / MatrixSelection.Resolution_3)) * Mathf.Tan(cam3CCTV.fieldOfView / 2f);
            float MinimalObjectFormulaRes3 = ((int)(MinmalObjectFormula3 * 100)) / 100f;
            MinimalObject3.text = "Минимальный размер различимого объекта: " + Mathf.Abs(MinimalObjectFormulaRes3).ToString() + " см.";
            float height3 = ((int)(H3 * 100)) / 100f;
            cam3height.text = "Высота камеры: " + height3 + " м.";
            VertFOV3Text.text = "Результирующий угол обзора α: " + cam3CCTV.fieldOfView + "°";

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            DeadZoneFormula4 = Kron4Chest + H4 * Mathf.Tan((cam4CCTV.transform.eulerAngles.x - cam4CCTV.fieldOfView) / 2f);
            float DeadZoneFormulaRes4 = ((int)(DeadZoneFormula4 * 100)) / 100f;
            DeadZone4.text = "Мёртвая зона: " + Mathf.Abs(DeadZoneFormulaRes4).ToString() + " м.";

            MinmalObjectFormula4 = (150f * (L4 / MatrixSelection.Resolution_4)) * Mathf.Tan(cam4CCTV.fieldOfView / 2f);
            float MinimalObjectFormulaRes4 = ((int)(MinmalObjectFormula4 * 100)) / 100f;
            MinimalObject4.text = "Минимальный размер различимого объекта: " + Mathf.Abs(MinimalObjectFormulaRes4).ToString() + " см.";
            float height4 = ((int)(H4 * 100)) / 100f;
            cam4height.text = "Высота камеры: " + height4 + " м.";
            VertFOV4Text.text = "Результирующий угол обзора α: " + cam4CCTV.fieldOfView + "°";

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            DeadZoneFormula5 = Kron5Chest + H5 * Mathf.Tan((cam5CCTV.transform.eulerAngles.x - cam5CCTV.fieldOfView) / 2f);
            float DeadZoneFormulaRes5 = ((int)(DeadZoneFormula5 * 100)) / 100f;
            DeadZone5.text = "Мёртвая зона: " + Mathf.Abs(DeadZoneFormulaRes5).ToString() + " м.";

            MinmalObjectFormula5 = (150f * (L5 / MatrixSelection.Resolution_5)) * Mathf.Tan(cam5CCTV.fieldOfView / 2f);
            float MinimalObjectFormulaRes5 = ((int)(MinmalObjectFormula5 * 100)) / 100f;
            MinimalObject5.text = "Минимальный размер различимого объекта: " + Mathf.Abs(MinimalObjectFormulaRes5).ToString() + " см.";
            float height5 = ((int)(H5 * 100)) / 100f;
            cam5height.text = "Высота камеры: " + height5 + " м.";
            VertFOV5Text.text = "Результирующий угол обзора α: " + cam5CCTV.fieldOfView + "°";


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            DeadZoneFormula6 = Kron6Chest + H6 * Mathf.Tan((cam6CCTV.transform.eulerAngles.x - cam6CCTV.fieldOfView) / 2f);
            float DeadZoneFormulaRes6 = ((int)(DeadZoneFormula6 * 100)) / 100f;
            DeadZone6.text = "Мёртвая зона: " + Mathf.Abs(DeadZoneFormulaRes6).ToString() + " м.";

            MinmalObjectFormula6 = (150f * (L6 / MatrixSelection.Resolution_6)) * Mathf.Tan(cam6CCTV.fieldOfView / 2f);
            float MinimalObjectFormulaRes6 = ((int)(MinmalObjectFormula6 * 100)) / 100f;
            MinimalObject6.text = "Минимальный размер различимого объекта: " + Mathf.Abs(MinimalObjectFormulaRes6).ToString() + " см.";
            float height6 = ((int)(H6 * 100)) / 100f;
            cam6height.text = "Высота камеры: " + height6 + " м.";
            VertFOV6Text.text = "Результирующий угол обзора α: " + cam6CCTV.fieldOfView + "°";

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            DeadZoneFormula7 = Kron7Chest + H7 * Mathf.Tan((cam7CCTV.transform.eulerAngles.x - cam7CCTV.fieldOfView) / 2f);
            float DeadZoneFormulaRes7 = ((int)(DeadZoneFormula7 * 100)) / 100f;
            DeadZone7.text = "Мёртвая зона: " + Mathf.Abs(DeadZoneFormulaRes7).ToString() + " м.";

            MinmalObjectFormula7 = (150f * (L7 / MatrixSelection.Resolution_7)) * Mathf.Tan(cam7CCTV.fieldOfView / 2f);
            float MinimalObjectFormulaRes7 = ((int)(MinmalObjectFormula7 * 100)) / 100f;
            MinimalObject7.text = "Минимальный размер различимого объекта: " + Mathf.Abs(MinimalObjectFormulaRes7).ToString() + " см.";
            float height7 = ((int)(H7 * 100)) / 100f;
            cam7height.text = "Высота камеры: " + height7 + " м.";
            VertFOV7Text.text = "Результирующий угол обзора α: " + cam7CCTV.fieldOfView + "°";

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            DeadZoneFormula8 = Kron8Chest + H8 * Mathf.Tan((cam8CCTV.transform.eulerAngles.x - cam8CCTV.fieldOfView) / 2f);
            float DeadZoneFormulaRes8 = ((int)(DeadZoneFormula8 * 100)) / 100f;
            DeadZone8.text = "Мёртвая зона: " + Mathf.Abs(DeadZoneFormulaRes8).ToString() + " м.";

            MinmalObjectFormula8 = (150f * (L8 / MatrixSelection.Resolution_8)) * Mathf.Tan(cam8CCTV.fieldOfView / 2f);
            float MinimalObjectFormulaRes8 = ((int)(MinmalObjectFormula7 * 100)) / 100f;
            MinimalObject8.text = "Минимальный размер различимого объекта: " + Mathf.Abs(MinimalObjectFormulaRes8).ToString() + " см.";
            float height8 = ((int)(H8 * 100)) / 100f;
            cam8height.text = "Высота камеры: " + height8 + " м.";
            VertFOV8Text.text = "Результирующий угол обзора α: " + cam8CCTV.fieldOfView + "°";

            if ((hit.transform.gameObject.tag=="Wall") && (Input.GetKeyDown(KeyCode.Keypad1)))
            {
                CCTV.transform.position = Pointer.position + hit.normal * 0.13f;
                CCTV.transform.rotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                SetRot(); 
            }

            if ((hit.transform.gameObject.tag == "Wall") && (Input.GetKeyDown(KeyCode.Keypad2)))
            {
                CCTV2.transform.position = Pointer.position + hit.normal * 0.13f;
                CCTV2.transform.rotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                SetRot2();            
            }

            if ((hit.transform.gameObject.tag == "Wall") && (Input.GetKeyDown(KeyCode.Keypad3)))
            {
                CCTV3.transform.position = Pointer.position + hit.normal * 0.13f;
                CCTV3.transform.rotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                SetRot3();
            }

            if ((hit.transform.gameObject.tag == "Wall") && (Input.GetKeyDown(KeyCode.Keypad4)))
            {
                CCTV4.transform.position = Pointer.position + hit.normal * 0.13f;
                CCTV4.transform.rotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                SetRot4();
            }

            if ((hit.transform.gameObject.tag == "Wall") && (Input.GetKeyDown(KeyCode.Keypad5)))
            {
                CCTV5.transform.position = Pointer.position + hit.normal * 0.13f;
                CCTV5.transform.rotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                SetRot5();
            }

            if ((hit.transform.gameObject.tag == "Wall") && (Input.GetKeyDown(KeyCode.Keypad6)))
            {
                CCTV6.transform.position = Pointer.position + hit.normal * 0.13f;
                CCTV6.transform.rotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                SetRot6();
            }

            if ((hit.transform.gameObject.tag == "Wall") && (Input.GetKeyDown(KeyCode.Keypad7)))
            {
                CCTV7.transform.position = Pointer.position + hit.normal * 0.13f;
                CCTV7.transform.rotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                SetRot7();
            }

            if ((hit.transform.gameObject.tag == "Wall") && (Input.GetKeyDown(KeyCode.Keypad8)))
            {
                CCTV8.transform.position = Pointer.position + hit.normal * 0.13f;
                CCTV8.transform.rotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                SetRot8();
            }
        }

    }

    void ConvertFov()
    {
        camCCTV.fieldOfView  =  Mathf.Round(((2f * Mathf.Atan(MatrixSelection.MatrixWidth / (2f * MatrixSelection.FocalLength))) * 180f)/ 3.1415926535f);
        cam2CCTV.fieldOfView = Mathf.Round(((2f * Mathf.Atan(MatrixSelection.MatrixWidth_2 / (2f * MatrixSelection.FocalLength_2))) * 180f) / 3.1415926535f); 
        cam3CCTV.fieldOfView = Mathf.Round(((2f * Mathf.Atan(MatrixSelection.MatrixWidth_3 / (2f * MatrixSelection.FocalLength_3))) * 180f) / 3.1415926535f); 
        cam4CCTV.fieldOfView = Mathf.Round(((2f * Mathf.Atan(MatrixSelection.MatrixWidth_4 / (2f * MatrixSelection.FocalLength_4))) * 180f) / 3.1415926535f); 
        cam5CCTV.fieldOfView = Mathf.Round(((2f * Mathf.Atan(MatrixSelection.MatrixWidth_5 / (2f * MatrixSelection.FocalLength_5))) * 180f) / 3.1415926535f); 
        cam6CCTV.fieldOfView = Mathf.Round(((2f * Mathf.Atan(MatrixSelection.MatrixWidth_6 / (2f * MatrixSelection.FocalLength_6))) * 180f) / 3.1415926535f);
        cam7CCTV.fieldOfView = Mathf.Round(((2f * Mathf.Atan(MatrixSelection.MatrixWidth_7 / (2f * MatrixSelection.FocalLength_7))) * 180f) / 3.1415926535f);
        cam8CCTV.fieldOfView = Mathf.Round(((2f * Mathf.Atan(MatrixSelection.MatrixWidth_8 / (2f * MatrixSelection.FocalLength_8))) * 180f) / 3.1415926535f);
    }


    private void Start()
    {
        InputRotTrigger.SetActive(false);
        InputRotTrigger2.SetActive(false);
        InputRotTrigger3.SetActive(false);
        InputRotTrigger4.SetActive(false);
        InputRotTrigger5.SetActive(false);
        InputRotTrigger6.SetActive(false);
        InputRotTrigger7.SetActive(false);
        InputRotTrigger8.SetActive(false);


        DeadZoneButton.SetActive(false);
        MinimalObjectButton.SetActive(false);
        DeadZoneButton2.SetActive(false);
        MinimalObjectButton2.SetActive(false);
        DeadZoneButton3.SetActive(false);
        MinimalObjectButton3.SetActive(false);
        DeadZoneButton4.SetActive(false);
        MinimalObjectButton4.SetActive(false);
        DeadZoneButton5.SetActive(false);
        MinimalObjectButton5.SetActive(false);
        DeadZoneButton6.SetActive(false);
        MinimalObjectButton6.SetActive(false);
        DeadZoneButton7.SetActive(false);
        MinimalObjectButton7.SetActive(false);
        DeadZoneButton8.SetActive(false);
        MinimalObjectButton8.SetActive(false);

        FormDescription1.SetActive(false);
        FormDescription2.SetActive(false);
        FormDescription3.SetActive(false);
        FormDescription4.SetActive(false);
        FormDescription5.SetActive(false);
        FormDescription6.SetActive(false);
        FormDescription7.SetActive(false);
        FormDescription8.SetActive(false);

        cam1heightButton.SetActive(false);
        cam2heightButton.SetActive(false);
        cam3heightButton.SetActive(false);
        cam4heightButton.SetActive(false);
        cam5heightButton.SetActive(false);
        cam6heightButton.SetActive(false);
        cam7heightButton.SetActive(false);
        cam8heightButton.SetActive(false);

        VertFOV1Button.SetActive(false);
        VertFOV2Button.SetActive(false);
        VertFOV3Button.SetActive(false);
        VertFOV4Button.SetActive(false);
        VertFOV5Button.SetActive(false);
        VertFOV6Button.SetActive(false);
        VertFOV7Button.SetActive(false);
        VertFOV8Button.SetActive(false);

    }
    public void SetRot()
    {
        InputRotTrigger.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        if ((camRotY.text == "") || (camRotZplus.text == "") || (camRotZminus.text == "") || (Kron1.text == ""))
        {
        }
        else
        {
            
            if(InputRotTrigger.activeSelf)
            {
                camRotYChest = float.Parse(camRotY.text);
                camRotZplusChest = float.Parse(camRotZplus.text);
                camRotZplusChest = Mathf.Abs(camRotZplusChest);
                camRotZminusChest = float.Parse(camRotZminus.text);
                camRotZminusChest = Mathf.Abs(camRotZminusChest);
                camRotZminusChest = -camRotZminusChest;
                float RotRes1 = camRotZplusChest + camRotZminusChest;

                Kron1Chest = float.Parse(Kron1.text);
                CCTV.transform.position += new Vector3 (Kron1Chest,0f,0f);
                Kronshtein.transform.localScale = new Vector3(Kron1Chest*5f, 1f, 1f);
                CCTV.transform.Rotate(0f, camRotYChest, RotRes1);
                InputRotTrigger.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                DeadZoneButton.SetActive(true);
                MinimalObjectButton.SetActive(true);
                FormDescription1.SetActive(true);
                ++count1;
            }
            
        }
        
    }

    public void SetRot2()
    {
        InputRotTrigger2.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        if ((cam2RotY.text == "") || (cam2RotZplus.text == "") || (cam2RotZminus.text == "") || (Kron2.text == ""))
        {
        }
        else
        {

            if (InputRotTrigger2.activeSelf)
            {
                cam2RotYChest = float.Parse(cam2RotY.text);
                cam2RotZplusChest = float.Parse(cam2RotZplus.text);
                cam2RotZplusChest = Mathf.Abs(cam2RotZplusChest);
                cam2RotZminusChest = float.Parse(cam2RotZminus.text);
                cam2RotZminusChest = Mathf.Abs(cam2RotZminusChest);
                cam2RotZminusChest = -cam2RotZminusChest;
                float RotRes2 = cam2RotZplusChest + cam2RotZminusChest;
                Kron2Chest = float.Parse(Kron2.text);
                CCTV2.transform.position += new Vector3(Kron2Chest, 0f, 0f);
                Kronshtein2.transform.localScale = new Vector3(Kron2Chest*5f, 1f, 1f);
                CCTV2.transform.Rotate(0f, cam2RotYChest, RotRes2);
                InputRotTrigger2.SetActive(false);
                FormDescription2.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                ++count2;
               
            }

        }

    }

    public void SetRot3()
    {
        InputRotTrigger3.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        if ((cam3RotY.text == "") || (cam3RotZplus.text == "") || (cam3RotZminus.text == "") || (Kron3.text == ""))
        {
        }
        else
        {

            if (InputRotTrigger3.activeSelf)
            {
                cam3RotYChest = float.Parse(cam3RotY.text);
                cam3RotZplusChest = float.Parse(cam3RotZplus.text);
                cam3RotZplusChest = Mathf.Abs(cam3RotZplusChest);
                cam3RotZminusChest = float.Parse(cam3RotZminus.text);
                cam3RotZminusChest = Mathf.Abs(cam3RotZminusChest);
                cam3RotZminusChest = -cam3RotZminusChest;
                float RotRes3 = cam3RotZplusChest + cam3RotZminusChest;
                Kron3Chest = float.Parse(Kron3.text);
                CCTV3.transform.position += new Vector3(Kron3Chest, 0f, 0f);
                Kronshtein3.transform.localScale = new Vector3(Kron3Chest * 5f, 1f, 1f);
                CCTV2.transform.Rotate(0f, cam3RotYChest, RotRes3);
                InputRotTrigger3.SetActive(false);
                FormDescription3.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                ++count3;

            }

        }

    }

    public void SetRot4()
    {
        InputRotTrigger4.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        if ((cam4RotY.text == "") || (cam4RotZplus.text == "") || (cam4RotZminus.text == "") || (Kron4.text == ""))
        {
        }
        else
        {

            if (InputRotTrigger4.activeSelf)
            {
                cam4RotYChest = float.Parse(cam4RotY.text);
                cam4RotZplusChest = float.Parse(cam4RotZplus.text);
                cam4RotZplusChest = Mathf.Abs(cam4RotZplusChest);
                cam4RotZminusChest = float.Parse(cam4RotZminus.text);
                cam4RotZminusChest = Mathf.Abs(cam4RotZminusChest);
                cam4RotZminusChest = -cam4RotZminusChest;
                float RotRes4 = cam4RotZplusChest + cam4RotZminusChest;
                Kron4Chest = float.Parse(Kron4.text);
                CCTV4.transform.position += new Vector3(Kron4Chest, 0f, 0f);
                Kronshtein4.transform.localScale = new Vector3(Kron4Chest * 5f, 1f, 1f);
                CCTV4.transform.Rotate(0f, cam4RotYChest, RotRes4);
                InputRotTrigger4.SetActive(false);
                FormDescription4.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                ++count4;

            }

        }

    }

    public void SetRot5()
    {
        InputRotTrigger5.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        if ((cam5RotY.text == "") || (cam5RotZplus.text == "") || (cam5RotZminus.text == "") || (Kron5.text == ""))
        {
        }
        else
        {

            if (InputRotTrigger5.activeSelf)
            {
                cam5RotYChest = float.Parse(cam5RotY.text);
                cam5RotZplusChest = float.Parse(cam5RotZplus.text);
                cam5RotZplusChest = Mathf.Abs(cam5RotZplusChest);
                cam5RotZminusChest = float.Parse(cam5RotZminus.text);
                cam5RotZminusChest = Mathf.Abs(cam5RotZminusChest);
                cam5RotZminusChest = -cam5RotZminusChest;
                float RotRes5 = cam5RotZplusChest + cam5RotZminusChest;
                Kron5Chest = float.Parse(Kron5.text);
                CCTV5.transform.position += new Vector3(Kron5Chest, 0f, 0f);
                Kronshtein5.transform.localScale = new Vector3(Kron5Chest * 5f, 1f, 1f);
                CCTV5.transform.Rotate(0f, cam5RotYChest, RotRes5);
                InputRotTrigger5.SetActive(false);
                FormDescription5.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                ++count5;

            }

        }

    }

    public void SetRot6()
    {
        InputRotTrigger6.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        if ((cam6RotY.text == "") || (cam6RotZplus.text == "") || (cam6RotZminus.text == "") || (Kron6.text == ""))
        {
        }
        else
        {

            if (InputRotTrigger6.activeSelf)
            {
                cam6RotYChest = float.Parse(cam6RotY.text);
                cam6RotZplusChest = float.Parse(cam6RotZplus.text);
                cam6RotZplusChest = Mathf.Abs(cam6RotZplusChest);
                cam6RotZminusChest = float.Parse(cam6RotZminus.text);
                cam6RotZminusChest = Mathf.Abs(cam6RotZminusChest);
                cam6RotZminusChest = -cam6RotZminusChest;
                float RotRes6 = cam6RotZplusChest + cam6RotZminusChest;
                Kron6Chest = float.Parse(Kron6.text);
                CCTV6.transform.position += new Vector3(Kron6Chest, 0f, 0f);
                Kronshtein6.transform.localScale = new Vector3(Kron6Chest * 5f, 1f, 1f);
                CCTV6.transform.Rotate(0f, cam6RotYChest, RotRes6);
                InputRotTrigger6.SetActive(false);
                FormDescription6.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                ++count6;
            }

        }

    }

    public void SetRot7()
    {
        InputRotTrigger7.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        if ((cam7RotY.text == "") || (cam7RotZplus.text == "") || (cam7RotZminus.text == "") || (Kron7.text == ""))
        {
        }
        else
        {

            if (InputRotTrigger7.activeSelf)
            {
                cam7RotYChest = float.Parse(cam7RotY.text);
                cam7RotZplusChest = float.Parse(cam7RotZplus.text);
                cam7RotZplusChest = Mathf.Abs(cam7RotZplusChest);
                cam7RotZminusChest = float.Parse(cam7RotZminus.text);
                cam7RotZminusChest = Mathf.Abs(cam7RotZminusChest);
                cam7RotZminusChest = -cam7RotZminusChest;
                float RotRes7 = cam7RotZplusChest + cam7RotZminusChest;
                Kron7Chest = float.Parse(Kron7.text);
                CCTV7.transform.position += new Vector3(Kron7Chest, 0f, 0f);
                Kronshtein7.transform.localScale = new Vector3(Kron7Chest * 5f, 1f, 1f);
                CCTV7.transform.Rotate(0f, cam7RotYChest, RotRes7);
                InputRotTrigger7.SetActive(false);
                FormDescription7.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                ++count7;

            }

        }

    }

    public void SetRot8()
    {
        InputRotTrigger8.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        if ((cam8RotY.text == "") || (cam8RotZplus.text == "") || (cam8RotZminus.text == "") || (Kron8.text == ""))
        {
        }
        else
        {

            if (InputRotTrigger8.activeSelf)
            {   
                cam8RotYChest = float.Parse(cam8RotY.text);
                cam8RotZplusChest = float.Parse(cam8RotZplus.text);
                cam8RotZplusChest = Mathf.Abs(cam8RotZplusChest);
                cam8RotZminusChest = float.Parse(cam8RotZminus.text);
                cam8RotZminusChest = Mathf.Abs(cam8RotZminusChest);
                cam8RotZminusChest = -cam8RotZminusChest;
                float RotRes8 = cam8RotZplusChest + cam8RotZminusChest;
                Kron8Chest = float.Parse(Kron8.text);
                CCTV8.transform.position += new Vector3(Kron8Chest, 0f, 0f);
                Kronshtein8.transform.localScale = new Vector3(Kron8Chest * 5f, 1f, 1f);
                CCTV8.transform.Rotate(0f, cam8RotYChest, RotRes8);
                InputRotTrigger8.SetActive(false);
                FormDescription8.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                ++count8;

            }

        }

    }

    void Activation1() {
        DeadZoneButton.SetActive(true);
        MinimalObjectButton.SetActive(true);
        cam1heightButton.SetActive(true);
        VertFOV1Button.SetActive(true);

        ConvertFov();
    }
    
    void Activation2()
    {
        DeadZoneButton2.SetActive(true);
        MinimalObjectButton2.SetActive(true);
        cam2heightButton.SetActive(true);
        VertFOV2Button.SetActive(true);
    }

    void Activation3()
    {
        DeadZoneButton3.SetActive(true);
        MinimalObjectButton3.SetActive(true);
        cam3heightButton.SetActive(true);
        VertFOV3Button.SetActive(true);
    }

    void Activation4()
    {
        DeadZoneButton4.SetActive(true);
        MinimalObjectButton4.SetActive(true);
        cam4heightButton.SetActive(true);
        VertFOV4Button.SetActive(true);
    }

    void Activation5()
    {
        DeadZoneButton5.SetActive(true);
        MinimalObjectButton5.SetActive(true);
        cam5heightButton.SetActive(true);
        VertFOV5Button.SetActive(true);
    }

    void Activation6()
    {
        DeadZoneButton6.SetActive(true);
        MinimalObjectButton6.SetActive(true);
        cam6heightButton.SetActive(true);
        VertFOV6Button.SetActive(true);
    }

    void Activation7()
    {
        DeadZoneButton7.SetActive(true);
        MinimalObjectButton7.SetActive(true);
        cam7heightButton.SetActive(true);
        VertFOV7Button.SetActive(true);
    }

    void Activation8()
    {
        DeadZoneButton8.SetActive(true);
        MinimalObjectButton8.SetActive(true);
        cam8heightButton.SetActive(true);
        VertFOV8Button.SetActive(true);
    }


}

       