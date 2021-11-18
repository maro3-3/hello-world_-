using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DataBase : ScriptableObject
{

    // 失業者 //
    public int UnemployedNum;       // 登録した失業者数
    public int EmploymentNum;       // 雇用数


    // ドローン //
    public int PossessionDroneNum;         // 手持ちドローン数
    public int TempingDroneNum;            // 派遣中ドローン数
    public int ExtensionStage;             // 機能拡張段階


    // ターン //
    public int TurnNum;       // ターン数


    // ミッション //
    public int RewardLv;               // ミッションレベル
    public int EmploymentTarget;       // 目標雇用数
    public int RewartContent;          // 報酬
    public int RewartState;            // 報酬ステート


    // 国 //
    public struct Country
    {
        public int CountryState;
        public int CountryNo;           // 国ナンバー
        public string CountryName;      // 国の名前
        public int AreaNo;              // 地域ナンバー
        public string AreaName;         // 地域の名前
        public int UnemployedNum;       // 失業者数

        public int AreaLv;              // 地域レベル
        public int CumulativeNumber;    // クライアント累積要求数

        // 初期化
        public void InitCountry(int countryState, int countryNo, string countryName,int areaNo, string areaName, int UnemuloyedNum , int areaLv, int cumulativeNumber)
        {
            CountryState = countryState;
            CountryNo = countryNo;
            CountryName = countryName;
            AreaNo = areaNo;
            AreaName = areaName;
            UnemployedNum = UnemuloyedNum;
            AreaLv = areaLv;
            CumulativeNumber = cumulativeNumber;
        }
    }

    public Country[] countrys= new Country[14];

    // 生産者 //
    public struct Manufacturer
    {
        public int ManufacturerCountryNo;   // 国ナンバー
        public int ManufacturerAreaNo;      // 地域ナンバー
        public int ManufacturerNo;          // 生産者ナンバー
        public string ManufacturerName;     // 生産者名
        public int Products;                // 取引物

        public int Totalassets;             // 総資産
        public int AmountofSales;           // 売上高
        public int LaborForce;              // 労働力
        public int NumberofEmployees;       // 雇用人数
        public int BusinessPartnerClient;   // 取引先クライアント
        public int TransactionObject;       // 取引物
        public int RequestNum;              // 要求数
        public int Payment;                 // 支払い

        // 初期化
        public void InitManufacturer(int countryNo, int areaNo, int manuNo, string manuName, int products,
            int totalassets, int amountofSales, int laborForce, int numberofEmployees, 
            int businessPartnerClient,int transactionObject, int requestNum, int payment)
        {
            ManufacturerCountryNo = countryNo;
            ManufacturerAreaNo = areaNo;
            ManufacturerNo = manuNo;
            ManufacturerName = manuName;
            Products = products;
            Totalassets = totalassets;
            AmountofSales = amountofSales;
            LaborForce = laborForce;
            NumberofEmployees = numberofEmployees;
            BusinessPartnerClient = businessPartnerClient;
            TransactionObject = transactionObject;
            RequestNum = requestNum;
            Payment = payment;
        }

    };
    
    public Manufacturer[] manufacturers = new Manufacturer[46];

    // クライアント //
    public struct Client
    {
        public int ClientCountryNo;        // 国ナンバー
        public int ClientAreaNo;           // 地域ナンバー
        public int ClientNo;               // クライアントナンバー
        public string ClientName;          // クライアントネーム
        public int ClientLv;               // クライアントレベル
        public int ClientType;             // 業績タイプ
        public int[] Transactions;         // 取引物たち（複数　ＭＡＸ６個 ）

        public int Transaction;             //
        public int TransactionStatus;
        public string ManufacturerName;
        public int Performance;             // 業績


        // 初期化
        public void InitClient(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int transaction,
                               int transactionStatus, string manufacturerName, int performance)
        {
            ClientCountryNo = clientCountryNo;
            ClientAreaNo = clientAreaNo;
            ClientNo = clientNo;
            ClientName = clientName;
            ClientLv = clientLv;
            ClientType = clientType;
            Transaction = transaction;
            TransactionStatus = transactionStatus;
            ManufacturerName = manufacturerName;
            Performance = performance;
        }
        public void SetTransactions(int t1, int t2, int t3, int t4, int t5, int t6)
        {
            Transactions = new int[6];
            Transactions[0] = t1;
            Transactions[1] = t2;
            Transactions[2] = t3;
            Transactions[3] = t4;
            Transactions[4] = t5;
            Transactions[5] = t6;
        }
    };

    public Client[] clients = new Client[11];


    // 取引物をenumで設定
    enum a
    {

    }
}
