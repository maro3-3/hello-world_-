using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

// テストクラス
public class DataBase : ScriptableObject
{
    //public int _count = 10;
    //public void SetCount(int count) { _count = count; }     // セット
    //public int GetCount() { return _count; }                       // ゲット

    // 失業者 //

    public int _UnemployedNum;       // 登録した失業者数
    public int _EmploymentNum;       // 雇用数

    public void SetUnemployedNum(int unemployedNum) { _UnemployedNum = unemployedNum; }
    public int GetUnemployedNum() { return _UnemployedNum; }
    public void SetEmploymentNum(int employmentNum) { _EmploymentNum = employmentNum; }
    public int GetEmploymentNum() { return _EmploymentNum; }

    // ドローン //

    public int _PossessionDroneNum;         // 手持ちドローン数
    public int _TempingDroneNum;            // 派遣中ドローン数
    public int _ExtensionStage;             // 機能拡張段階

    public void SetPossessionDroneNum(int possessionDroneNum) { _PossessionDroneNum = possessionDroneNum; }
    public int GetPossessionDroneNum() { return _PossessionDroneNum; }
    public void SetTempingDroneNum(int tempingDroneNum) { _TempingDroneNum = tempingDroneNum; }
    public int GetTempingDroneNum() { return _TempingDroneNum; }
    public void SetExtensionStage(int extensionStage) { _ExtensionStage = extensionStage; }
    public int GetExtensionStage() { return _ExtensionStage; }

    // ターン //

    public int _TurnNum;       // ターン数

    public void SetTurnNum(int turnNum) { _TurnNum = turnNum; }
    public int GetTurnNum() { return _TurnNum; }

    // ミッション //

    private int _MissionState;       // ミッション段階
    public enum MissionRewards      // ミッション報酬
    {
        PutinChoice,    // 選択肢に入れる
        selected,       // 選択済み
        Unopened        // 未開放
    }

    public void SetMissionState(int missionState) { _MissionState = missionState; }
    public int GetMissionState() { return _MissionState; }

    // 国 //
    public struct Country
    {
        public int CountryNo;           // 国ナンバー
        public int AreaNo;              // 地域ナンバー
        public int UnemployedNum;       // 失業者数

        public int AreaLv;              // 地域レベル
        public int CumulativeNumber;    // クライアント累積要求数

        // 初期化
        public void SetInitCountry(int countryNo, int areaNo, int UnemuloyedNum , int areaLv, int cumulativeNumber)
        {
            CountryNo = countryNo;
            AreaNo = areaNo;
            UnemployedNum = UnemuloyedNum;
            AreaLv = areaLv;
            CumulativeNumber = cumulativeNumber;
        }
    }

    public Country[] countrys= new Country[11];

    // 生産者 //
    public struct Manufacturer
    {
        public int ManufacturerCountryNo;   // 国ナンバー
        public int ManufacturerAreaNo;      // 地域ナンバー
        public int ManufacturerNo;          // 生産者ナンバー
        public string ManufacturerName;     // 生産者名
        public int Products;                // 生産物

        public int Totalassets;             // 総資産
        public int AmountofSales;           // 売上高
        public int LaborForce;              // 労働力
        public int NumberofEmployees;       // 雇用人数
        public int BusinessPartnerClient;   // 取引先クライアント
        public int TransactionObject;       // 取引物
        public int RequestNum;              // 要求数
        public int Payment;                 // 支払い

        // 初期化
        public void SetInitManufacturer(int countryNo, int areaNo, int manuNo, string manuName, int products,
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

    public Manufacturer[] manufacturers = new Manufacturer[11];

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
    }

    // 取引物をenumで設定
}

