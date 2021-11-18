using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoroneAction_ishikado : MonoBehaviour
{
    private int UnemployedNum;       // 登録した失業者数
    private int EmploymentNum;       // 雇用数

    private int ManufacturerCountryNo;  // 
    private int ManufacturerAreaNo;     // 
    private int ManufacturerNo;         // 
    private int ManufacturerName;       // 
    private int Products;               //

    private int ClientCountryNo;        //
    private int ClientAreaNo;           //
    private int ClientNo;               //
    private string ClientName;          //
    private int ClientLv;               //
    private int ClientType;             //
    private int Transactions;

    Unemployed unemployed = new Unemployed();

    Manufacturer manufacturer = new Manufacturer();

    Client client = new Client();

    void Start()
    {
        //セッター
        //unemployed.GetSetUnemployedNum = UnemployedNum;

        //ゲッター
        UnemployedNum = unemployed.GetSetUnemployedNum;

        //ゲッター
        ManufacturerCountryNo = manufacturer.GetSetManufacturerCountryNo;

        //ゲッター
        ClientCountryNo = client.GetSetClientCountryNo;

    }

    void Update()
    {

    }
}
