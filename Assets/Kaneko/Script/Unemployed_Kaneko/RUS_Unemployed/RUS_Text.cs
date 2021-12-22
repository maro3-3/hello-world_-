using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RUS_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;
    void Awake()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");
    }

    // ���Ǝ�
    [SerializeField] private Text RUS_Moscow_AreaLv;                             // �����k���n�惌�x��
    [SerializeField] private Text RUS_Ufa_AreaLv;                            // ������C�n�惌�x��

    [SerializeField] private Text RUS_Moscow_EmploymentNum;                      // �����k���ٗp��
    [SerializeField] private Text RUS_Ufa_EmploymentNum;                     // ������C�ٗp��

    [SerializeField] private Text[] RUS_Moscow_TotalUnemployedNum = new Text[2];   // �����k���o�^�Ґ�
    [SerializeField] private Text[] RUS_Ufa_TotalUnemployedNum = new Text[2];  // ������C�o�^�Ґ�

    [SerializeField] private Text RUS_Moscow_Death_tollNum;                        // �����k�����S�Ґ�
    [SerializeField] private Text RUS_Ufa_Death_tollNum;                       // �����k�����S�Ґ�

    //[SerializeField] private Text[] CHN_Beijing_name = new Text[2];                // �����k�����O
    //[SerializeField] private Text[] CHN_Beijing_LaborForce = new Text[2];          // �����k���J����
    //[SerializeField] private Text[] CHN_Beijing_Totalassets = new Text[2];         // �����k�������Y

    // Start is called before the first frame update
    void Start()
    {
        RUS_Moscow_AreaLv.text = database.unemployed[6].UnemployedAreaNo.ToString();
        RUS_Moscow_EmploymentNum.text = database.unemployed[6].EmploymentNum.ToString();
        RUS_Moscow_TotalUnemployedNum[0].text = database.unemployed[6].InitUnemployedNum.ToString();
        RUS_Moscow_TotalUnemployedNum[1].text = database.unemployed[6].CurrentUnemployedNum.ToString();
        RUS_Moscow_Death_tollNum.text = database.unemployed[6].Death_tollNum.ToString();

        RUS_Ufa_AreaLv.text = database.unemployed[7].UnemployedAreaNo.ToString();
        RUS_Ufa_EmploymentNum.text = database.unemployed[7].EmploymentNum.ToString();
        RUS_Ufa_TotalUnemployedNum[0].text = database.unemployed[7].InitUnemployedNum.ToString();
        RUS_Ufa_TotalUnemployedNum[1].text = database.unemployed[7].CurrentUnemployedNum.ToString();
        RUS_Ufa_Death_tollNum.text = database.unemployed[7].Death_tollNum.ToString();

        //CHN_Beijing_name[0].text = database.manufacturers[0].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
        //CHN_Beijing_Totalassets[0].text = database.manufacturers[0].Totalassets.ToString();
        //CHN_Beijing_name[1].text = database.manufacturers[1].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[1].text = database.manufacturers[1].LaborForce.ToString();
        //CHN_Beijing_Totalassets[1].text = database.manufacturers[1].Totalassets.ToString();


    }


    // Update is called once per frame
    void Update()
    {

    }
}
