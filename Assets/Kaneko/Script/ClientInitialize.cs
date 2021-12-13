using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientInitialize : MonoBehaviour
{
    ClientData clientData = null;
    List_ClientInformation ClientList;
    List_ClientTransactionPays TransactionPaysList;
    void Awake()
    {
        clientData = Resources.Load<ClientData>("ClientData");
        ClientList = Resources.Load("List_ClientInformation") as List_ClientInformation;
        TransactionPaysList = Resources.Load("List_ClientTransactionPays") as List_ClientTransactionPays;

        for (int i = 0; i < 20; i++)
        {
            clientData.CHN_Beijing_Clients[i].CHN_Beijing_Init();

            // 中国北京クライアント初期化
            for (int j = 0; j < 2; j++)
            {
                clientData.CHN_Beijing_Clients[i].InitCHN_Beijing_Clients(ClientList.sheets[0].list[j].int_CountryNo,
                                                                        ClientList.sheets[0].list[j].int_AreaNo,
                                                                        ClientList.sheets[0].list[j].int_ClientNo,
                                                                        ClientList.sheets[0].list[j].string_ClientName,
                                                                        ClientList.sheets[0].list[j].int_ClientLv,
                                                                        ClientList.sheets[0].list[j].int_ClientType,
                                                                        ClientList.sheets[0].list[j].int_Transaction_1,
                                                                        ClientList.sheets[0].list[j].int_Transaction_2,
                                                                        ClientList.sheets[0].list[j].int_Transaction_3,
                                                                        ClientList.sheets[0].list[j].int_Transaction_4,
                                                                        ClientList.sheets[0].list[j].int_Transaction_5,
                                                                        ClientList.sheets[0].list[j].int_Transaction_6,
                                                                        0, 0, null, 0, j);
            }
            // クライアント取引物　要求数・支払額初期化
            for(int t = 0; t < 2; t++)
            {
                clientData.CHN_Beijing_Clients[i].CHN_Beijing_TransactionInit(TransactionPaysList.sheets[0].list[0 + (t * 6)].int_RequestsNum, TransactionPaysList.sheets[0].list[1 + (t * 6)].int_RequestsNum,
                                                                              TransactionPaysList.sheets[0].list[2 + (t * 6)].int_RequestsNum, TransactionPaysList.sheets[0].list[3 + (t * 6)].int_RequestsNum,
                                                                              TransactionPaysList.sheets[0].list[4 + (t * 6)].int_RequestsNum, TransactionPaysList.sheets[0].list[5 + (t * 6)].int_RequestsNum,
                                                                              TransactionPaysList.sheets[0].list[0 + (t * 6)].int_AmoPay_High, TransactionPaysList.sheets[0].list[1 + (t * 6)].int_AmoPay_High,
                                                                              TransactionPaysList.sheets[0].list[2 + (t * 6)].int_AmoPay_High, TransactionPaysList.sheets[0].list[3 + (t * 6)].int_AmoPay_High,
                                                                              TransactionPaysList.sheets[0].list[4 + (t * 6)].int_AmoPay_High, TransactionPaysList.sheets[0].list[5 + (t * 6)].int_AmoPay_High,
                                                                              TransactionPaysList.sheets[0].list[0 + (t * 6)].int_AmoPay_Mid, TransactionPaysList.sheets[0].list[1 + (t * 6)].int_AmoPay_Mid,
                                                                              TransactionPaysList.sheets[0].list[2 + (t * 6)].int_AmoPay_Mid, TransactionPaysList.sheets[0].list[3 + (t * 6)].int_AmoPay_Mid,
                                                                              TransactionPaysList.sheets[0].list[4 + (t * 6)].int_AmoPay_Mid, TransactionPaysList.sheets[0].list[5 + (t * 6)].int_AmoPay_Mid,
                                                                              TransactionPaysList.sheets[0].list[0 + (t * 6)].int_AmoPay_Low, TransactionPaysList.sheets[0].list[1 + (t * 6)].int_AmoPay_Low,
                                                                              TransactionPaysList.sheets[0].list[2 + (t * 6)].int_AmoPay_Low, TransactionPaysList.sheets[0].list[3 + (t * 6)].int_AmoPay_Low,
                                                                              TransactionPaysList.sheets[0].list[4 + (t * 6)].int_AmoPay_Low, TransactionPaysList.sheets[0].list[5 + (t * 6)].int_AmoPay_Low, t);
            }

        }
    }
}
