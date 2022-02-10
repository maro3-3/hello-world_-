using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class U_USA_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;
    void Awake()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");
    }

    // ���Ǝ�
    [SerializeField] private Text USA_NewYork_AreaLv;                             // �����k���n�惌�x��
    [SerializeField] private Text USA_StLouis_AreaLv;                            // ������C�n�惌�x��
    [SerializeField] private Text USA_Atlanta_AreaLv;                             // �����l��n�惌�x��

    [SerializeField] private Text USA_NewYork_EmploymentNum;                      // �����k���ٗp��
    [SerializeField] private Text USA_StLouis_EmploymentNum;                     // ������C�ٗp��
    [SerializeField] private Text USA_Atlanta_EmploymentNum;                      // �����l��ٗp��

    [SerializeField] private Text[] USA_NewYork_TotalUnemployedNum = new Text[2];   // �����k���o�^�Ґ�
    [SerializeField] private Text[] USA_StLouis_TotalUnemployedNum = new Text[2];  // ������C�o�^�Ґ�
    [SerializeField] private Text[] USA_Atlanta_TotalUnemployedNum = new Text[2];   // �����l��o�^�Ґ�

    [SerializeField] private Text USA_NewYork_Death_tollNum;                        // �����k�����S�Ґ�
    [SerializeField] private Text USA_StLouis_Death_tollNum;                       // �����k�����S�Ґ�
    [SerializeField] private Text USA_Atlanta_Death_tollNum;                        // �����k�����S�Ґ�

    //[SerializeField] private Text[] CHN_Beijing_name = new Text[2];                // �����k�����O
    //[SerializeField] private Text[] CHN_Beijing_LaborForce = new Text[2];          // �����k���J����
    //[SerializeField] private Text[] CHN_Beijing_Totalassets = new Text[2];         // �����k�������Y

    // Start is called before the first frame update
    void Start()
    {
        USA_NewYork_AreaLv.text = database.unemployed[3].UnemployedAreaNo.ToString();
        USA_NewYork_EmploymentNum.text = database.unemployed[3].EmploymentNum.ToString();
        USA_NewYork_TotalUnemployedNum[0].text = database.unemployed[3].InitUnemployedNum.ToString();
        USA_NewYork_TotalUnemployedNum[1].text = database.unemployed[3].CurrentUnemployedNum.ToString();
        USA_NewYork_Death_tollNum.text = database.unemployed[3].Death_tollNum.ToString();

        USA_StLouis_AreaLv.text = database.unemployed[4].UnemployedAreaNo.ToString();
        USA_StLouis_EmploymentNum.text = database.unemployed[4].EmploymentNum.ToString();
        USA_StLouis_TotalUnemployedNum[0].text = database.unemployed[4].InitUnemployedNum.ToString();
        USA_StLouis_TotalUnemployedNum[1].text = database.unemployed[4].CurrentUnemployedNum.ToString();
        USA_StLouis_Death_tollNum.text = database.unemployed[4].Death_tollNum.ToString();

        USA_Atlanta_AreaLv.text = database.unemployed[5].UnemployedAreaNo.ToString();
        USA_Atlanta_EmploymentNum.text = database.unemployed[5].EmploymentNum.ToString();
        USA_Atlanta_TotalUnemployedNum[0].text = database.unemployed[5].InitUnemployedNum.ToString();
        USA_Atlanta_TotalUnemployedNum[1].text = database.unemployed[5].CurrentUnemployedNum.ToString();
        USA_Atlanta_Death_tollNum.text = database.unemployed[5].Death_tollNum.ToString();

        //CHN_Beijing_name[0].text = database.manufacturers[0].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
        //CHN_Beijing_Totalassets[0].text = database.manufacturers[0].Totalassets.ToString();
        //CHN_Beijing_name[1].text = database.manufacturers[1].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[1].text = database.manufacturers[1].LaborForce.ToString();
        //CHN_Beijing_Totalassets[1].text = database.manufacturers[1].Totalassets.ToString();


    }
}
