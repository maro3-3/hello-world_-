using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
//���
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

    //�^�[���I�����ɌĂ΂��
    public void Transaction()//���
    {
        
        for (int i = 0; i < ManuList.sheets[0].list.Count; i++)//���Y�ґS����
        {
            int profit = 0;//���v

            //����グ-�J���́����v
            profit = database.manufacturers[i].AmountofSales - database.manufacturers[i].LaborForce;

            database.manufacturers[i].Totalassets += profit;
        }
    }
}
