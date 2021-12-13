using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Areamanager_Onodera : MonoBehaviour
{
    DataBase database = null;
    public static int Arealevel = 1;
    public static int Arealevel1_1 = 0;
    public static int Arealevel1_2 = 1;
    public static int Arealevel1_3 = 2;
    public static int Arealevel2_1 = 3;
    public static int Arealevel2_2 = 4;
    public static int Arealevel2_3 = 5;
    public static int Arealevel3_1 = 6;
    public static int Arealevel3_2 = 7;
    public static int Arealevel4_1 = 8;
    public static int Arealevel4_2 = 9;
    public static int Arealevel4_3 = 10;
    public static int Arealevel5_1 = 11;
    public static int Arealevel5_2 = 12;
    public static int Arealevel5_3 = 13;



    public static int CliMana = 1;
    public static int CliMana1_1 = 0;
    public static int CliMana1_2 = 0;
    public static int CliMana1_3 = 0;
    public static int CliMana2_1 = 0;
    public static int CliMana2_2 = 0;
    public static int CliMana2_3 = 0;
    public static int CliMana3_1 = 0;
    public static int CliMana3_2 = 0;
    public static int CliMana4_1 = 0;
    public static int CliMana4_2 = 0;
    public static int CliMana4_3 = 0;
    public static int CliMana5_1 = 0;
    public static int CliMana5_2 = 0;
    public static int CliMana5_3 = 0;

    public static bool CliApp1_1 = true;
    public static bool CliApp1_2 = true;
    public static bool CliApp1_3 = true;
    public static bool CliApp2_1 = true;
    public static bool CliApp2_2 = true;
    public static bool CliApp2_3 = true;
    public static bool CliApp3_1 = true;
    public static bool CliApp3_2 = true;
    public static bool CliApp4_1 = true;
    public static bool CliApp4_2 = true;
    public static bool CliApp4_3 = true;
    public static bool CliApp5_1 = true;
    public static bool CliApp5_2 = true;
    public static bool CliApp5_3 = true;

    int CliTable;

    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        CliTable = 0;
    }

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

    public static int CheckProdNum(int Country, int Area, int Num)
    {
        int ProdNum = 0;
        if (Country == 1 && Area == 1 && Num == 1)
        {
            ProdNum = 0;
        }
        if (Country == 1 && Area == 1 && Num == 2)
        {
            ProdNum = 1;
        }
       
        if (Country == 1 && Area == 2 && Num == 1)
        {
            ProdNum = 2;
        }
        if (Country == 1 && Area == 2 && Num == 2)
        {
            ProdNum = 3;
        }
        
        if (Country == 1 && Area == 3 && Num == 1)
        {
            ProdNum = 4;
        }
        if (Country == 1 && Area == 3 && Num == 2)
        {
            ProdNum = 5;
        }
        if (Country == 1 && Area == 3 && Num == 3)
        {
            ProdNum = 6;
        }
        if (Country == 1 && Area == 3 && Num == 4)
        {
            ProdNum = 7;
        }
        if (Country == 1 && Area == 3 && Num == 5)
        {
            ProdNum = 8;
        }
        if (Country == 2 && Area == 1 && Num == 1)
        {
            ProdNum = 9;
        }
        if (Country == 2 && Area == 1 && Num ==2 )
        {
            ProdNum = 10;
        }
        
        if (Country == 2 && Area == 2 && Num == 1)
        {
            ProdNum = 11;
        }
        if (Country == 2 && Area == 2 && Num ==2 )
        {
            ProdNum = 12;
        }
        if (Country == 2 && Area == 2 && Num == 3)
        {
            ProdNum = 13;
        }
        if (Country == 2 && Area == 3 && Num == 1)
        {
            ProdNum = 14;
        }
        if (Country == 2 && Area == 3 && Num == 2)
        {
            ProdNum = 15;
        }
        if (Country == 2 && Area == 3 && Num == 3)
        {
            ProdNum = 16;
        }
        if (Country == 2 && Area == 3 && Num == 4)
        {
            ProdNum = 17;
        }
        if (Country == 3 && Area == 1 && Num == 1)
        {
            ProdNum = 18;
        }
        if (Country == 3 && Area == 1 && Num == 2)
        {
            ProdNum = 19;
        }
        if (Country == 3 && Area == 2 && Num == 1)
        {
            ProdNum = 20;
        }
        if (Country == 3 && Area == 2 && Num == 2)
        {
            ProdNum = 21;
        }
        if (Country == 3 && Area == 2 && Num == 3)
        {
            ProdNum = 22;
        }
        if (Country == 3 && Area == 2 && Num == 4)
        {
            ProdNum = 23;
        }
        if (Country == 4 && Area == 1 && Num == 1)
        {
            ProdNum = 24;
        }
        if (Country == 4 && Area == 1 && Num == 2)
        {
            ProdNum = 25;
        }
        if (Country == 4 && Area == 1 && Num == 3)
        {
            ProdNum = 26;
        }
        if (Country == 4 && Area == 1 && Num == 4)
        {
            ProdNum = 27;
        }
        if (Country == 4 && Area == 2 && Num == 1)
        {
            ProdNum = 28;
        }
        if (Country == 4 && Area == 2 && Num == 2)
        {
            ProdNum = 29;
        }
        if (Country == 4 && Area == 2 && Num == 3)
        {
            ProdNum = 30;
        }
        if (Country == 4 && Area == 3 && Num == 1)
        {
            ProdNum = 31;
        }
        if (Country == 4 && Area == 3 && Num == 2)
        {
            ProdNum = 32;
        }
        if (Country == 4 && Area == 3 && Num == 3)
        {
            ProdNum = 33;
        }
        if (Country == 5 && Area == 1 && Num == 1)
        {
            ProdNum = 34;
        }
        if (Country == 5 && Area == 1 && Num == 2)
        {
            ProdNum = 35;
        }
        if (Country == 5 && Area == 1 && Num == 3)
        {
            ProdNum = 36;
        }
        if (Country == 5 && Area == 2 && Num == 1)
        {
            ProdNum = 37;
        }
        if (Country == 5 && Area == 2 && Num == 2)
        {
            ProdNum = 38;
        }
        if (Country == 5 && Area == 2 && Num == 3)
        {
            ProdNum = 39;
        }
        if (Country == 5 && Area == 2 && Num == 4)
        {
            ProdNum = 40;
        }
        if (Country == 5 && Area == 3 && Num == 1)
        {
            ProdNum = 41;
        }
        if (Country == 5 && Area == 3 && Num == 2)
        {
            ProdNum = 42;
        }
        if (Country == 5 && Area == 3 && Num == 3)
        {
            ProdNum = 43;
        }
        if (Country == 5 && Area == 3 && Num == 4)
        {
            ProdNum = 44;
        }
        if (Country == 5 && Area == 3 && Num == 5)
        {
            ProdNum = 45;
        }

        return ProdNum;
    }


    public static int CheckClieNum(int Country, int Area, int Num)
    {
        int ClieNum = 0;
        if (Country == 1 && Area == 1 && Num == 1)
        {
            ClieNum = 0;
        }
        if (Country == 1 && Area == 1 && Num == 2)
        {
            ClieNum = 1;
        }

        if (Country == 1 && Area == 2 && Num == 3)
        {
            ClieNum = 2;
        }
        if (Country == 1 && Area == 2 && Num == 4)
        {
            ClieNum = 3;
        }

        if (Country == 1 && Area == 2 && Num == 5)
        {
            ClieNum = 4;
        }
        if (Country == 1 && Area == 3 && Num == 6)
        {
            ClieNum = 5;
        }
        if (Country == 1 && Area == 3 && Num == 7)
        {
            ClieNum = 6;
        }
        if (Country == 1 && Area == 3 && Num == 8)
        {
            ClieNum = 7;
        }
        if (Country == 1 && Area == 3 && Num == 9)
        {
            ClieNum = 8;
        }
        if (Country == 2 && Area == 1 && Num == 1)
        {
            ClieNum = 9;
        }
        if (Country == 2 && Area == 1 && Num == 2)
        {
            ClieNum = 10;
        }

        if (Country == 2 && Area == 2 && Num == 1)
        {
            ClieNum = 11;
        }
        if (Country == 2 && Area == 2 && Num == 2)
        {
            ClieNum = 12;
        }
        if (Country == 2 && Area == 2 && Num == 3)
        {
            ClieNum = 13;
        }
        if (Country == 2 && Area == 3 && Num == 1)
        {
            ClieNum = 14;
        }
        if (Country == 2 && Area == 3 && Num == 2)
        {
            ClieNum = 15;
        }
        if (Country == 3 && Area == 1 && Num == 1)
        {
            ClieNum = 16;
        }
        if (Country == 3 && Area == 1 && Num == 2)
        {
            ClieNum = 17;
        }
        if (Country == 3 && Area == 1 && Num == 3)
        {
            ClieNum = 18;
        }
        if (Country == 3 && Area == 1 && Num == 4)
        {
            ClieNum = 19;
        }
        if (Country == 3 && Area == 2 && Num == 1)
        {
            ClieNum = 20;
        }
        if (Country == 3 && Area == 2 && Num == 2)
        {
            ClieNum = 21;
        }
        if (Country == 3 && Area == 2 && Num == 3)
        {
            ClieNum = 22;
        }
        if (Country == 4 && Area == 1 && Num == 1)
        {
            ClieNum = 23;
        }
        if (Country == 4 && Area == 1 && Num == 2)
        {
            ClieNum = 24;
        }
        if (Country == 4 && Area == 1 && Num == 3)
        {
            ClieNum = 25;
        }
        if (Country == 4 && Area == 2 && Num == 1)
        {
            ClieNum = 26;
        }
        if (Country == 4 && Area == 2 && Num == 2)
        {
            ClieNum = 27;
        }
        if (Country == 4 && Area == 2 && Num == 3)
        {
            ClieNum = 28;
        }
        if (Country == 4 && Area == 3 && Num == 1)
        {
            ClieNum = 29;
        }
        if (Country == 4 && Area == 3 && Num == 2)
        {
            ClieNum = 30;
        }
        if (Country == 4 && Area == 3 && Num == 3)
        {
            ClieNum = 31;
        }
        if (Country == 5 && Area == 1 && Num == 1)
        {
            ClieNum = 32;
        }
        if (Country == 5 && Area == 1 && Num == 2)
        {
            ClieNum = 33;
        }
        if (Country == 5 && Area == 1 && Num == 3)
        {
            ClieNum = 34;
        }
        if (Country == 5 && Area == 2 && Num == 1)
        {
            ClieNum = 35;
        }
        if (Country == 5 && Area == 2 && Num == 2)
        {
            ClieNum = 36;
        }
        if (Country == 5 && Area == 3 && Num == 1)
        {
            ClieNum = 37;
        }
        if (Country == 5 && Area == 3 && Num == 2)
        {
            ClieNum = 38;
        }
        if (Country == 5 && Area == 3 && Num == 3)
        {
            ClieNum = 39;
        }
        

        return ClieNum;
    }

    //DataBase database = new DataBase();
    // Entity_Sheet1 es;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    Arealevel += 1;
       // }
    }
}
