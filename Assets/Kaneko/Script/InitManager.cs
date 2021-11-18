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
    ListAreaLv AreaLvList;
    ListClient ClientList;
    ListClientArrivalTable ClientArrivalTableList;
    ListMission MissionList;

    // Start is called before the first frame update
    void Awake()
    {        // ScriptableObjectの取得
        database = Resources.Load<DataBase>("DataBase");
        ManuList = Resources.Load("List_manufacturer") as ListManufacture;
        CountryList = Resources.Load("List_CountryAndArea") as ListCountry;
        AreaLvList = Resources.Load("List_AreaLv") as ListAreaLv;
        ClientList = Resources.Load("List_Client") as ListClient;
        ClientArrivalTableList = Resources.Load("List_ClientArrivalTable") as ListClientArrivalTable;
        MissionList = Resources.Load("List_Mission") as ListMission;

        // 失業者初期化
        database.UnemployedNum = 0;
        database.EmploymentNum = 0;

        // ドローン初期化
        database.PossessionDroneNum = 0;
        database.TempingDroneNum = 0;
        database.ExtensionStage = 0;

        // ターン初期化
        database.TurnNum = 0;

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
            database.countrys[i].InitCountry(CountryList.sheets[0].list[i].int_CountryState,
                CountryList.sheets[0].list[i].int_CountryNo,
                CountryList.sheets[0].list[i].string_CountryName,
                CountryList.sheets[0].list[i].int_AreaNo,
                CountryList.sheets[0].list[i].string_AreaName,
                CountryList.sheets[0].list[i].int_UnemployedNum,
                0, 0);
        }

        // 地域レベル初期化
        for (int i = 0; i < AreaLvList.sheets[0].list.Count; i++)
        {
            database.areaLvs[i].InitAreaLv(AreaLvList.sheets[0].list[i].int_CountryNo,
                                           AreaLvList.sheets[0].list[i].int_AreaNo);

            database.areaLvs[i].InitLv(AreaLvList.sheets[0].list[i].int_AreaLv2,
                                       AreaLvList.sheets[0].list[i].int_AreaLv3,
                                       AreaLvList.sheets[0].list[i].int_AreaLv4,
                                       AreaLvList.sheets[0].list[i].int_AreaLv5);
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

        // クライアント到着テーブル
        for(int i = 0;i < ClientArrivalTableList.sheets[0].list.Count; i++)
        {
            database.ClientArrivalTables[i].InitClientArrivalTable(ClientArrivalTableList.sheets[0].list[i].int_CountryNo,
                                                                   ClientArrivalTableList.sheets[0].list[i].int_AreaNo);

            database.ClientArrivalTables[i].InitClient_Person(ClientArrivalTableList.sheets[0].list[i].int_Client_1thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_2thPerson,
                ClientArrivalTableList.sheets[0].list[i].int_Client_3thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_4thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_5thPerson,
                ClientArrivalTableList.sheets[0].list[i].int_Client_6thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_7thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_8thPerson,
                ClientArrivalTableList.sheets[0].list[i].int_Client_9thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_10thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_11thPerson,
                ClientArrivalTableList.sheets[0].list[i].int_Client_12thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_13thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_14thPerson,
                ClientArrivalTableList.sheets[0].list[i].int_Client_15thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_16thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_17thPerson,
                ClientArrivalTableList.sheets[0].list[i].int_Client_18thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_19thPerson, ClientArrivalTableList.sheets[0].list[i].int_Client_20thPerson);
        }

        // ミッション初期化
        for (int i = 0; i < MissionList.sheets[0].list.Count; i++)
        {
            database.RewardLv[i] = MissionList.sheets[0].list[i].int_RewardLv;
            database.EmploymentTarget[i] = MissionList.sheets[0].list[i].int_EmploymentTarget;
            database.RewartContent[i] = MissionList.sheets[0].list[i].int_RewardContent;
            database.RewartState[i] = MissionList.sheets[0].list[i].int_RewardState;
        }

    }
}
