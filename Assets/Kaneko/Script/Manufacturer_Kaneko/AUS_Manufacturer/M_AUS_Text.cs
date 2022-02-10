using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class M_AUS_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;

    // ���Y��
    [SerializeField] private Text[] AUS_Canberra_ManuListPage = new Text[4];   // �I�[�X�g�����A�@�L�����x�����Y�Җ��O
    [SerializeField] private Text[] AUS_Perth_ManuListPage = new Text[3];      // �I�[�X�g�����A�@�p�[�X���Y�Җ��O
    [SerializeField] private Text[] AUS_Melbourne_ManuListPage = new Text[3];  // �I�[�X�g�����A�@�����{�������Y�Җ��O

    [SerializeField] private Text[] AUS_Canberra_ManuPageName = new Text[4];   // �I�[�X�g�����A�@�L�����x�����Y�Җ��O
    [SerializeField] private Text[] AUS_Perth_ManuPageName = new Text[3];      // �I�[�X�g�����A�@�p�[�X���Y�Җ��O
    [SerializeField] private Text[] AUS_Melbourne_ManuPageName = new Text[3];  // �I�[�X�g�����A�@�����{�������Y�Җ��O

    [SerializeField] private Text[] AUS_Canberra_ManuTotalassets = new Text[4];      // �I�[�X�g�����A�@�L�����x�������Y
    [SerializeField] private Text[] AUS_Canberra_ManuAmountofSales = new Text[4];    // �I�[�X�g�����A�@�L�����x�����㍂
    [SerializeField] private Text[] AUS_Canberra_ManuLaborForce = new Text[4];       // �I�[�X�g�����A�@�L�����x���J����
    [SerializeField] private Text[] AUS_Perth_ManuTotalassets = new Text[3];     // �I�[�X�g�����A�@�p�[�X�����Y
    [SerializeField] private Text[] AUS_Perth_ManuAmountofSales = new Text[3];   // �I�[�X�g�����A�@�p�[�X���㍂
    [SerializeField] private Text[] AUS_Perth_ManuLaborForce = new Text[3];      // �I�[�X�g�����A�@�p�[�X�J����
    [SerializeField] private Text[] AUS_Melbourne_ManuTotalassets = new Text[3];      // �I�[�X�g�����A�@�����{���������Y
    [SerializeField] private Text[] AUS_Melbourne_ManuAmountofSales = new Text[3];    // �I�[�X�g�����A�@�����{�������㍂
    [SerializeField] private Text[] AUS_Melbourne_ManuLaborForce = new Text[3];       // �I�[�X�g�����A�@�����{�����J����

    //[SerializeField] private Text[] CHN_Beijing_manuPage_ClientName = new Text[2];        // �����k���N���C�A���g���O
    //[SerializeField] private Text[] CHN_Beijing_Clientpage_RequNum = new Text[2];        // �����k���v����
    //[SerializeField] private Text[] CHN_Beijing_Clientpage_Pays = new Text[2];        // �����k���v����

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");

        // ���Y�҃��X�g�ŕ\�����閼�O
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

        // ���Y�҃y�[�W�ŕ\�����閼�O
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

        // �����Y�@����@�J����
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