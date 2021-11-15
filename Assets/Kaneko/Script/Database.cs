using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    // �� //
    public struct Country
    {
        public int CountryNo;           // ���i���o�[
        public int AreaNo;              // �n��i���o�[
        public int UnemployedNum;       // ���ƎҐ�

        public int AreaLv;              // �n�惌�x��
        public int CumulativeNumber;    // �N���C�A���g�ݐϗv����

        // ������
        public void InitCountry(int countryNo, int areaNo, int UnemuloyedNum , int areaLv, int cumulativeNumber)
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


        // ������
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


    // �������enum�Őݒ�
    enum a
    {

    }
}
