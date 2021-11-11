//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//[CreateAssetMenu]
//public class DataBaseTest : ScriptableObject
//{
//    public int[] _count = new int[10];


//    public void SetCount(int count , int index) { _count[index] = count; }     // セット
//    public int GetCount(int index) { return _count[index]; }                   // ゲット
//    public struct Manufacturer
//    {
//        public int CountryNo;               // 国ナンバー
//        public int AreaNo;                  // 地域ナンバー
//        public int ManufacturerNo;          // 生産者ナンバー
//        public string ManufacturerName;     // 生産者名
//        public int Products;                // 生産物

//        public int Totalassets;             // 総資産
//        public int AmountofSales;           // 売上高
//        public int LaborForce;              // 労働力
//        public int NumberofEmployees;       // 雇用人数
//        public int BusinessPartnerClient;   // 取引先クライアント
//        public int TransactionObject;       // 取引物
//        public int RequestNum;              // 要求数
//        public int Payment;                 // 支払い

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
//    //    public int Totalassets;     // 総資産
//    //    public int AmountofSales;   // 売上高
//    //    public int LaborForce;      // 労働力
//    //    public int NumberofEmployees;// 雇用人数
//    //    public int BusinessPartnerClient;// 取引先クライアント
//    //    public int TransactionObject;   // 取引物
//    //    public int RequestNum;   // 要求数
//    //    public int Payment;         // 支払い
//    //};
//    //public Manufacturer[][][] manufacturerList = new Manufacturer(); 


//}