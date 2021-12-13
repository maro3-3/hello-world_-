using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[CreateAssetMenu]
public class DataBase : ScriptableObject
{

    // ���Ǝ� //
    public int UnemployedNum;       // �o�^�������ƎҐ�
    public int EmploymentNum;       // �ٗp��

    // �h���[�� //
    public int PossessionDroneNum;         // �莝���h���[����
    public int TempingDroneNum;            // �h�����h���[����
    public int ExtensionStage;             // �@�\�g���i�K

    // �^�[�� //
    public int TurnNum;       // �^�[����

    // �~�b�V���� //

    public int MissionState;       // �~�b�V�����i�K
    public enum MissionRewards      // �~�b�V������V
    {
        PutinChoice,    // �I�����ɓ����
        selected,       // �I���ς�
        Unopened        // ���J��
    }

    // �~�j�Q�[�� //
    public bool Win;
    public bool Lose;
    public int MiniClieNo; // �~�j�Q�[���Ώۂ̃N���C�A���g�i���o�[
    public int Amount; // �N���C�A���g�̎���z

    public int[] RewardLv = new int[12];               // �~�b�V�������x��
    public int[] EmploymentTarget = new int[12];       // �ڕW�ٗp��
    public int[] RewartContent = new int[12];          // ��V
    public int[] RewartState = new int[12];            // ��V�X�e�[�g


    // �� //
    public struct Country
    {
        public int CountryState;
        public int CountryNo;           // ���i���o�[
        public string CountryName;      // ���̖��O
        public int AreaNo;              // �n��i���o�[
        public string AreaName;         // �n��̖��O
        public int UnemployedNum;       // ���ƎҐ�

        public int AreaLv;              // �n�惌�x��
        public int CumulativeNumber;    // �N���C�A���g�ݐϗv����

        // �������֐�
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

    //  �n�惌�x�� //
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

    // ���Ǝ� //
    public struct Unemployed
    {
        public int UnemployedCountryNo;   // ���i���o�[
        public int UnemployedAreaNo;      // �n��i���o�[
        public int InitUnemployedNum;  // ���̒n��̎��ƎҐ�

        public int CurrentUnemployedNum;        //���̒n��̎��ƎҐ��i�����ҁj�@���X�g����
        public int EmploymentNum;               // ���̒n��̌ٗp��
        public int Faint_BreathNum;             //���̒n��̒��̑����@�O
        public int Death_tollNum;               //���̒n��̎��S�Ґ��@�O

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
    // ���Y�� //
    public struct Manufacturer
    {
        public int ManufacturerCountryNo;   // ���i���o�[
        public int ManufacturerAreaNo;      // �n��i���o�[
        public int ManufacturerNo;          // ���Y�҃i���o�[
        public string ManufacturerName;     // ���Y�Җ�
        public int Products;                // �����

        public int Totalassets;             // �����Y
        public int AmountofSales;           // ���㍂
        public int LaborForce;              // �J����
        public int NumberofEmployees;       // �ٗp�l��
        public int BusinessPartnerClient;   // �����N���C�A���g //�z��i�����l
        public int TransactionObject;       // �����
        public int RequestNum;              // �v����
        public int Payment;                 // �x����

        // �������֐�
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

       



        // �������֐�
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

    // �N���C�A���g�����e�[�u���H //
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

    // �~�j�Q�[�� //
    public bool Win;
    public bool Lose;
    public int MiniClieNo; // �~�j�Q�[���Ώۂ̃N���C�A���g�i���o�[
    public int Amount; // �N���C�A���g�̎���z
}