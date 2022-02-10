using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class U_ZAF_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;
    void Awake()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");
    }

    // ���Ǝ�
    [SerializeField] private Text ZAF_Pretoria_AreaLv;                             // �����k���n�惌�x��
    [SerializeField] private Text ZAF_Bloemfontein_AreaLv;                            // ������C�n�惌�x��
    [SerializeField] private Text ZAF_CapeTown_AreaLv;                             // �����l��n�惌�x��

    [SerializeField] private Text ZAF_Pretoria_EmploymentNum;                      // �����k���ٗp��
    [SerializeField] private Text ZAF_Bloemfontein_EmploymentNum;                     // ������C�ٗp��
    [SerializeField] private Text ZAF_CapeTown_EmploymentNum;                      // �����l��ٗp��

    [SerializeField] private Text[] ZAF_Pretoria_TotalUnemployedNum = new Text[2];   // �����k���o�^�Ґ�
    [SerializeField] private Text[] ZAF_Bloemfontein_TotalUnemployedNum = new Text[2];  // ������C�o�^�Ґ�
    [SerializeField] private Text[] ZAF_CapeTown_TotalUnemployedNum = new Text[2];   // �����l��o�^�Ґ�

    [SerializeField] private Text ZAF_Pretoria_Death_tollNum;                        // �����k�����S�Ґ�
    [SerializeField] private Text ZAF_Bloemfontein_Death_tollNum;                       // �����k�����S�Ґ�
    [SerializeField] private Text ZAF_CapeTown_Death_tollNum;                        // �����k�����S�Ґ�

    //[SerializeField] private Text[] CHN_Beijing_name = new Text[2];                // �����k�����O
    //[SerializeField] private Text[] CHN_Beijing_LaborForce = new Text[2];          // �����k���J����
    //[SerializeField] private Text[] CHN_Beijing_Totalassets = new Text[2];         // �����k�������Y

    // Start is called before the first frame update
    void Start()
    {
        ZAF_Pretoria_AreaLv.text = database.unemployed[11].UnemployedAreaNo.ToString();
        ZAF_Pretoria_EmploymentNum.text = database.unemployed[11].EmploymentNum.ToString();
        ZAF_Pretoria_TotalUnemployedNum[0].text = database.unemployed[11].InitUnemployedNum.ToString();
        ZAF_Pretoria_TotalUnemployedNum[1].text = database.unemployed[11].CurrentUnemployedNum.ToString();
        ZAF_Pretoria_Death_tollNum.text = database.unemployed[11].Death_tollNum.ToString();

        ZAF_Bloemfontein_AreaLv.text = database.unemployed[12].UnemployedAreaNo.ToString();
        ZAF_Bloemfontein_EmploymentNum.text = database.unemployed[12].EmploymentNum.ToString();
        ZAF_Bloemfontein_TotalUnemployedNum[0].text = database.unemployed[12].InitUnemployedNum.ToString();
        ZAF_Bloemfontein_TotalUnemployedNum[1].text = database.unemployed[12].CurrentUnemployedNum.ToString();
        ZAF_Bloemfontein_Death_tollNum.text = database.unemployed[12].Death_tollNum.ToString();

        ZAF_CapeTown_AreaLv.text = database.unemployed[13].UnemployedAreaNo.ToString();
        ZAF_CapeTown_EmploymentNum.text = database.unemployed[13].EmploymentNum.ToString();
        ZAF_CapeTown_TotalUnemployedNum[0].text = database.unemployed[13].InitUnemployedNum.ToString();
        ZAF_CapeTown_TotalUnemployedNum[1].text = database.unemployed[13].CurrentUnemployedNum.ToString();
        ZAF_CapeTown_Death_tollNum.text = database.unemployed[13].Death_tollNum.ToString();

        //CHN_Beijing_name[0].text = database.manufacturers[0].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
        //CHN_Beijing_Totalassets[0].text = database.manufacturers[0].Totalassets.ToString();
        //CHN_Beijing_name[1].text = database.manufacturers[1].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[1].text = database.manufacturers[1].LaborForce.ToString();
        //CHN_Beijing_Totalassets[1].text = database.manufacturers[1].Totalassets.ToString();


    }
}
