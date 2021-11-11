using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

// �e�X�g�N���X
public class DataBase : ScriptableObject
{
    //public int _count = 10;
    //public void SetCount(int count) { _count = count; }     // �Z�b�g
    //public int GetCount() { return _count; }                       // �Q�b�g

    // ���Ǝ� //

    public int _UnemployedNum;       // �o�^�������ƎҐ�
    public int _EmploymentNum;       // �ٗp��

    public void SetUnemployedNum(int unemployedNum) { _UnemployedNum = unemployedNum; }
    public int GetUnemployedNum() { return _UnemployedNum; }
    public void SetEmploymentNum(int employmentNum) { _EmploymentNum = employmentNum; }
    public int GetEmploymentNum() { return _EmploymentNum; }

    // �h���[�� //

    public int _PossessionDroneNum;         // �莝���h���[����
    public int _TempingDroneNum;            // �h�����h���[����
    public int _ExtensionStage;             // �@�\�g���i�K

    public void SetPossessionDroneNum(int possessionDroneNum) { _PossessionDroneNum = possessionDroneNum; }
    public int GetPossessionDroneNum() { return _PossessionDroneNum; }
    public void SetTempingDroneNum(int tempingDroneNum) { _TempingDroneNum = tempingDroneNum; }
    public int GetTempingDroneNum() { return _TempingDroneNum; }
    public void SetExtensionStage(int extensionStage) { _ExtensionStage = extensionStage; }
    public int GetExtensionStage() { return _ExtensionStage; }

    // �^�[�� //

    public int _TurnNum;       // �^�[����

    public void SetTurnNum(int turnNum) { _TurnNum = turnNum; }
    public int GetTurnNum() { return _TurnNum; }

    // �~�b�V���� //

    private int _MissionState;       // �~�b�V�����i�K
    public enum MissionRewards      // �~�b�V������V
    {
        PutinChoice,    // �I�����ɓ����
        selected,       // �I���ς�
        Unopened        // ���J��
    }

    public void SetMissionState(int missionState) { _MissionState = missionState; }
    public int GetMissionState() { return _MissionState; }

    // �� //
    public struct Country
    {
        public int CountryNo;           // ���i���o�[
        public int AreaNo;              // �n��i���o�[
        public int UnemployedNum;       // ���ƎҐ�

        public int AreaLv;              // �n�惌�x��
        public int CumulativeNumber;    // �N���C�A���g�ݐϗv����

        // ������
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

    // ���Y�� //
    public struct Manufacturer
    {
        public int ManufacturerCountryNo;   // ���i���o�[
        public int ManufacturerAreaNo;      // �n��i���o�[
        public int ManufacturerNo;          // ���Y�҃i���o�[
        public string ManufacturerName;     // ���Y�Җ�
        public int Products;                // ���Y��

        public int Totalassets;             // �����Y
        public int AmountofSales;           // ���㍂
        public int LaborForce;              // �J����
        public int NumberofEmployees;       // �ٗp�l��
        public int BusinessPartnerClient;   // �����N���C�A���g
        public int TransactionObject;       // �����
        public int RequestNum;              // �v����
        public int Payment;                 // �x����

        // ������
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

    // �N���C�A���g //
    public struct Client
    {
        public int ClientCountryNo;        // ���i���o�[
        public int ClientAreaNo;           // �n��i���o�[
        public int ClientNo;               // �N���C�A���g�i���o�[
        public string ClientName;          // �N���C�A���g�l�[��
        public int ClientLv;               // �N���C�A���g���x��
        public int ClientType;             // �Ɛу^�C�v
        public int[] Transactions;         // ����������i�����@�l�`�w�U�� �j

        public int Transaction;             //
        public int TransactionStatus;       
        public string ManufacturerName;     
        public int Performance;             // �Ɛ�
    }

    // �������enum�Őݒ�
}

