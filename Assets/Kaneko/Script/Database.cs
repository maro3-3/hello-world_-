using UnityEngine;

// テストクラス
public class DataBase
{
    private int sample;

    //プロパティ
    public int GetSetProperty
    {
        get { return sample; }
        set { sample = value; }
    }

}

// 失業者状況クラス
public class Unemployed
{
    private int UnemployedNum;       // 登録した失業者数
    private int EmploymentNum;       // 雇用数

    //プロパティ
    public int GetSetUnemployedNum
    {
        get { return UnemployedNum; }
        set { UnemployedNum = value; }
    }

    public int GetSetEmploymentNum
    {
        get { return EmploymentNum; }
        set { EmploymentNum = value; }
    }
}

// ドローンクラス
public class Drone
{
    private int PossessionDroneNum;         // 手持ちドローン数
    private int tempingDroneNum;            // 派遣中ドローン数
    private int ExtensionStage;             // 機能拡張段階

    //プロパティ
    public int GetSetPossessionDroneNum
    {
        get { return PossessionDroneNum; }
        set { PossessionDroneNum = value; }
    }
    public int GetSettempingDroneNum
    {
        get { return tempingDroneNum; }
        set { tempingDroneNum = value; }
    }
    public int GetSetExtensionStage
    {
        get { return ExtensionStage; }
        set { ExtensionStage = value; }
    }
}

// ターンクラス
public class Turn
{
    private int TurnNum;       // ターン数

    //プロパティ
    public int GetSetTurnNum
    {
        get { return TurnNum; }
        set { TurnNum = value; }
    }

}

// ミッションクラス
public class Mission
{
    private int MissionState;       // ミッション段階
    public enum MissionRewards      // ミッション報酬
    {
        PutinChoice,    // 選択肢に入れる
        selected,       // 選択済み
        Unopened        // 未開放
    }

    //プロパティ
    public int GetSetMissionState
    {
        get { return MissionState; }
        set { MissionState = value; }
    }
}

// 国クラス
public class Country
{
    private int CountryNo;          // 
    private int AreaNo;             // 
    private int UnemployedNum;      // 

    // プロパティ
    public int GetSetCountryNo
    {
        get { return CountryNo; }
        set { CountryNo = value; }
    }
    public int GetSetAreaNo
    {
        get { return AreaNo; }
        set { AreaNo = value; }
    }
    public int GetSetUnemployedNum
    {
        get { return UnemployedNum; }
        set { UnemployedNum = value; }
    }
}

// 生産者クラス
public class Manufacturer
{
    private int ManufacturerCountryNo;  // 
    private int ManufacturerAreaNo;     // 
    private int ManufacturerNo;         // 
    private int ManufacturerName;       // 
    private int Products;               // 

    // プロパティ
    public int GetSetManufacturerCountryNo
    {
        get { return ManufacturerCountryNo; }
        set { ManufacturerCountryNo = value; }
    }
    public int GetSetManufacturerAreaNo
    {
        get { return ManufacturerAreaNo; }
        set { ManufacturerAreaNo = value; }
    }
    public int GetSetManufacturerNo
    {
        get { return ManufacturerNo; }
        set { ManufacturerNo = value; }
    }
    public int GetSetManufacturerName
    {
        get { return ManufacturerName; }
        set { ManufacturerName = value; }
    }
    public int GetSetProducts
    {
        get { return Products; }
        set { Products = value; }
    }

}

// クライアントクラス
public class Client
{
    private int ClientCountryNo;        //
    private int ClientAreaNo;           //
    private int ClientNo;               //
    private string ClientName;          //
    private int ClientLv;               //
    private int ClientType;             //
    private int Transactions;       

    public int GetSetClientCountryNo
    {
        get { return ClientCountryNo; }
        set { ClientCountryNo = value; }
    }
    public int GetSetClientAreaNo
    {
        get { return ClientAreaNo; }
        set { ClientAreaNo = value; }
    }
    public int GetSetClientNo
    {
        get { return ClientNo; }
        set { ClientNo = value; }
    }
    public string GetSetClientName
    {
        get { return ClientName; }
        set { ClientName = value; }
    }
    public int GetSetClientLv
    {
        get { return ClientLv; }
        set { ClientLv = value; }
    }
    public int GetSetClientType
    {
        get { return ClientType; }
        set { ClientType = value; }
    }
    public int GetSetTransactions
    {
        get { return Transactions; }
        set { Transactions = value; }
    }
}
