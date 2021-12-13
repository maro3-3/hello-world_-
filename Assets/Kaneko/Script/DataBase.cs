using UnityEngine;
using System.Collections;
using System.Collections.Generic;


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

    public int MissionState;       // ミッション段階
    public enum MissionRewards      // ミッション報酬
    {
        PutinChoice,    // 選択肢に入れる
        selected,       // 選択済み
        Unopened        // 未開放
    }

    // ミニゲーム //
    public bool Win;
    public bool Lose;
    public int MiniClieNo; // ミニゲーム対象のクライアントナンバー
    public int Amount; // クライアントの取引額

    public int[] RewardLv = new int[12];               // ミッションレベル
    public int[] EmploymentTarget = new int[12];       // 目標雇用数
    public int[] RewartContent = new int[12];          // 報酬
    public int[] RewartState = new int[12];            // 報酬ステート


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

        // 初期化関数
        public void InitCountry(int countryState, int countryNo, string countryName, int areaNo, string areaName, int UnemuloyedNum, int areaLv, int cumulativeNumber)
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
    public Country[] countrys = new Country[14];

    //  地域レベル //
    public struct AreaLv
    {
        public int CountryNo;
        public int AreaNo;
        public int[] AreaLvs;

        public void InitAreaLv(int countryNo, int areaNo)
        {
            CountryNo = countryNo;
            AreaNo = areaNo;
        }
        public void InitLv(int lv2, int lv3, int lv4, int lv5)
        {
            AreaLvs = new int[4];
            AreaLvs[0] = lv2;
            AreaLvs[1] = lv3;
            AreaLvs[2] = lv4;
            AreaLvs[3] = lv5;
        }
    }
    public AreaLv[] areaLvs = new AreaLv[14];

    // 失業者 //
    public struct Unemployed
    {
        public int UnemployedCountryNo;   // 国ナンバー
        public int UnemployedAreaNo;      // 地域ナンバー
        public int InitUnemployedNum;  // その地域の失業者数

        public int CurrentUnemployedNum;        //その地域の失業者数（生存者）　リストから
        public int EmploymentNum;               // その地域の雇用数
        public int Faint_BreathNum;             //その地域の虫の息数　０
        public int Death_tollNum;               //その地域の死亡者数　０

        public void InitUnemployed(int countryNo, int areaNo, int initUnemployedNum, int currentUnemployedNum, int employmentNum, int faint_BreathNum, int death_tollNum)
        {
            UnemployedCountryNo = countryNo;
            UnemployedAreaNo = areaNo;
            InitUnemployedNum = initUnemployedNum;
            CurrentUnemployedNum = currentUnemployedNum;
            EmploymentNum = employmentNum;
            Faint_BreathNum = faint_BreathNum;
            Death_tollNum = death_tollNum;
        }
    }
    public Unemployed[] unemployed = new Unemployed[14];
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
        public int BusinessPartnerClient;   // 取引先クライアント //配列（複数人
        public int TransactionObject;       // 取引物
        public int RequestNum;              // 要求数
        public int Payment;                 // 支払い

        // 初期化関数
        public void InitManufacturer(int countryNo, int areaNo, int manuNo, string manuName, int products,
            int totalassets, int amountofSales, int laborForce, int numberofEmployees,
            int businessPartnerClient, int transactionObject, int requestNum, int payment)
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

       



        // 初期化関数
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

    // クライアント到着テーブル？ //
    public struct ClientArrivalTable
    {
        public int CountryNo;
        public int AreaNo;
        public int[] Client_Person;

        public void InitClientArrivalTable(int countryNo, int areaNo)
        {
            CountryNo = countryNo;
            AreaNo = areaNo;
        }
        public void InitClient_Person(int _1th, int _2th, int _3th, int _4th, int _5th, int _6th, int _7th, int _8th, int _9th, int _10th,
            int _11th, int _12th, int _13th, int _14th, int _15th, int _16th, int _17th, int _18th, int _19th, int _20th)
        {
            Client_Person = new int[20];
            Client_Person[0] = _1th;
            Client_Person[1] = _2th;
            Client_Person[2] = _3th;
            Client_Person[3] = _4th;
            Client_Person[4] = _5th;
            Client_Person[5] = _6th;
            Client_Person[6] = _7th;
            Client_Person[7] = _8th;
            Client_Person[8] = _9th;
            Client_Person[9] = _10th;
            Client_Person[10] = _11th;
            Client_Person[11] = _12th;
            Client_Person[12] = _13th;
            Client_Person[13] = _14th;
            Client_Person[14] = _15th;
            Client_Person[15] = _16th;
            Client_Person[16] = _17th;
            Client_Person[17] = _18th;
            Client_Person[18] = _19th;
            Client_Person[19] = _20th;
        }
    }
    public ClientArrivalTable[] ClientArrivalTables = new ClientArrivalTable[14];

    // ミニゲーム //
    public bool Win;
    public bool Lose;
    public int MiniClieNo; // ミニゲーム対象のクライアントナンバー
    public int Amount; // クライアントの取引額
}