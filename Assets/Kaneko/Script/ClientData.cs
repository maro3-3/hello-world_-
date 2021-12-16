using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ClientData : ScriptableObject
{
    // クライアント //


    // 中国北京クライアント // 
    public struct CHN_Beijing_Client
    {
        public int[] CHN_Beijing_CountryNo;        // 国ナンバー
        public int[] CHN_Beijing_ClientAreaNo;           // 地域ナンバー
        public int[] CHN_Beijing_ClientNo;               // クライアントナンバー
        public string[] CHN_Beijing_ClientName;          // クライアントネーム
        public int[] CHN_Beijing_ClientLv;               // クライアントレベル
        public int[] CHN_Beijing_ClientType;             // 業績タイプ
        public int[] CHN_Beijing_T1;          // 取引物（複数　ＭＡＸ６個 ）
        public int[] CHN_Beijing_T2;          // 取引物（複数　ＭＡＸ６個 ）
        public int[] CHN_Beijing_T3;          // 取引物（複数　ＭＡＸ６個 ）
        public int[] CHN_Beijing_T4;          // 取引物（複数　ＭＡＸ６個 ）
        public int[] CHN_Beijing_T5;          // 取引物（複数　ＭＡＸ６個 ）
        public int[] CHN_Beijing_T6;          // 取引物（複数　ＭＡＸ６個 ）

        public int[] Transaction;             // 取引物
        public int[] TransactionStatus;       // 取引状況
        public string[] ManufacturerName;     // 取引相手
        public int[] Performance;             // 業績

        public int[] CHN_Beijing_RN1;           // 取引物要求数？
        public int[] CHN_Beijing_RN2;           // 取引物要求数？
        public int[] CHN_Beijing_RN3;           // 取引物要求数？
        public int[] CHN_Beijing_RN4;           // 取引物要求数？
        public int[] CHN_Beijing_RN5;           // 取引物要求数？
        public int[] CHN_Beijing_RN6;           // 取引物要求数？

        public int[] CHN_Beijing_AmoPayH1;      // 取引物支払額？High
        public int[] CHN_Beijing_AmoPayH2;      // 取引物支払額？
        public int[] CHN_Beijing_AmoPayH3;      // 取引物支払額？
        public int[] CHN_Beijing_AmoPayH4;      // 取引物支払額？
        public int[] CHN_Beijing_AmoPayH5;      // 取引物支払額？
        public int[] CHN_Beijing_AmoPayH6;      // 取引物支払額？

        public int[] CHN_Beijing_AmoPayM1;      // 取引物支払額？Mid
        public int[] CHN_Beijing_AmoPayM2;      // 取引物支払額？
        public int[] CHN_Beijing_AmoPayM3;      // 取引物支払額？
        public int[] CHN_Beijing_AmoPayM4;      // 取引物支払額？
        public int[] CHN_Beijing_AmoPayM5;      // 取引物支払額？
        public int[] CHN_Beijing_AmoPayM6;      // 取引物支払額？

        public int[] CHN_Beijing_AmoPayL1;  　　// 取引物支払額？Low
        public int[] CHN_Beijing_AmoPayL2;  　　// 取引物支払額？
        public int[] CHN_Beijing_AmoPayL3;  　　// 取引物支払額？
        public int[] CHN_Beijing_AmoPayL4;  　　// 取引物支払額？
        public int[] CHN_Beijing_AmoPayL5;  　　// 取引物支払額？
        public int[] CHN_Beijing_AmoPayL6;    // 取引物支払額？

        // 初期化関数
        public void CHN_Beijing_Init()
        {
            CHN_Beijing_CountryNo = new int[2]; CHN_Beijing_ClientAreaNo = new int[2];
            CHN_Beijing_ClientNo = new int[2]; CHN_Beijing_ClientName = new string[2];
            CHN_Beijing_ClientLv = new int[2]; CHN_Beijing_ClientType = new int[2];
            CHN_Beijing_T1 = new int[2]; CHN_Beijing_T2 = new int[2];
            CHN_Beijing_T3 = new int[2]; CHN_Beijing_T4 = new int[2];
            CHN_Beijing_T5 = new int[2]; CHN_Beijing_T6 = new int[2];
            CHN_Beijing_RN1 = new int[2]; CHN_Beijing_RN2 = new int[2];
            CHN_Beijing_RN3 = new int[2]; CHN_Beijing_RN4 = new int[2];
            CHN_Beijing_RN5 = new int[2]; CHN_Beijing_RN6 = new int[2];
            CHN_Beijing_AmoPayH1 =new int[2]; CHN_Beijing_AmoPayH2 =new int[2];
            CHN_Beijing_AmoPayH3 =new int[2]; CHN_Beijing_AmoPayH4 =new int[2];
            CHN_Beijing_AmoPayH5 =new int[2]; CHN_Beijing_AmoPayH6 =new int[2];
            CHN_Beijing_AmoPayM1 =new int[2]; CHN_Beijing_AmoPayM2 =new int[2];
            CHN_Beijing_AmoPayM3 =new int[2]; CHN_Beijing_AmoPayM4 =new int[2];
            CHN_Beijing_AmoPayM5 =new int[2]; CHN_Beijing_AmoPayM6 =new int[2];
            CHN_Beijing_AmoPayL1 =new int[2]; CHN_Beijing_AmoPayL2 =new int[2];
            CHN_Beijing_AmoPayL3 =new int[2]; CHN_Beijing_AmoPayL4 =new int[2];
            CHN_Beijing_AmoPayL5 =new int[2]; CHN_Beijing_AmoPayL6 = new int[2];
            Transaction = new int[2]; TransactionStatus = new int[2];
            ManufacturerName = new string[2]; Performance = new int[2];
        }
        public void InitCHN_Beijing_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int index)
        {


            CHN_Beijing_CountryNo[index] = clientCountryNo;
            CHN_Beijing_ClientAreaNo[index] = clientAreaNo;
            CHN_Beijing_ClientNo[index] = clientNo;
            CHN_Beijing_ClientName[index] = clientName;
            CHN_Beijing_ClientLv[index] = clientLv;
            CHN_Beijing_ClientType[index] = clientType;
            CHN_Beijing_T1[index] = t1;
            CHN_Beijing_T2[index] = t2;
            CHN_Beijing_T3[index] = t3;
            CHN_Beijing_T4[index] = t4;
            CHN_Beijing_T5[index] = t5;
            CHN_Beijing_T6[index] = t6;
            Transaction[index] = transaction;
            TransactionStatus[index] = transactionStatus;
            ManufacturerName[index] = manufacturerName;
            Performance[index] = performance;

        }
        public void CHN_Beijing_TransactionInit(int rn1, int rn2, int rn3, int rn4, int rn5, int rn6, int h1, int h2, int h3, int h4, int h5, int h6,
                                                int m1, int m2, int m3, int m4, int m5, int m6, int l1, int l2, int l3, int l4, int l5, int l6, int index)
        {
            CHN_Beijing_RN1[index] = rn1;
            CHN_Beijing_RN2[index] = rn2;
            CHN_Beijing_RN3[index] = rn3;
            CHN_Beijing_RN4[index] = rn4;
            CHN_Beijing_RN5[index] = rn5;
            CHN_Beijing_RN6[index] = rn6;
            CHN_Beijing_AmoPayH1[index] = h1;
            CHN_Beijing_AmoPayH2[index] = h2;
            CHN_Beijing_AmoPayH3[index] = h3;
            CHN_Beijing_AmoPayH4[index] = h4;
            CHN_Beijing_AmoPayH5[index] = h5;
            CHN_Beijing_AmoPayH6[index] = h6;
            CHN_Beijing_AmoPayM1[index] = m1;
            CHN_Beijing_AmoPayM2[index] = m2;
            CHN_Beijing_AmoPayM3[index] = m3;
            CHN_Beijing_AmoPayM4[index] = m4;
            CHN_Beijing_AmoPayM5[index] = m5;
            CHN_Beijing_AmoPayM6[index] = m6;
            CHN_Beijing_AmoPayL1[index] = l1;
            CHN_Beijing_AmoPayL2[index] = l2;
            CHN_Beijing_AmoPayL3[index] = l3;
            CHN_Beijing_AmoPayL4[index] = l4;
            CHN_Beijing_AmoPayL5[index] = l5;
            CHN_Beijing_AmoPayL6[index] = l6;
        }
    };
    public CHN_Beijing_Client[] CHN_Beijing_Clients = new CHN_Beijing_Client[20];

    // 中国上海クライアント // 
    //public struct CHN_Shanghai_Client
    //{
    //    public int[] ClientCountryNo;        // 国ナンバー
    //    public int[] ClientAreaNo;           // 地域ナンバー
    //    public int[] ClientNo;               // クライアントナンバー
    //    public string[] ClientName;          // クライアントネーム
    //    public int[] ClientLv;               // クライアントレベル
    //    public int[] ClientType;             // 業績タイプ
    //    public int[] Transaction_1;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_2;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_3;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_4;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_5;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_6;          // 取引物（複数　ＭＡＸ６個 ）

    //    public int[] Transaction;             // 取引物
    //    public int[] TransactionStatus;       // 取引状況
    //    public string[] ManufacturerName;     // 取引相手
    //    public int[] Performance;             // 業績


    //    // 初期化関数
    //    public void InitCHN_Shanghai_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
    //                           int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
    //                           int transaction, int transactionStatus, string manufacturerName, int performance, int index)
    //    {
    //        ClientNo = new int[3]; ClientName = new string[3];
    //        ClientLv = new int[3]; ClientType = new int[3];
    //        Transaction_1 = new int[3]; Transaction_2 = new int[3];
    //        Transaction_3 = new int[3]; Transaction_4 = new int[3];
    //        Transaction_5 = new int[3]; Transaction_6 = new int[3];

    //        Transaction = new int[3]; TransactionStatus = new int[3];
    //        ManufacturerName = new string[3]; Performance = new int[3];

    //        ClientCountryNo = clientCountryNo;
    //        ClientAreaNo = clientAreaNo;
    //        ClientNo[index] = clientNo;
    //        ClientName[index] = clientName;
    //        ClientLv[index] = clientLv;
    //        ClientType[index] = clientType;
    //        Transaction_1[index] = t1;
    //        Transaction_2[index] = t2;
    //        Transaction_3[index] = t3;
    //        Transaction_4[index] = t4;
    //        Transaction_5[index] = t5;
    //        Transaction_6[index] = t6;
    //        Transaction[index] = transaction;
    //        TransactionStatus[index] = transactionStatus;
    //        ManufacturerName[index] = manufacturerName;
    //        Performance[index] = performance;
    //    }
    //};
    //public CHN_Shanghai_Client[] CHN_Shanghai_Clients = new CHN_Shanghai_Client[20];

    //// 中国四川クライアント // 
    //public struct CHN_Sichuan_Client
    //{
    //    public int ClientCountryNo;        // 国ナンバー
    //    public int ClientAreaNo;           // 地域ナンバー
    //    public int[] ClientNo;               // クライアントナンバー
    //    public string[] ClientName;          // クライアントネーム
    //    public int[] ClientLv;               // クライアントレベル
    //    public int[] ClientType;             // 業績タイプ
    //    public int[] Transaction_1;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_2;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_3;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_4;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_5;          // 取引物（複数　ＭＡＸ６個 ）
    //    public int[] Transaction_6;          // 取引物（複数　ＭＡＸ６個 ）

    //    public int[] Transaction;             // 取引物
    //    public int[] TransactionStatus;       // 取引状況
    //    public string[] ManufacturerName;     // 取引相手
    //    public int[] Performance;             // 業績


    //    // 初期化関数
    //    public void InitCHN_Sichuan_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
    //                           int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
    //                           int transaction, int transactionStatus, string manufacturerName, int performance, int index)
    //    {
    //        ClientNo = new int[4]; ClientName = new string[4];
    //        ClientLv = new int[4]; ClientType = new int[4];
    //        Transaction_1 = new int[4]; Transaction_2 = new int[4];
    //        Transaction_3 = new int[4]; Transaction_4 = new int[4];
    //        Transaction_5 = new int[4]; Transaction_6 = new int[4];

    //        Transaction = new int[4]; TransactionStatus = new int[4];
    //        ManufacturerName = new string[4]; Performance = new int[4];

    //        ClientCountryNo = clientCountryNo;
    //        ClientAreaNo = clientAreaNo;
    //        ClientNo[index] = clientNo;
    //        ClientName[index] = clientName;
    //        ClientLv[index] = clientLv;
    //        ClientType[index] = clientType;
    //        Transaction_1[index] = t1;
    //        Transaction_2[index] = t2;
    //        Transaction_3[index] = t3;
    //        Transaction_4[index] = t4;
    //        Transaction_5[index] = t5;
    //        Transaction_6[index] = t6;
    //        Transaction[index] = transaction;
    //        TransactionStatus[index] = transactionStatus;
    //        ManufacturerName[index] = manufacturerName;
    //        Performance[index] = performance;
    //    }
    //};
    //public CHN_Sichuan_Client[] CHN_Sichuan_Clients = new CHN_Sichuan_Client[20];
}
