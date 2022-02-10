using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class M_CHN_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;

    // ¶YÒ
    [SerializeField] private Text[] CHN_Beijing_ManuListPage = new Text[2];   // ’†‘–k‹¶YÒ–¼‘O
    [SerializeField] private Text[] CHN_Shanghai_ManuListPage = new Text[2];  // ’†‘ãŠC¶YÒ–¼‘O
    [SerializeField] private Text[] CHN_Sichuan_ManuListPage = new Text[5];   // ’†‘lì¶YÒ–¼‘O

    [SerializeField] private Text[] CHN_Beijing_ManuPageName = new Text[2];   // ’†‘–k‹¶YÒ–¼‘O
    [SerializeField] private Text[] CHN_Shanghai_ManuPageName = new Text[2];  // ’†‘ãŠC¶YÒ–¼‘O
    [SerializeField] private Text[] CHN_Sichuan_ManuPageName = new Text[5];   // ’†‘lì¶YÒ–¼‘O

    [SerializeField] private Text[] CHN_Beijing_ManuTotalassets = new Text[2];      // ’†‘–k‹‘‘Y
    [SerializeField] private Text[] CHN_Beijing_ManuAmountofSales = new Text[2];    // ’†‘–k‹”„ã‚
    [SerializeField] private Text[] CHN_Beijing_ManuLaborForce = new Text[2];       // ’†‘–k‹˜J“­—Í
    [SerializeField] private Text[] CHN_Shanghai_ManuTotalassets = new Text[2];     // ’†‘ãŠC‘‘Y
    [SerializeField] private Text[] CHN_Shanghai_ManuAmountofSales = new Text[2];   // ’†‘ãŠC”„ã‚
    [SerializeField] private Text[] CHN_Shanghai_ManuLaborForce = new Text[2];      // ’†‘ãŠC˜J“­—Í
    [SerializeField] private Text[] CHN_Sichuan_ManuTotalassets = new Text[5];      // ’†‘lì‘‘Y
    [SerializeField] private Text[] CHN_Sichuan_ManuAmountofSales = new Text[5];    // ’†‘lì”„ã‚
    [SerializeField] private Text[] CHN_Sichuan_ManuLaborForce = new Text[5];       // ’†‘lì˜J“­—Í

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
            CHN_Beijing_ManuListPage[0].text = database.manufacturers[0].ManufacturerName.ToString();
            CHN_Beijing_ManuListPage[1].text = database.manufacturers[1].ManufacturerName.ToString();
            CHN_Shanghai_ManuListPage[0].text = database.manufacturers[2].ManufacturerName.ToString();
            CHN_Shanghai_ManuListPage[1].text = database.manufacturers[3].ManufacturerName.ToString();
            CHN_Sichuan_ManuListPage[0].text = database.manufacturers[4].ManufacturerName.ToString();
            CHN_Sichuan_ManuListPage[1].text = database.manufacturers[5].ManufacturerName.ToString();
            CHN_Sichuan_ManuListPage[2].text = database.manufacturers[6].ManufacturerName.ToString();
            CHN_Sichuan_ManuListPage[3].text = database.manufacturers[7].ManufacturerName.ToString();
            CHN_Sichuan_ManuListPage[4].text = database.manufacturers[8].ManufacturerName.ToString();
        }

        // ¶YÒƒy[ƒW‚Å•\¦‚·‚é–¼‘O
        {
            CHN_Beijing_ManuPageName[0].text = database.manufacturers[0].ManufacturerName.ToString();
            CHN_Beijing_ManuPageName[1].text = database.manufacturers[1].ManufacturerName.ToString();
            CHN_Shanghai_ManuPageName[0].text = database.manufacturers[2].ManufacturerName.ToString();
            CHN_Shanghai_ManuPageName[1].text = database.manufacturers[3].ManufacturerName.ToString();
            CHN_Sichuan_ManuPageName[0].text = database.manufacturers[4].ManufacturerName.ToString();
            CHN_Sichuan_ManuPageName[1].text = database.manufacturers[5].ManufacturerName.ToString();
            CHN_Sichuan_ManuPageName[2].text = database.manufacturers[6].ManufacturerName.ToString();
            CHN_Sichuan_ManuPageName[3].text = database.manufacturers[7].ManufacturerName.ToString();
            CHN_Sichuan_ManuPageName[4].text = database.manufacturers[8].ManufacturerName.ToString();
        }

        // ‘‘Y@”„ã@˜J“­—Í
        {
            CHN_Beijing_ManuLaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
            CHN_Beijing_ManuLaborForce[1].text = database.manufacturers[1].LaborForce.ToString();
            CHN_Beijing_ManuAmountofSales[0].text = database.manufacturers[0].AmountofSales.ToString();
            CHN_Beijing_ManuAmountofSales[1].text = database.manufacturers[1].AmountofSales.ToString();
            CHN_Beijing_ManuTotalassets[0].text = database.manufacturers[0].Totalassets.ToString();
            CHN_Beijing_ManuTotalassets[1].text = database.manufacturers[1].Totalassets.ToString();

            CHN_Shanghai_ManuLaborForce[0].text = database.manufacturers[2].LaborForce.ToString();
            CHN_Shanghai_ManuLaborForce[1].text = database.manufacturers[3].LaborForce.ToString();
            CHN_Shanghai_ManuAmountofSales[0].text = database.manufacturers[2].AmountofSales.ToString();
            CHN_Shanghai_ManuAmountofSales[1].text = database.manufacturers[3].AmountofSales.ToString();
            CHN_Shanghai_ManuTotalassets[0].text = database.manufacturers[2].Totalassets.ToString();
            CHN_Shanghai_ManuTotalassets[1].text = database.manufacturers[3].Totalassets.ToString();

            CHN_Sichuan_ManuLaborForce[0].text = database.manufacturers[4].LaborForce.ToString();
            CHN_Sichuan_ManuLaborForce[1].text = database.manufacturers[5].LaborForce.ToString();
            CHN_Sichuan_ManuLaborForce[2].text = database.manufacturers[6].LaborForce.ToString();
            CHN_Sichuan_ManuLaborForce[3].text = database.manufacturers[7].LaborForce.ToString();
            CHN_Sichuan_ManuLaborForce[4].text = database.manufacturers[8].LaborForce.ToString();
            CHN_Sichuan_ManuAmountofSales[0].text = database.manufacturers[4].AmountofSales.ToString();
            CHN_Sichuan_ManuAmountofSales[1].text = database.manufacturers[5].AmountofSales.ToString();
            CHN_Sichuan_ManuAmountofSales[2].text = database.manufacturers[6].AmountofSales.ToString();
            CHN_Sichuan_ManuAmountofSales[3].text = database.manufacturers[7].AmountofSales.ToString();
            CHN_Sichuan_ManuAmountofSales[4].text = database.manufacturers[8].AmountofSales.ToString();
            CHN_Sichuan_ManuTotalassets[0].text = database.manufacturers[4].Totalassets.ToString();
            CHN_Sichuan_ManuTotalassets[1].text = database.manufacturers[5].Totalassets.ToString();
            CHN_Sichuan_ManuTotalassets[2].text = database.manufacturers[6].Totalassets.ToString();
            CHN_Sichuan_ManuTotalassets[3].text = database.manufacturers[7].Totalassets.ToString();
            CHN_Sichuan_ManuTotalassets[4].text = database.manufacturers[8].Totalassets.ToString();
        }

    }
}