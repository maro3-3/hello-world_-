using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class M_AUS_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;

    // 生産者
    [SerializeField] private Text[] AUS_Canberra_ManuListPage = new Text[4];   // オーストラリア　キャンベラ生産者名前
    [SerializeField] private Text[] AUS_Perth_ManuListPage = new Text[3];      // オーストラリア　パース生産者名前
    [SerializeField] private Text[] AUS_Melbourne_ManuListPage = new Text[3];  // オーストラリア　メルボルン生産者名前

    [SerializeField] private Text[] AUS_Canberra_ManuPageName = new Text[4];   // オーストラリア　キャンベラ生産者名前
    [SerializeField] private Text[] AUS_Perth_ManuPageName = new Text[3];      // オーストラリア　パース生産者名前
    [SerializeField] private Text[] AUS_Melbourne_ManuPageName = new Text[3];  // オーストラリア　メルボルン生産者名前

    [SerializeField] private Text[] AUS_Canberra_ManuTotalassets = new Text[4];      // オーストラリア　キャンベラ総資産
    [SerializeField] private Text[] AUS_Canberra_ManuAmountofSales = new Text[4];    // オーストラリア　キャンベラ売上高
    [SerializeField] private Text[] AUS_Canberra_ManuLaborForce = new Text[4];       // オーストラリア　キャンベラ労働力
    [SerializeField] private Text[] AUS_Perth_ManuTotalassets = new Text[3];     // オーストラリア　パース総資産
    [SerializeField] private Text[] AUS_Perth_ManuAmountofSales = new Text[3];   // オーストラリア　パース売上高
    [SerializeField] private Text[] AUS_Perth_ManuLaborForce = new Text[3];      // オーストラリア　パース労働力
    [SerializeField] private Text[] AUS_Melbourne_ManuTotalassets = new Text[3];      // オーストラリア　メルボルン総資産
    [SerializeField] private Text[] AUS_Melbourne_ManuAmountofSales = new Text[3];    // オーストラリア　メルボルン売上高
    [SerializeField] private Text[] AUS_Melbourne_ManuLaborForce = new Text[3];       // オーストラリア　メルボルン労働力

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
            AUS_Canberra_ManuListPage[0].text = database.manufacturers[24].ManufacturerName.ToString();
            AUS_Canberra_ManuListPage[1].text = database.manufacturers[25].ManufacturerName.ToString();
            AUS_Canberra_ManuListPage[2].text = database.manufacturers[26].ManufacturerName.ToString();
            AUS_Canberra_ManuListPage[3].text = database.manufacturers[27].ManufacturerName.ToString();
            AUS_Perth_ManuListPage[0].text = database.manufacturers[28].ManufacturerName.ToString();
            AUS_Perth_ManuListPage[1].text = database.manufacturers[29].ManufacturerName.ToString();
            AUS_Perth_ManuListPage[2].text = database.manufacturers[30].ManufacturerName.ToString();
            AUS_Melbourne_ManuListPage[0].text = database.manufacturers[31].ManufacturerName.ToString();
            AUS_Melbourne_ManuListPage[1].text = database.manufacturers[32].ManufacturerName.ToString();
            AUS_Melbourne_ManuListPage[2].text = database.manufacturers[33].ManufacturerName.ToString();
        }

        // 生産者ページで表示する名前
        {
            AUS_Canberra_ManuPageName[0].text = database.manufacturers[24].ManufacturerName.ToString();
            AUS_Canberra_ManuPageName[1].text = database.manufacturers[25].ManufacturerName.ToString();
            AUS_Canberra_ManuPageName[2].text = database.manufacturers[26].ManufacturerName.ToString();
            AUS_Canberra_ManuPageName[3].text = database.manufacturers[27].ManufacturerName.ToString();
            AUS_Perth_ManuPageName[0].text = database.manufacturers[28].ManufacturerName.ToString();
            AUS_Perth_ManuPageName[1].text = database.manufacturers[29].ManufacturerName.ToString();
            AUS_Perth_ManuPageName[2].text = database.manufacturers[30].ManufacturerName.ToString();
            AUS_Melbourne_ManuPageName[0].text = database.manufacturers[31].ManufacturerName.ToString();
            AUS_Melbourne_ManuPageName[1].text = database.manufacturers[32].ManufacturerName.ToString();
            AUS_Melbourne_ManuPageName[2].text = database.manufacturers[33].ManufacturerName.ToString();
        }

        // 総資産　売上　労働力
        {
            AUS_Canberra_ManuLaborForce[0].text = database.manufacturers[24].LaborForce.ToString();
            AUS_Canberra_ManuAmountofSales[0].text = database.manufacturers[24].AmountofSales.ToString();
            AUS_Canberra_ManuTotalassets[0].text = database.manufacturers[24].Totalassets.ToString();
            AUS_Canberra_ManuLaborForce[1].text = database.manufacturers[25].LaborForce.ToString();
            AUS_Canberra_ManuAmountofSales[1].text = database.manufacturers[25].AmountofSales.ToString();
            AUS_Canberra_ManuTotalassets[1].text = database.manufacturers[25].Totalassets.ToString();
            AUS_Canberra_ManuLaborForce[2].text = database.manufacturers[26].LaborForce.ToString();
            AUS_Canberra_ManuAmountofSales[2].text = database.manufacturers[26].AmountofSales.ToString();
            AUS_Canberra_ManuTotalassets[2].text = database.manufacturers[26].Totalassets.ToString();
            AUS_Canberra_ManuLaborForce[3].text = database.manufacturers[27].LaborForce.ToString();
            AUS_Canberra_ManuAmountofSales[3].text = database.manufacturers[27].AmountofSales.ToString();
            AUS_Canberra_ManuTotalassets[3].text = database.manufacturers[27].Totalassets.ToString();

            AUS_Perth_ManuLaborForce[0].text = database.manufacturers[28].LaborForce.ToString();
            AUS_Perth_ManuAmountofSales[0].text = database.manufacturers[28].AmountofSales.ToString();
            AUS_Perth_ManuTotalassets[0].text = database.manufacturers[28].Totalassets.ToString();
            AUS_Perth_ManuLaborForce[1].text = database.manufacturers[29].LaborForce.ToString();
            AUS_Perth_ManuAmountofSales[1].text = database.manufacturers[29].AmountofSales.ToString();
            AUS_Perth_ManuTotalassets[1].text = database.manufacturers[29].Totalassets.ToString();
            AUS_Perth_ManuLaborForce[2].text = database.manufacturers[30].LaborForce.ToString();
            AUS_Perth_ManuAmountofSales[2].text = database.manufacturers[30].AmountofSales.ToString();
            AUS_Perth_ManuTotalassets[2].text = database.manufacturers[30].Totalassets.ToString();

            AUS_Melbourne_ManuLaborForce[0].text = database.manufacturers[31].LaborForce.ToString();
            AUS_Melbourne_ManuAmountofSales[0].text = database.manufacturers[31].AmountofSales.ToString();
            AUS_Melbourne_ManuTotalassets[0].text = database.manufacturers[31].Totalassets.ToString();
            AUS_Melbourne_ManuLaborForce[1].text = database.manufacturers[32].LaborForce.ToString();
            AUS_Melbourne_ManuAmountofSales[1].text = database.manufacturers[32].AmountofSales.ToString();
            AUS_Melbourne_ManuTotalassets[1].text = database.manufacturers[32].Totalassets.ToString();
            AUS_Melbourne_ManuLaborForce[2].text = database.manufacturers[33].LaborForce.ToString();
            AUS_Melbourne_ManuAmountofSales[2].text = database.manufacturers[33].AmountofSales.ToString();
            AUS_Melbourne_ManuTotalassets[2].text = database.manufacturers[33].Totalassets.ToString();
        }

    }
}