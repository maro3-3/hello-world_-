using UnityEngine;

// �e�X�g�N���X
public class DataBase
{
    private int sample;

    //�v���p�e�B
    public int GetSetProperty
    {
        get { return sample; }
        set { sample = value; }
    }

}

// ���Ǝҏ󋵃N���X
public class Unemployed
{
    private int UnemployedNum;       // �o�^�������ƎҐ�
    private int EmploymentNum;       // �ٗp��

    //�v���p�e�B
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

// �h���[���N���X
public class Drone
{
    private int PossessionDroneNum;         // �莝���h���[����
    private int tempingDroneNum;            // �h�����h���[����
    private int ExtensionStage;             // �@�\�g���i�K

    //�v���p�e�B
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

// �^�[���N���X
public class Turn
{
    private int TurnNum;       // �^�[����

    //�v���p�e�B
    public int GetSetTurnNum
    {
        get { return TurnNum; }
        set { TurnNum = value; }
    }

}

// �~�b�V�����N���X
public class Mission
{
    private int MissionState;       // �~�b�V�����i�K
    public enum MissionRewards      // �~�b�V������V
    {
        PutinChoice,    // �I�����ɓ����
        selected,       // �I���ς�
        Unopened        // ���J��
    }

    //�v���p�e�B
    public int GetSetMissionState
    {
        get { return MissionState; }
        set { MissionState = value; }
    }
}

// ���N���X
public class Country
{
    private int CountryNo;          // 
    private int AreaNo;             // 
    private int UnemployedNum;      // 

    // �v���p�e�B
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

// ���Y�҃N���X
public class Manufacturer
{
    private int ManufacturerCountryNo;  // 
    private int ManufacturerAreaNo;     // 
    private int ManufacturerNo;         // 
    private int ManufacturerName;       // 
    private int Products;               // 

    // �v���p�e�B
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

// �N���C�A���g�N���X
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
