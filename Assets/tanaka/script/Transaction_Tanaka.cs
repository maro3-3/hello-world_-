using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
//取引
public class Transaction_Tanaka : MonoBehaviour
{
    DataBase database = null;
    ListManufacture ManuList;


    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        ManuList = Resources.Load("List_manufacturer") as ListManufacture;
    }

    // Update is called once per frame
    void Update()
    {
      
      
    }

    //月末に呼ばれる
    public void Transaction()//取引
    {
        //クライアントの合計要求数に足りていたら
        if (database.manufacturers[0].RequestNum <= database.manufacturers[0].LaborForce)
        {
            for (int i = 0; i < ManuList.sheets[0].list.Count; i++)//生産者全員分
            {
                int profit = 0;//利益

                //売り上げ-労働力＝利益
                profit = database.manufacturers[i].AmountofSales - database.manufacturers[i].LaborForce;

                database.manufacturers[i].Totalassets += profit;
            }
        }
    }
}
