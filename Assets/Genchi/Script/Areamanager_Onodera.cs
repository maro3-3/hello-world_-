using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Areamanager_Onodera : MonoBehaviour
{
    public static int Arealevel = 1;
    public static int Arealevel1_1 = 1;
    public static int Arealevel1_2 = 1;
    public static int Arealevel1_3 = 1;
    public static int Arealevel2_1 = 1;
    public static int Arealevel2_2 = 1;
    public static int Arealevel2_3 = 1;
    public static int Arealevel3_1 = 1;
    public static int Arealevel3_2 = 1;
    public static int Arealevel4_1 = 1;
    public static int Arealevel4_2 = 1;
    public static int Arealevel4_3 = 1;
    public static int Arealevel5_1 = 1;
    public static int Arealevel5_2 = 1;
    public static int Arealevel5_3 = 1;
    public static int GetArealv(int Country,int Area)
    {
        
        if(Country==1&& Area==1)
        {
            Arealevel = Arealevel1_1;
        }
        if (Country == 1 && Area == 2)
        {
            Arealevel = Arealevel1_2;
        }
        if (Country == 1 && Area == 3)
        {
            Arealevel = Arealevel1_3;
        }
        if (Country == 2 && Area == 1)
        {
            Arealevel = Arealevel2_1;
        }
        if (Country == 2 && Area == 2)
        {
            Arealevel = Arealevel2_2;
        }
        if (Country == 2 && Area == 3)
        {
            Arealevel = Arealevel2_3;
        }
        if (Country == 3 && Area == 1)
        {
            Arealevel = Arealevel3_1;
        }
        if (Country == 3 && Area == 2)
        {
            Arealevel = Arealevel3_2;
        }
        if (Country == 4 && Area == 1)
        {
            Arealevel = Arealevel4_1;
        }
        if (Country == 4 && Area == 2)
        {
            Arealevel = Arealevel4_2;
        }
        if (Country == 4 && Area == 3)
        {
            Arealevel = Arealevel4_3;
        }
        if (Country == 5 && Area == 1)
        {
            Arealevel = Arealevel5_1;
        }
        if (Country == 5 && Area == 2)
        {
            Arealevel = Arealevel5_2;
        }
        if (Country == 5 && Area == 3)
        {
            Arealevel = Arealevel5_3;
        }
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
