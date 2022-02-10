using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class M_RUS_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;

    // 生産者
    [SerializeField] private Text[] RUS_Moscow_ManuListPage = new Text[2];   // ロシア　モスクワ生産者名前
    [SerializeField] private Text[] RUS_Ufa_ManuListPage = new Text[4];      // ロシア　ウファ海生産者名前
                                                                              
    [SerializeField] private Text[] RUS_Moscow_ManuPageName = new Text[2];   // ロシア　モスクワ生産者名前
    [SerializeField] private Text[] RUS_Ufa_ManuPageName = new Text[4];      // ロシア　ウファ生産者名前

    [SerializeField] private Text[] RUS_Moscow_ManuTotalassets = new Text[2];      // ロシア　モスクワ総資産
    [SerializeField] private Text[] RUS_Moscow_ManuAmountofSales = new Text[2];    // ロシア　モスクワ売上高
    [SerializeField] private Text[] RUS_Moscow_ManuLaborForce = new Text[2];       // ロシア　モスクワ労働力
    [SerializeField] private Text[] RUS_Ufa_ManuTotalassets = new Text[4];     // ロシア　ウファ総資産
    [SerializeField] private Text[] RUS_Ufa_ManuAmountofSales = new Text[4];   // ロシア　ウファ売上高
    [SerializeField] private Text[] RUS_Ufa_ManuLaborForce = new Text[4];      // ロシア　ウファ労働力

    //[SerializeField] private Text[] CHN_Beijing_manuPage_ClientName = new Text[2];        // 中国北京クライアント名前
    //[SerializeField] private Text[] CHN_Beijing_Clientpage_RequNum = new Text[2];        // 中国北京要求数
    //[SerializeField] private Text[] CHN_Beijing_Clientpage_Pays = new Text[2];        // 中国北京要求数

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");

        // 生産者リストで表示する名前
        {
            RUS_Moscow_ManuListPage[0].text = database.manufacturers[18].ManufacturerName.ToString();
            RUS_Moscow_ManuListPage[1].text = database.manufacturers[19].ManufacturerName.ToString();
            RUS_Ufa_ManuListPage[0].text = database.manufacturers[20].ManufacturerName.ToString();
            RUS_Ufa_ManuListPage[1].text = database.manufacturers[21].ManufacturerName.ToString();
            RUS_Ufa_ManuListPage[2].text = database.manufacturers[22].ManufacturerName.ToString();
            RUS_Ufa_ManuListPage[3].text = database.manufacturers[23].ManufacturerName.ToString();
        }

        // 生産者ページで表示する名前
        {
            RUS_Moscow_ManuPageName[0].text = database.manufacturers[18].ManufacturerName.ToString();
            RUS_Moscow_ManuPageName[1].text = database.manufacturers[19].ManufacturerName.ToString();
            RUS_Ufa_ManuPageName[0].text = database.manufacturers[20].ManufacturerName.ToString();
            RUS_Ufa_ManuPageName[1].text = database.manufacturers[21].ManufacturerName.ToString();
            RUS_Ufa_ManuPageName[2].text = database.manufacturers[22].ManufacturerName.ToString();
            RUS_Ufa_ManuPageName[3].text = database.manufacturers[23].ManufacturerName.ToString();

        }

        // 総資産　売上　労働力
        {
            RUS_Moscow_ManuLaborForce[0].text = database.manufacturers[18].LaborForce.ToString();
            RUS_Moscow_ManuAmountofSales[0].text = database.manufacturers[18].AmountofSales.ToString();
            RUS_Moscow_ManuTotalassets[0].text = database.manufacturers[18].Totalassets.ToString();
            RUS_Moscow_ManuLaborForce[1].text = database.manufacturers[19].LaborForce.ToString();
            RUS_Moscow_ManuAmountofSales[1].text = database.manufacturers[19].AmountofSales.ToString();
            RUS_Moscow_ManuTotalassets[1].text = database.manufacturers[19].Totalassets.ToString();

            RUS_Ufa_ManuLaborForce[0].text = database.manufacturers[20].LaborForce.ToString();
            RUS_Ufa_ManuAmountofSales[0].text = database.manufacturers[20].AmountofSales.ToString();
            RUS_Ufa_ManuTotalassets[0].text = database.manufacturers[20].Totalassets.ToString();
            RUS_Ufa_ManuLaborForce[1].text = database.manufacturers[21].LaborForce.ToString();
            RUS_Ufa_ManuAmountofSales[1].text = database.manufacturers[21].AmountofSales.ToString();
            RUS_Ufa_ManuTotalassets[1].text = database.manufacturers[21].Totalassets.ToString();
            RUS_Ufa_ManuLaborForce[2].text = database.manufacturers[22].LaborForce.ToString();
            RUS_Ufa_ManuAmountofSales[2].text = database.manufacturers[22].AmountofSales.ToString();
            RUS_Ufa_ManuTotalassets[2].text = database.manufacturers[22].Totalassets.ToString();
            RUS_Ufa_ManuLaborForce[3].text = database.manufacturers[23].LaborForce.ToString();
            RUS_Ufa_ManuAmountofSales[3].text = database.manufacturers[23].AmountofSales.ToString();
            RUS_Ufa_ManuTotalassets[3].text = database.manufacturers[23].Totalassets.ToString();

        }

    }
}