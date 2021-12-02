using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Areamanager_Onodera : MonoBehaviour
{
    public static int Arealevel = 1;
    public static int GetArealv()
    {
        return Arealevel;
    }

    //DataBase database = new DataBase();
   // Entity_Sheet1 es;
    // Start is called before the first frame update
    void Start()
    {
      //  es = Resources.Load("test_Data") as Entity_sheet1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Arealevel += 1;
        }
    }
}
