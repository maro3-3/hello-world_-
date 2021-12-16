using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Datatext_kaneko : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;

    [SerializeField] private Text UnemployedNumT;
    [SerializeField] private Text EmploymentNumT;
    [SerializeField] private Text PossessionDroneNumT;
    [SerializeField] private Text TempingDroneNumT;
    [SerializeField] private Text TurnNumT;// ターン

    // 失業者
    [SerializeField] private Text   CHN_Beijing_AreaLv;                            // 中国北京地域レベル
    [SerializeField] private Text   CHN_Beijing_EmploymentNum;                     // 中国北京雇用数
    [SerializeField] private Text[] CHN_Beijing_TotalUnemployedNum = new Text[2];  // 中国北京登録者数
    [SerializeField] private Text   CHN_Beijing_Death_tollNum;                     // 中国北京死亡者数
    [SerializeField] private Text[] CHN_Beijing_name = new Text[2];                // 中国北京名前
    [SerializeField] private Text[] CHN_Beijing_LaborForce = new Text[2];          // 中国北京労働力
    [SerializeField] private Text[] CHN_Beijing_Totalassets = new Text[2];         // 中国北京総資産

    // 生産者
    [SerializeField] private Text[] CHN_Beijing_manuNameList  = new Text[2];   // 中国北京生産者名前
    [SerializeField] private Text[] CHN_Shanghai_manuNameList = new Text[2];   // 中国上海生産者名前
    [SerializeField] private Text[] CHN_Sichuan_manuNameList  = new Text[5];   // 中国四川生産者名前

    [SerializeField] private Text[] CHN_Beijing_manufacturerName  = new Text[2];        // 中国北京生産者名前
    [SerializeField] private Text[] CHN_Beijing_manuLaborForce    = new Text[2];          // 中国北京労働力
    [SerializeField] private Text[] CHN_Beijing_manuAmountofSales = new Text[2];       // 中国北京労働力
    [SerializeField] private Text[] CHN_Beijing_manuTotalassets   = new Text[2];         // 中国北京総資産

    [SerializeField] private Text[] CHN_Beijing_manuPage_ClientName = new Text[2];        // 中国北京クライアント名前
    [SerializeField] private Text[] CHN_Beijing_Clientpage_RequNum = new Text[2];        // 中国北京要求数
    [SerializeField] private Text[] CHN_Beijing_Clientpage_Pays = new Text[2];        // 中国北京要求数

    // クライアント
    [SerializeField] private Text[] CHN_Beijing_ClientNameList = new Text[2];   // 中国北京生産者名前
    [SerializeField] private Text[] CHN_Beijing_ClientName = new Text[2];   // 中国北京生産者名前
    [SerializeField] private Text[] CHN_Beijing_ClientLv = new Text[2];   // 中国北京生産者名前

    //[SerializeField] private Text[] CHN_Shanghai_ClientNameList = new Text[2];   // 中国上海生産者名前
    //[SerializeField] private Text[] CHN_Sichuan_ClientNameList = new Text[5];   // 中国四川生産者名前

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");

        UnemployedNumT.text = database.UnemployedNum.ToString();
        EmploymentNumT.text = database.EmploymentNum.ToString();
        PossessionDroneNumT.text = database.PossessionDroneNum.ToString();
        TempingDroneNumT.text = database.TempingDroneNum.ToString();
        TurnNumT.text = database.TurnNum.ToString();

        CHN_Beijing_AreaLv.text = database.unemployed[0].UnemployedAreaNo.ToString();
        CHN_Beijing_EmploymentNum.text = database.unemployed[0].EmploymentNum.ToString();
        CHN_Beijing_TotalUnemployedNum[0].text = database.unemployed[0].InitUnemployedNum.ToString();
        CHN_Beijing_TotalUnemployedNum[1].text = database.unemployed[0].CurrentUnemployedNum.ToString();
        CHN_Beijing_Death_tollNum.text = database.unemployed[0].Death_tollNum.ToString();
        CHN_Beijing_name[0].text = database.manufacturers[0].ManufacturerName.ToString();
        CHN_Beijing_LaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
        CHN_Beijing_Totalassets[0].text = database.manufacturers[0].Totalassets.ToString();
        CHN_Beijing_name[1].text = database.manufacturers[1].ManufacturerName.ToString();
        CHN_Beijing_LaborForce[1].text = database.manufacturers[1].LaborForce.ToString();
        CHN_Beijing_Totalassets[1].text = database.manufacturers[1].Totalassets.ToString();

        CHN_Beijing_manuNameList[0].text = database.manufacturers[0].ManufacturerName.ToString();
        CHN_Beijing_manuNameList[1].text = database.manufacturers[1].ManufacturerName.ToString();
        //CHN_Shanghai_manuNameList[0].text = database.manufacturers[2].ManufacturerName.ToString();
        //CHN_Shanghai_manuNameList[1].text = database.manufacturers[3].ManufacturerName.ToString();
        //CHN_Sichuan_manuNameList[0].text = database.manufacturers[4].ManufacturerName.ToString();
        //CHN_Sichuan_manuNameList[1].text = database.manufacturers[5].ManufacturerName.ToString();
        //CHN_Sichuan_manuNameList[2].text = database.manufacturers[6].ManufacturerName.ToString();
        //CHN_Sichuan_manuNameList[3].text = database.manufacturers[7].ManufacturerName.ToString();
        //CHN_Sichuan_manuNameList[4].text = database.manufacturers[8].ManufacturerName.ToString();

        CHN_Beijing_manufacturerName[0].text = database.manufacturers[0].ManufacturerName.ToString();
        CHN_Beijing_manuLaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
        CHN_Beijing_manuAmountofSales[0].text = database.manufacturers[0].AmountofSales.ToString();
        CHN_Beijing_manuTotalassets[0].text = database.manufacturers[0].Totalassets.ToString();

        CHN_Beijing_manuPage_ClientName[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientName[0].ToString();
        CHN_Beijing_manuPage_ClientName[1].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientName[1].ToString();

        CHN_Beijing_ClientNameList[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientName[0].ToString();
        CHN_Beijing_ClientNameList[1].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientName[1].ToString();

        CHN_Beijing_Clientpage_RequNum[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_RN1[0].ToString();
        CHN_Beijing_Clientpage_Pays[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_AmoPayM1[0].ToString();

        CHN_Beijing_ClientName[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientName[0].ToString();
        CHN_Beijing_ClientLv[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientLv[0].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }
}
