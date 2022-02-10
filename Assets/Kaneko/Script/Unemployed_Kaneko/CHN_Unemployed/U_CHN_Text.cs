using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class U_CHN_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;
    void Awake()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");
    }

    // ���Ǝ�
    [SerializeField] private Text CHN_Beijing_AreaLv;                             // �����k���n�惌�x��
    [SerializeField] private Text CHN_Shanghai_AreaLv;                            // ������C�n�惌�x��
    [SerializeField] private Text CHN_Sichuan_AreaLv;                             // �����l��n�惌�x��

    [SerializeField] private Text CHN_Beijing_EmploymentNum;                      // �����k���ٗp��
    [SerializeField] private Text CHN_Shanghai_EmploymentNum;                     // ������C�ٗp��
    [SerializeField] private Text CHN_Sichuan_EmploymentNum;                      // �����l��ٗp��

    [SerializeField] private Text[] CHN_Beijing_TotalUnemployedNum = new Text[2];   // �����k���o�^�Ґ�
    [SerializeField] private Text[] CHN_Shanghai_TotalUnemployedNum = new Text[2];  // ������C�o�^�Ґ�
    [SerializeField] private Text[] CHN_Sichuan_TotalUnemployedNum = new Text[2];   // �����l��o�^�Ґ�

    [SerializeField] private Text CHN_Beijing_Death_tollNum;                        // �����k�����S�Ґ�
    [SerializeField] private Text CHN_Shanghai_Death_tollNum;                       // �����k�����S�Ґ�
    [SerializeField] private Text CHN_Sichuan_Death_tollNum;                        // �����k�����S�Ґ�

    //[SerializeField] private Text[] CHN_Beijing_name = new Text[2];                // �����k�����O
    //[SerializeField] private Text[] CHN_Beijing_LaborForce = new Text[2];          // �����k���J����
    //[SerializeField] private Text[] CHN_Beijing_Totalassets = new Text[2];         // �����k�������Y

    // Start is called before the first frame update
    void Start()
    {
        CHN_Beijing_AreaLv.text = database.unemployed[0].UnemployedAreaNo.ToString();
        CHN_Beijing_EmploymentNum.text = database.unemployed[0].EmploymentNum.ToString();
        CHN_Beijing_TotalUnemployedNum[0].text = database.unemployed[0].InitUnemployedNum.ToString();
        CHN_Beijing_TotalUnemployedNum[1].text = database.unemployed[0].CurrentUnemployedNum.ToString();
        CHN_Beijing_Death_tollNum.text = database.unemployed[0].Death_tollNum.ToString();

        CHN_Shanghai_AreaLv.text = database.unemployed[1].UnemployedAreaNo.ToString();
        CHN_Shanghai_EmploymentNum.text = database.unemployed[1].EmploymentNum.ToString();
        CHN_Shanghai_TotalUnemployedNum[0].text = database.unemployed[1].InitUnemployedNum.ToString();
        CHN_Shanghai_TotalUnemployedNum[1].text = database.unemployed[1].CurrentUnemployedNum.ToString();
        CHN_Shanghai_Death_tollNum.text = database.unemployed[1].Death_tollNum.ToString();

        CHN_Sichuan_AreaLv.text = database.unemployed[2].UnemployedAreaNo.ToString();
        CHN_Sichuan_EmploymentNum.text = database.unemployed[2].EmploymentNum.ToString();
        CHN_Sichuan_TotalUnemployedNum[0].text = database.unemployed[2].InitUnemployedNum.ToString();
        CHN_Sichuan_TotalUnemployedNum[1].text = database.unemployed[2].CurrentUnemployedNum.ToString();
        CHN_Sichuan_Death_tollNum.text = database.unemployed[2].Death_tollNum.ToString();

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
