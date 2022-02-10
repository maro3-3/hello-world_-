using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class M_USA_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;

    // ¶YÒ
    [SerializeField] private Text[] USA_NewYork_ManuListPage = new Text[2];   // ’†‘–k‹¶YÒ–¼‘O
    [SerializeField] private Text[] USA_StLouis_ManuListPage = new Text[3];  // ’†‘ãŠC¶YÒ–¼‘O
    [SerializeField] private Text[] USA_Atlanta_ManuListPage = new Text[4];   // ’†‘lì¶YÒ–¼‘O

    [SerializeField] private Text[] USA_NewYork_ManuPageName = new Text[2];   // ’†‘–k‹¶YÒ–¼‘O
    [SerializeField] private Text[] USA_StLouis_ManuPageName = new Text[3];  // ’†‘ãŠC¶YÒ–¼‘O
    [SerializeField] private Text[] USA_Atlanta_ManuPageName = new Text[4];   // ’†‘lì¶YÒ–¼‘O

    [SerializeField] private Text[] USA_NewYork_ManuTotalassets = new Text[2];      // ’†‘–k‹‘‘Y
    [SerializeField] private Text[] USA_NewYork_ManuAmountofSales = new Text[2];    // ’†‘–k‹”„ã‚
    [SerializeField] private Text[] USA_NewYork_ManuLaborForce = new Text[2];       // ’†‘–k‹˜J“­—Í
    [SerializeField] private Text[] USA_StLouis_ManuTotalassets = new Text[3];     // ’†‘ãŠC‘‘Y
    [SerializeField] private Text[] USA_StLouis_ManuAmountofSales = new Text[3];   // ’†‘ãŠC”„ã‚
    [SerializeField] private Text[] USA_StLouis_ManuLaborForce = new Text[3];      // ’†‘ãŠC˜J“­—Í
    [SerializeField] private Text[] USA_Atlanta_ManuTotalassets = new Text[4];      // ’†‘lì‘‘Y
    [SerializeField] private Text[] USA_Atlanta_ManuAmountofSales = new Text[4];    // ’†‘lì”„ã‚
    [SerializeField] private Text[] USA_Atlanta_ManuLaborForce = new Text[4];       // ’†‘lì˜J“­—Í

    //[SerializeField] private Text[] CHN_Beijing_manuPage_ClientName = new Text[2];        // ’†‘–k‹ƒNƒ‰ƒCƒAƒ“ƒg–¼‘O
    //[SerializeField] private Text[] CHN_Beijing_Clientpage_RequNum = new Text[2];        // ’†‘–k‹—v‹”
    //[SerializeField] private Text[] CHN_Beijing_Clientpage_Pays = new Text[2];        // ’†‘–k‹—v‹”

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");

        // ¶YÒƒŠƒXƒg‚Å•\¦‚·‚é–¼‘O
        {
            USA_NewYork_ManuListPage[0].text = database.manufacturers[9].ManufacturerName.ToString();
            USA_NewYork_ManuListPage[1].text = database.manufacturers[10].ManufacturerName.ToString();
            USA_StLouis_ManuListPage[0].text = database.manufacturers[11].ManufacturerName.ToString();
            USA_StLouis_ManuListPage[1].text = database.manufacturers[12].ManufacturerName.ToString();
            USA_StLouis_ManuListPage[2].text = database.manufacturers[13].ManufacturerName.ToString();
            USA_Atlanta_ManuListPage[0].text = database.manufacturers[14].ManufacturerName.ToString();
            USA_Atlanta_ManuListPage[1].text = database.manufacturers[15].ManufacturerName.ToString();
            USA_Atlanta_ManuListPage[2].text = database.manufacturers[16].ManufacturerName.ToString();
            USA_Atlanta_ManuListPage[3].text = database.manufacturers[17].ManufacturerName.ToString();
        }

        // ¶YÒƒy[ƒW‚Å•\¦‚·‚é–¼‘O
        {
            USA_NewYork_ManuPageName[0].text = database.manufacturers[9].ManufacturerName.ToString();
            USA_NewYork_ManuPageName[1].text = database.manufacturers[10].ManufacturerName.ToString();
            USA_StLouis_ManuPageName[0].text = database.manufacturers[11].ManufacturerName.ToString();
            USA_StLouis_ManuPageName[1].text = database.manufacturers[12].ManufacturerName.ToString();
            USA_StLouis_ManuPageName[2].text = database.manufacturers[13].ManufacturerName.ToString();
            USA_Atlanta_ManuPageName[0].text = database.manufacturers[14].ManufacturerName.ToString();
            USA_Atlanta_ManuPageName[1].text = database.manufacturers[15].ManufacturerName.ToString();
            USA_Atlanta_ManuPageName[2].text = database.manufacturers[16].ManufacturerName.ToString();
            USA_Atlanta_ManuPageName[3].text = database.manufacturers[17].ManufacturerName.ToString();
        }

        // ‘‘Y@”„ã@˜J“­—Í
        {
            USA_NewYork_ManuLaborForce[0].text = database.manufacturers[9].LaborForce.ToString();
            USA_NewYork_ManuAmountofSales[0].text = database.manufacturers[9].AmountofSales.ToString();
            USA_NewYork_ManuTotalassets[0].text = database.manufacturers[9].Totalassets.ToString();
            USA_NewYork_ManuLaborForce[1].text = database.manufacturers[10].LaborForce.ToString();
            USA_NewYork_ManuAmountofSales[1].text = database.manufacturers[10].AmountofSales.ToString();
            USA_NewYork_ManuTotalassets[1].text = database.manufacturers[10].Totalassets.ToString();

            USA_StLouis_ManuLaborForce[0].text = database.manufacturers[11].LaborForce.ToString();
            USA_StLouis_ManuAmountofSales[0].text = database.manufacturers[11].AmountofSales.ToString();
            USA_StLouis_ManuTotalassets[0].text = database.manufacturers[11].Totalassets.ToString();

            USA_StLouis_ManuLaborForce[1].text = database.manufacturers[12].LaborForce.ToString();
            USA_StLouis_ManuAmountofSales[1].text = database.manufacturers[12].AmountofSales.ToString();
            USA_StLouis_ManuTotalassets[1].text = database.manufacturers[12].Totalassets.ToString();

            USA_StLouis_ManuLaborForce[2].text = database.manufacturers[13].LaborForce.ToString();
            USA_StLouis_ManuAmountofSales[2].text = database.manufacturers[13].AmountofSales.ToString();
            USA_StLouis_ManuTotalassets[2].text = database.manufacturers[13].Totalassets.ToString();

            USA_Atlanta_ManuLaborForce[0].text = database.manufacturers[14].LaborForce.ToString();
            USA_Atlanta_ManuAmountofSales[0].text = database.manufacturers[14].AmountofSales.ToString();
            USA_Atlanta_ManuTotalassets[0].text = database.manufacturers[14].Totalassets.ToString();
            USA_Atlanta_ManuLaborForce[1].text = database.manufacturers[15].LaborForce.ToString();
            USA_Atlanta_ManuAmountofSales[1].text = database.manufacturers[15].AmountofSales.ToString();
            USA_Atlanta_ManuTotalassets[1].text = database.manufacturers[15].Totalassets.ToString();
            USA_Atlanta_ManuLaborForce[2].text = database.manufacturers[16].LaborForce.ToString();
            USA_Atlanta_ManuAmountofSales[2].text = database.manufacturers[16].AmountofSales.ToString();
            USA_Atlanta_ManuTotalassets[2].text = database.manufacturers[16].Totalassets.ToString();
            USA_Atlanta_ManuLaborForce[3].text = database.manufacturers[17].LaborForce.ToString();
            USA_Atlanta_ManuAmountofSales[3].text = database.manufacturers[17].AmountofSales.ToString();
            USA_Atlanta_ManuTotalassets[3].text = database.manufacturers[17].Totalassets.ToString();
        }

    }
}