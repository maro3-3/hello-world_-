using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class InitManager : MonoBehaviour
{
    DataBase database = null;
    ListManufacture ManuList;
    ListCountry CountryList;
    ListClient ClientList;

    // Start is called before the first frame update
    void Start()
    {        // ScriptableObjectの取得
        database = Resources.Load<DataBase>("DataBase");
        ManuList = Resources.Load("List_manufacturer") as ListManufacture;
        CountryList = Resources.Load("List_CountryAndArea") as ListCountry;
        ClientList = Resources.Load("List_Client") as ListClient;

        // 失業者初期化
        database.UnemployedNum = 0;
        database.EmploymentNum = 0;

        // ドローン初期化
        database.PossessionDroneNum = 0;
        database.TempingDroneNum = 0;
        database.ExtensionStage = 0;

        // ターン初期化
        database.TurnNum = 0;

        // ミッション初期化
        database.MissionState = 0;


        // 生産者初期化
        for (int i = 0; i < ManuList.sheets[0].list.Count; i++)
        {
            database.manufacturers[i].InitManufacturer(ManuList.sheets[0].list[i].int_CountryNo,
                                       ManuList.sheets[0].list[i].int_AreaNo,
                                       ManuList.sheets[0].list[i].int_ManufacturerNo,
                                       ManuList.sheets[0].list[i].string_ManufacturerName,
                                       ManuList.sheets[0].list[i].int_Products,
                                       0, 0, 0, 0, 0, 0, 0, 0);
        }
        // 国初期化
        for (int i = 0; i < CountryList.sheets[0].list.Count; i++)
        {
            database.countrys[i].InitCountry(CountryList.sheets[0].list[i].int_CountryNo,
                CountryList.sheets[0].list[i].int_AreaNo,
                CountryList.sheets[0].list[i].int_UnemployedNum,
                0, 0);
        }
        // クライアント初期化
        for (int i = 0; i < ClientList.sheets[0].list.Count; i++)
        {
            database.clients[i].InitClient(ClientList.sheets[0].list[i].int_CountryNo,
                ClientList.sheets[0].list[i].int_AreaNo,
                ClientList.sheets[0].list[i].int_ClientNo,
                ClientList.sheets[0].list[i].string_ClientName,
                ClientList.sheets[0].list[i].int_ClientLv,
                ClientList.sheets[0].list[i].int_ClientType,
                0, 0, null, 0);

            database.clients[i].SetTransactions(ClientList.sheets[0].list[i].int_Transaction_1,
                ClientList.sheets[0].list[i].int_Transaction_2,
                ClientList.sheets[0].list[i].int_Transaction_3,
                ClientList.sheets[0].list[i].int_Transaction_4,
                ClientList.sheets[0].list[i].int_Transaction_5,
                ClientList.sheets[0].list[i].int_Transaction_6);
        }
    }
    void Awake()
    {


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
