//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ClientInitialize : MonoBehaviour
//{
//    ClientData clientData = null;
//    List_ClientInformation ClientList;
//    List_ClientTransactionPays TransactionPaysList;


//    void Awake()
//    {
//        clientData = Resources.Load<ClientData>("ClientData");
//        ClientList = Resources.Load("List_ClientInformation") as List_ClientInformation;
//        TransactionPaysList = Resources.Load("List_ClientTransactionPays") as List_ClientTransactionPays;

//        float random = 0.0f;    // ランダム用変数

//        for (int i = 0; i < 20; i++)
//        {
//            clientData.CHN_Beijing_Clients[i].CHN_Beijing_Init();

//            random = Random.value;


//            // ランダムでクライアントを設定
//            if (random <= 0.5f)
//            {
//                clientData.CHN_Beijing_Clients[i].InitCHN_Beijing_Clients(ClientList.sheets[0].list[0].int_CountryNo,
//                                                                          ClientList.sheets[0].list[0].int_AreaNo,
//                                                                          ClientList.sheets[0].list[0].int_ClientNo,
//                                                                          ClientList.sheets[0].list[0].string_ClientName,
//                                                                          ClientList.sheets[0].list[0].int_ClientLv,
//                                                                          ClientList.sheets[0].list[0].int_ClientType,
//                                                                          ClientList.sheets[0].list[0].int_Transaction_1,
//                                                                          ClientList.sheets[0].list[0].int_Transaction_2,
//                                                                          ClientList.sheets[0].list[0].int_Transaction_3,
//                                                                          ClientList.sheets[0].list[0].int_Transaction_4,
//                                                                          ClientList.sheets[0].list[0].int_Transaction_5,
//                                                                          ClientList.sheets[0].list[0].int_Transaction_6,
//                                                                          i, 0, 0, null, 0, 0, 0, 0);
//                // クライアント取引物　要求数・支払額初期化
//                for (int n = 0; n < 6; n++)
//                {

//                    clientData.CHN_Beijing_Clients[i].CHN_Beijing_AmoPayInit(TransactionPaysList.sheets[0].list[n].int_RequestsNum,
//                                                                             TransactionPaysList.sheets[0].list[n].int_AmoPay_High,
//                                                                             TransactionPaysList.sheets[0].list[n].int_AmoPay_Mid,
//                                                                             TransactionPaysList.sheets[0].list[n].int_AmoPay_Low,
//                                                                             n);
//                }



//            }
//            else
//            {
//                clientData.CHN_Beijing_Clients[i].InitCHN_Beijing_Clients(ClientList.sheets[0].list[1].int_CountryNo,
//                                                                          ClientList.sheets[0].list[1].int_AreaNo,
//                                                                          ClientList.sheets[0].list[1].int_ClientNo,
//                                                                          ClientList.sheets[0].list[1].string_ClientName,
//                                                                          ClientList.sheets[0].list[1].int_ClientLv,
//                                                                          ClientList.sheets[0].list[1].int_ClientType,
//                                                                          ClientList.sheets[0].list[1].int_Transaction_1,
//                                                                          ClientList.sheets[0].list[1].int_Transaction_2,
//                                                                          ClientList.sheets[0].list[1].int_Transaction_3,
//                                                                          ClientList.sheets[0].list[1].int_Transaction_4,
//                                                                          ClientList.sheets[0].list[1].int_Transaction_5,
//                                                                          ClientList.sheets[0].list[1].int_Transaction_6,
//                                                                          i, 0, 0, null, 0, 0, 0, 1);

//                // クライアント取引物　要求数・支払額初期化
//                for (int n = 0; n < 6; n++)
//                {

//                    clientData.CHN_Beijing_Clients[i].CHN_Beijing_AmoPayInit(TransactionPaysList.sheets[0].list[6 + n].int_RequestsNum,
//                                                                             TransactionPaysList.sheets[0].list[6 + n].int_AmoPay_High,
//                                                                             TransactionPaysList.sheets[0].list[6 + n].int_AmoPay_Mid,
//                                                                             TransactionPaysList.sheets[0].list[6 + n].int_AmoPay_Low,
//                                                                             n);
//                }
//            }




//        }
//        //clientData.CHN_Beijing_Clients[0].Performance[1] = clientData.CHN_Beijing_Clients[0].FluctuationValue(clientData.CHN_Beijing_Clients[0].CHN_Beijing_ClientType[1], 0);
//        //Debug.Log(clientData.CHN_Beijing_Clients[0].Performance[1]);
//    }
//}
