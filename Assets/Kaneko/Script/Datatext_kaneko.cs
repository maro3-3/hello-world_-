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


        //CHN_Beijing_manuPage_ClientName[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientName.ToString();
        //CHN_Beijing_manuPage_ClientName[1].text = clientData.CHN_Beijing_Clients[1].CHN_Beijing_ClientName.ToString();

        //CHN_Beijing_ClientNameList[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientName.ToString();
        //CHN_Beijing_ClientNameList[1].text = clientData.CHN_Beijing_Clients[1].CHN_Beijing_ClientName.ToString();

        //CHN_Beijing_Clientpage_RequNum[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_RequNum[0].ToString();
        //CHN_Beijing_Clientpage_Pays[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_AmoPayMid[0].ToString();

        //CHN_Beijing_ClientName[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientName.ToString();
        //CHN_Beijing_ClientLv[0].text = clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientLv.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
    }
}
