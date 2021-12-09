using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
//æˆø
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

    //ƒ^[ƒ“I—¹‚ÉŒÄ‚Î‚ê‚é
    public void Transaction()//æˆø
    {
        
        for (int i = 0; i < ManuList.sheets[0].list.Count; i++)//¶YÒ‘Sˆõ•ª
        {
            int profit = 0;//—˜‰v

            //”„‚èã‚°-˜J“­—Í—˜‰v
            profit = database.manufacturers[i].AmountofSales - database.manufacturers[i].LaborForce;

            database.manufacturers[i].Totalassets += profit;
        }
    }
}
