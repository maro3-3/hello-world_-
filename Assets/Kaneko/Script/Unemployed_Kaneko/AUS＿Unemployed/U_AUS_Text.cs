using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class U_AUS_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;
    void Awake()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");
    }

    // ���Ǝ�
    [SerializeField] private Text AUS_Canberra_AreaLv;                             // �����k���n�惌�x��
    [SerializeField] private Text AUS_Perth_AreaLv;                            // ������C�n�惌�x��
    [SerializeField] private Text AUS_Melbourne_AreaLv;                             // �����l��n�惌�x��

    [SerializeField] private Text AUS_Canberra_EmploymentNum;                      // �����k���ٗp��
    [SerializeField] private Text AUS_Perth_EmploymentNum;                     // ������C�ٗp��
    [SerializeField] private Text AUS_Melbourne_EmploymentNum;                      // �����l��ٗp��

    [SerializeField] private Text[] AUS_Canberra_TotalUnemployedNum = new Text[2];   // �����k���o�^�Ґ�
    [SerializeField] private Text[] AUS_Perth_TotalUnemployedNum = new Text[2];  // ������C�o�^�Ґ�
    [SerializeField] private Text[] AUS_Melbourne_TotalUnemployedNum = new Text[2];   // �����l��o�^�Ґ�

    [SerializeField] private Text AUS_Canberra_Death_tollNum;                        // �����k�����S�Ґ�
    [SerializeField] private Text AUS_Perth_Death_tollNum;                       // �����k�����S�Ґ�
    [SerializeField] private Text AUS_Melbourne_Death_tollNum;                        // �����k�����S�Ґ�

    //[SerializeField] private Text[] CHN_Beijing_name = new Text[2];                // �����k�����O
    //[SerializeField] private Text[] CHN_Beijing_LaborForce = new Text[2];          // �����k���J����
    //[SerializeField] private Text[] CHN_Beijing_Totalassets = new Text[2];         // �����k�������Y

    // Start is called before the first frame update
    void Start()
    {
        AUS_Canberra_AreaLv.text = database.unemployed[8].UnemployedAreaNo.ToString();
        AUS_Canberra_EmploymentNum.text = database.unemployed[8].EmploymentNum.ToString();
        AUS_Canberra_TotalUnemployedNum[0].text = database.unemployed[8].InitUnemployedNum.ToString();
        AUS_Canberra_TotalUnemployedNum[1].text = database.unemployed[8].CurrentUnemployedNum.ToString();
        AUS_Canberra_Death_tollNum.text = database.unemployed[8].Death_tollNum.ToString();

        AUS_Perth_AreaLv.text = database.unemployed[9].UnemployedAreaNo.ToString();
        AUS_Perth_EmploymentNum.text = database.unemployed[9].EmploymentNum.ToString();
        AUS_Perth_TotalUnemployedNum[0].text = database.unemployed[9].InitUnemployedNum.ToString();
        AUS_Perth_TotalUnemployedNum[1].text = database.unemployed[9].CurrentUnemployedNum.ToString();
        AUS_Perth_Death_tollNum.text = database.unemployed[9].Death_tollNum.ToString();

        AUS_Melbourne_AreaLv.text = database.unemployed[10].UnemployedAreaNo.ToString();
        AUS_Melbourne_EmploymentNum.text = database.unemployed[10].EmploymentNum.ToString();
        AUS_Melbourne_TotalUnemployedNum[0].text = database.unemployed[10].InitUnemployedNum.ToString();
        AUS_Melbourne_TotalUnemployedNum[1].text = database.unemployed[10].CurrentUnemployedNum.ToString();
        AUS_Melbourne_Death_tollNum.text = database.unemployed[10].Death_tollNum.ToString();

        //CHN_Beijing_name[0].text = database.manufacturers[0].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
        //CHN_Beijing_Totalassets[0].text = database.manufacturers[0].Totalassets.ToString();
        //CHN_Beijing_name[1].text = database.manufacturers[1].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[1].text = database.manufacturers[1].LaborForce.ToString();
        //CHN_Beijing_Totalassets[1].text = database.manufacturers[1].Totalassets.ToString();


    }
}
