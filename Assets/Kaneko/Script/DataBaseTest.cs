//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//[CreateAssetMenu]
//public class DataBaseTest : ScriptableObject
//{
//    public int[] _count = new int[10];


//    public void SetCount(int count , int index) { _count[index] = count; }     // �Z�b�g
//    public int GetCount(int index) { return _count[index]; }                   // �Q�b�g
//    public struct Manufacturer
//    {
//        public int CountryNo;               // ���i���o�[
//        public int AreaNo;                  // �n��i���o�[
//        public int ManufacturerNo;          // ���Y�҃i���o�[
//        public string ManufacturerName;     // ���Y�Җ�
//        public int Products;                // ���Y��

//        public int Totalassets;             // �����Y
//        public int AmountofSales;           // ���㍂
//        public int LaborForce;              // �J����
//        public int NumberofEmployees;       // �ٗp�l��
//        public int BusinessPartnerClient;   // �����N���C�A���g
//        public int TransactionObject;       // �����
//        public int RequestNum;              // �v����
//        public int Payment;                 // �x����

//        public void SetParam(int countryNo,int areaNo, int manuNo, string manuName, int products)
//        {
//            CountryNo = countryNo;
//            AreaNo = areaNo;
//            ManufacturerNo = manuNo;
//            ManufacturerName = manuName;
//            Products = products;
//        }
//    };

//    public Manufacturer[] manufacturers = new Manufacturer[11];
//   // public List<Manufacturer> manufacturers = new List<Manufacturer>(); 

//    //public struct ManufacturerInfo 
//    //{
//    //    public int Totalassets;     // �����Y
//    //    public int AmountofSales;   // ���㍂
//    //    public int LaborForce;      // �J����
//    //    public int NumberofEmployees;// �ٗp�l��
//    //    public int BusinessPartnerClient;// �����N���C�A���g
//    //    public int TransactionObject;   // �����
//    //    public int RequestNum;   // �v����
//    //    public int Payment;         // �x����
//    //};
//    //public Manufacturer[][][] manufacturerList = new Manufacturer(); 


//}