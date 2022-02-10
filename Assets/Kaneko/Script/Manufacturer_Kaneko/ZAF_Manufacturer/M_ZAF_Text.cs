using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_ZAF_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;

    // 生産者
    [SerializeField] private Text[] ZAF_Pretoria_ManuListPage = new Text[3];   // オーストラリア　キャンベラ生産者名前
    [SerializeField] private Text[] ZAF_Bloemfontein_ManuListPage = new Text[4];      // オーストラリア　パース生産者名前
    [SerializeField] private Text[] ZAF_CapeTown_ManuListPage = new Text[5];  // オーストラリア　メルボルン生産者名前

    [SerializeField] private Text[] ZAF_Pretoria_ManuPageName = new Text[3];   // オーストラリア　キャンベラ生産者名前
    [SerializeField] private Text[] ZAF_Bloemfontein_ManuPageName = new Text[4];      // オーストラリア　パース生産者名前
    [SerializeField] private Text[] ZAF_CapeTown_ManuPageName = new Text[5];  // オーストラリア　メルボルン生産者名前

    [SerializeField] private Text[] ZAF_Pretoria_ManuTotalassets = new Text[3];      // オーストラリア　キャンベラ総資産
    [SerializeField] private Text[] ZAF_Pretoria_ManuAmountofSales = new Text[3];    // オーストラリア　キャンベラ売上高
    [SerializeField] private Text[] ZAF_Pretoria_ManuLaborForce = new Text[3];       // オーストラリア　キャンベラ労働力
    [SerializeField] private Text[] ZAF_Bloemfontein_ManuTotalassets = new Text[4];     // オーストラリア　パース総資産
    [SerializeField] private Text[] ZAF_Bloemfontein_ManuAmountofSales = new Text[4];   // オーストラリア　パース売上高
    [SerializeField] private Text[] ZAF_Bloemfontein_ManuLaborForce = new Text[4];      // オーストラリア　パース労働力
    [SerializeField] private Text[] ZAF_CapeTown_ManuTotalassets = new Text[5];      // オーストラリア　メルボルン総資産
    [SerializeField] private Text[] ZAF_CapeTown_ManuAmountofSales = new Text[5];    // オーストラリア　メルボルン売上高
    [SerializeField] private Text[] ZAF_CapeTown_ManuLaborForce = new Text[5];       // オーストラリア　メルボルン労働力

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");
        // 生産者リストで表示する名前
        {
            ZAF_Pretoria_ManuListPage[0].text = database.manufacturers[34].ManufacturerName.ToString();
            ZAF_Pretoria_ManuListPage[1].text = database.manufacturers[35].ManufacturerName.ToString();
            ZAF_Pretoria_ManuListPage[2].text = database.manufacturers[36].ManufacturerName.ToString();
            ZAF_Bloemfontein_ManuListPage[0].text = database.manufacturers[37].ManufacturerName.ToString();
            ZAF_Bloemfontein_ManuListPage[1].text = database.manufacturers[38].ManufacturerName.ToString();
            ZAF_Bloemfontein_ManuListPage[2].text = database.manufacturers[39].ManufacturerName.ToString();
            ZAF_Bloemfontein_ManuListPage[3].text = database.manufacturers[40].ManufacturerName.ToString();
            ZAF_CapeTown_ManuListPage[0].text = database.manufacturers[41].ManufacturerName.ToString();
            ZAF_CapeTown_ManuListPage[1].text = database.manufacturers[42].ManufacturerName.ToString();
            ZAF_CapeTown_ManuListPage[2].text = database.manufacturers[43].ManufacturerName.ToString();
            ZAF_CapeTown_ManuListPage[3].text = database.manufacturers[44].ManufacturerName.ToString();
            ZAF_CapeTown_ManuListPage[4].text = database.manufacturers[45].ManufacturerName.ToString();
        }

        // 生産者ページで表示する名前
        {
            ZAF_Pretoria_ManuPageName[0].text = database.manufacturers[34].ManufacturerName.ToString();
            ZAF_Pretoria_ManuPageName[1].text = database.manufacturers[35].ManufacturerName.ToString();
            ZAF_Pretoria_ManuPageName[2].text = database.manufacturers[36].ManufacturerName.ToString();
            ZAF_Bloemfontein_ManuPageName[0].text = database.manufacturers[37].ManufacturerName.ToString();
            ZAF_Bloemfontein_ManuPageName[1].text = database.manufacturers[38].ManufacturerName.ToString();
            ZAF_Bloemfontein_ManuPageName[2].text = database.manufacturers[39].ManufacturerName.ToString();
            ZAF_Bloemfontein_ManuPageName[3].text = database.manufacturers[40].ManufacturerName.ToString();
            ZAF_CapeTown_ManuPageName[0].text = database.manufacturers[41].ManufacturerName.ToString();
            ZAF_CapeTown_ManuPageName[1].text = database.manufacturers[42].ManufacturerName.ToString();
            ZAF_CapeTown_ManuPageName[2].text = database.manufacturers[43].ManufacturerName.ToString();
            ZAF_CapeTown_ManuPageName[3].text = database.manufacturers[44].ManufacturerName.ToString();
            ZAF_CapeTown_ManuPageName[4].text = database.manufacturers[45].ManufacturerName.ToString();
        }

        // 総資産　売上　労働力
        {
            ZAF_Pretoria_ManuLaborForce[0].text = database.manufacturers[34].LaborForce.ToString();
            ZAF_Pretoria_ManuAmountofSales[0].text = database.manufacturers[34].AmountofSales.ToString();
            ZAF_Pretoria_ManuTotalassets[0].text = database.manufacturers[34].Totalassets.ToString();
            ZAF_Pretoria_ManuLaborForce[1].text = database.manufacturers[35].LaborForce.ToString();
            ZAF_Pretoria_ManuAmountofSales[1].text = database.manufacturers[35].AmountofSales.ToString();
            ZAF_Pretoria_ManuTotalassets[1].text = database.manufacturers[35].Totalassets.ToString();
            ZAF_Pretoria_ManuLaborForce[2].text = database.manufacturers[36].LaborForce.ToString();
            ZAF_Pretoria_ManuAmountofSales[2].text = database.manufacturers[36].AmountofSales.ToString();
            ZAF_Pretoria_ManuTotalassets[2].text = database.manufacturers[36].Totalassets.ToString();

            ZAF_Bloemfontein_ManuLaborForce[0].text = database.manufacturers[37].LaborForce.ToString();
            ZAF_Bloemfontein_ManuAmountofSales[0].text = database.manufacturers[37].AmountofSales.ToString();
            ZAF_Bloemfontein_ManuTotalassets[0].text = database.manufacturers[37].Totalassets.ToString();
            ZAF_Bloemfontein_ManuLaborForce[1].text = database.manufacturers[38].LaborForce.ToString();
            ZAF_Bloemfontein_ManuAmountofSales[1].text = database.manufacturers[38].AmountofSales.ToString();
            ZAF_Bloemfontein_ManuTotalassets[1].text = database.manufacturers[38].Totalassets.ToString();
            ZAF_Bloemfontein_ManuLaborForce[2].text = database.manufacturers[39].LaborForce.ToString();
            ZAF_Bloemfontein_ManuAmountofSales[2].text = database.manufacturers[39].AmountofSales.ToString();
            ZAF_Bloemfontein_ManuTotalassets[2].text = database.manufacturers[39].Totalassets.ToString();
            ZAF_Bloemfontein_ManuLaborForce[3].text = database.manufacturers[40].LaborForce.ToString();
            ZAF_Bloemfontein_ManuAmountofSales[3].text = database.manufacturers[40].AmountofSales.ToString();
            ZAF_Bloemfontein_ManuTotalassets[3].text = database.manufacturers[40].Totalassets.ToString();

            ZAF_CapeTown_ManuLaborForce[0].text = database.manufacturers[41].LaborForce.ToString();
            ZAF_CapeTown_ManuAmountofSales[0].text = database.manufacturers[41].AmountofSales.ToString();
            ZAF_CapeTown_ManuTotalassets[0].text = database.manufacturers[41].Totalassets.ToString();
            ZAF_CapeTown_ManuLaborForce[1].text = database.manufacturers[42].LaborForce.ToString();
            ZAF_CapeTown_ManuAmountofSales[1].text = database.manufacturers[42].AmountofSales.ToString();
            ZAF_CapeTown_ManuTotalassets[1].text = database.manufacturers[42].Totalassets.ToString();
            ZAF_CapeTown_ManuLaborForce[2].text = database.manufacturers[43].LaborForce.ToString();
            ZAF_CapeTown_ManuAmountofSales[2].text = database.manufacturers[43].AmountofSales.ToString();
            ZAF_CapeTown_ManuTotalassets[2].text = database.manufacturers[43].Totalassets.ToString();
            ZAF_CapeTown_ManuLaborForce[3].text = database.manufacturers[44].LaborForce.ToString();
            ZAF_CapeTown_ManuAmountofSales[3].text = database.manufacturers[44].AmountofSales.ToString();
            ZAF_CapeTown_ManuTotalassets[3].text = database.manufacturers[44].Totalassets.ToString();
            ZAF_CapeTown_ManuLaborForce[4].text = database.manufacturers[45].LaborForce.ToString();
            ZAF_CapeTown_ManuAmountofSales[4].text = database.manufacturers[45].AmountofSales.ToString();
            ZAF_CapeTown_ManuTotalassets[4].text = database.manufacturers[45].Totalassets.ToString();
        }

    }
}
