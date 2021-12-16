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


    public static int ProdNo1_1 = 0;
    public static int ProdNo1_2 = 0;
    public static int ProdNo1_3 = 0;
    public static int ProdNo2_1 = 0;
    public static int ProdNo2_2 = 0;
    public static int ProdNo2_3 = 0;
    public static int ProdNo3_1 = 0;
    public static int ProdNo3_2 = 0;
    public static int ProdNo4_1 = 0;
    public static int ProdNo4_2 = 0;
    public static int ProdNo4_3 = 0;
    public static int ProdNo5_1 = 0;
    public static int ProdNo5_2 = 0;
    public static int ProdNo5_3 = 0;


    public static int ClieNo1_1 = 0;
    public static int ClieNo1_2 = 0;
    public static int ClieNo1_3 = 0;
    public static int ClieNo2_1 = 0;
    public static int ClieNo2_2 = 0;
    public static int ClieNo2_3 = 0;
    public static int ClieNo3_1 = 0;
    public static int ClieNo3_2 = 0;
    public static int ClieNo4_1 = 0;
    public static int ClieNo4_2 = 0;
    public static int ClieNo4_3 = 0;
    public static int ClieNo5_1 = 0;
    public static int ClieNo5_2 = 0;
    public static int ClieNo5_3 = 0;

    public static int[] Prodstate = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    public static int ProdStateNum = 0;

    public static int[] ProdSales = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public static bool[] ProdApp = {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false,false,false,false,false,false,false,false,false };
    public static bool Gameover = false;



    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        Prodstate[0] = 2;

    }

    public static int GetArealv(int Country, int Area)
    {

        if (Country == 1 && Area == 1)
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

    public static int GetProdState(int Country, int Area, int Num)
    {
        int prodstate = 0;

        if (Country == 1 && Area == 1 && Num == 1)
        {
            prodstate = 0;
            prodstate = Prodstate[prodstate];
        }
        if (Country == 1 && Area == 1 && Num == 2)
        {
            prodstate = 1; prodstate = Prodstate[prodstate];
        }

        if (Country == 1 && Area == 2 && Num == 1)
        {
            prodstate = 2; prodstate = Prodstate[prodstate];
        }
        if (Country == 1 && Area == 2 && Num == 2)
        {
            prodstate = 3; prodstate = Prodstate[prodstate];
        }

        if (Country == 1 && Area == 3 && Num == 1)
        {
            prodstate = 4; prodstate = Prodstate[prodstate];
        }
        if (Country == 1 && Area == 3 && Num == 2)
        {
            prodstate = 5; prodstate = Prodstate[prodstate];
        }
        if (Country == 1 && Area == 3 && Num == 3)
        {
            prodstate = 6; prodstate = Prodstate[prodstate];
        }
        if (Country == 1 && Area == 3 && Num == 4)
        {
            prodstate = 7; prodstate = Prodstate[prodstate];
        }
        if (Country == 1 && Area == 3 && Num == 5)
        {
            prodstate = 8; prodstate = Prodstate[prodstate];
        }
        if (Country == 2 && Area == 1 && Num == 1)
        {
            prodstate = 9; prodstate = Prodstate[prodstate];
        }
        if (Country == 2 && Area == 1 && Num == 2)
        {
            prodstate = 10; prodstate = Prodstate[prodstate];
        }

        if (Country == 2 && Area == 2 && Num == 1)
        {
            prodstate = 11; prodstate = Prodstate[prodstate];
        }
        if (Country == 2 && Area == 2 && Num == 2)
        {
            prodstate = 12; prodstate = Prodstate[prodstate];
        }
        if (Country == 2 && Area == 2 && Num == 3)
        {
            prodstate = 13; prodstate = Prodstate[prodstate];
        }
        if (Country == 2 && Area == 3 && Num == 1)
        {
            prodstate = 14; prodstate = Prodstate[prodstate];
        }
        if (Country == 2 && Area == 3 && Num == 2)
        {
            prodstate = 15; prodstate = Prodstate[prodstate];
        }
        if (Country == 2 && Area == 3 && Num == 3)
        {
            prodstate = 16; prodstate = Prodstate[prodstate];
        }
        if (Country == 2 && Area == 3 && Num == 4)
        {
            prodstate = 17; prodstate = Prodstate[prodstate];
        }
        if (Country == 3 && Area == 1 && Num == 1)
        {
            prodstate = 18; prodstate = Prodstate[prodstate];
        }
        if (Country == 3 && Area == 1 && Num == 2)
        {
            prodstate = 19; prodstate = Prodstate[prodstate];
        }
        if (Country == 3 && Area == 2 && Num == 1)
        {
            prodstate = 20; prodstate = Prodstate[prodstate];
        }
        if (Country == 3 && Area == 2 && Num == 2)
        {
            prodstate = 21; prodstate = Prodstate[prodstate];
        }
        if (Country == 3 && Area == 2 && Num == 3)
        {
            prodstate = 22; prodstate = Prodstate[prodstate];
        }
        if (Country == 3 && Area == 2 && Num == 4)
        {
            prodstate = 23; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 1 && Num == 1)
        {
            prodstate = 24; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 1 && Num == 2)
        {
            prodstate = 25; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 1 && Num == 3)
        {
            prodstate = 26; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 1 && Num == 4)
        {
            prodstate = 27; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 2 && Num == 1)
        {
            prodstate = 28; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 2 && Num == 2)
        {
            prodstate = 29; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 2 && Num == 3)
        {
            prodstate = 30; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 3 && Num == 1)
        {
            prodstate = 31; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 3 && Num == 2)
        {
            prodstate = 32; prodstate = Prodstate[prodstate];
        }
        if (Country == 4 && Area == 3 && Num == 3)
        {
            prodstate = 33; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 1 && Num == 1)
        {
            prodstate = 34; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 1 && Num == 2)
        {
            prodstate = 35; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 1 && Num == 3)
        {
            prodstate = 36; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 2 && Num == 1)
        {
            prodstate = 37; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 2 && Num == 2)
        {
            prodstate = 38; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 2 && Num == 3)
        {
            prodstate = 39; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 2 && Num == 4)
        {
            prodstate = 40; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 3 && Num == 1)
        {
            prodstate = 41; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 3 && Num == 2)
        {
            prodstate = 42; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 3 && Num == 3)
        {
            prodstate = 43; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 3 && Num == 4)
        {
            prodstate = 44; prodstate = Prodstate[prodstate];
        }
        if (Country == 5 && Area == 3 && Num == 5)
        {
            prodstate = 45; prodstate = Prodstate[prodstate];
        }
        return prodstate;
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
        if (Country == 2 && Area == 1 && Num == 2)
        {
            ProdNum = 10;
        }

        if (Country == 2 && Area == 2 && Num == 1)
        {
            ProdNum = 11;
        }
        if (Country == 2 && Area == 2 && Num == 2)
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


    public static int CheckClieNum(int Country, int Area)
    {
        int ClieNum = 0;
        if (Country == 1 && Area == 1)
        {
            ClieNum = ClieNo1_1;
            ClieNo1_1 += 1;
        }
        if (Country == 1 && Area == 2)
        {
            ClieNum = ClieNo1_2;
            ClieNo1_2 += 1;
        }
        if (Country == 1 && Area == 3)
        {
            ClieNum = ClieNo1_3;
            ClieNo1_3 += 1;
        }
        if (Country == 2 && Area == 1)
        {
            ClieNum = ClieNo2_1;
            ClieNo2_1 += 1;
        }
        if (Country == 2 && Area == 2)
        {
            ClieNum = ClieNo2_2;
            ClieNo2_2 += 1;

        }
        if (Country == 2 && Area == 3)
        {
            ClieNum = ClieNo2_3;
            ClieNo2_3 += 1;
        }
        if (Country == 3 && Area == 1)
        {
            ClieNum = ClieNo3_1;
            ClieNo3_1 += 1;
        }
        if (Country == 3 && Area == 2)
        {
            ClieNum = ClieNo3_2;
            ClieNo3_2 += 1;
        }
        if (Country == 4 && Area == 1)
        {
            ClieNum = ClieNo4_1;
            ClieNo4_1 += 1;
        }
        if (Country == 4 && Area == 2)
        {
            ClieNum = ClieNo4_2;
            ClieNo4_2 += 1;
        }
        if (Country == 4 && Area == 3)
        {
            ClieNum = ClieNo4_3;
            ClieNo4_3 += 1;
        }
        if (Country == 5 && Area == 1)
        {
            ClieNum = ClieNo5_1;
            ClieNo5_1 += 1;
        }
        if (Country == 5 && Area == 2)
        {
            ClieNum = ClieNo5_2;
            ClieNo5_2 += 1;
        }
        if (Country == 5 && Area == 3)
        {
            ClieNum = ClieNo5_3;
            ClieNo5_3 += 1;
        }
        return ClieNum;
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


    //èâä˙âª
    public static void InitGenchi()
    {
        ProdNo1_1 = 0;
        ProdNo1_2 = 0;
        ProdNo1_3 = 0;
        ProdNo2_1 = 0;
        ProdNo2_2 = 0;
        ProdNo2_3 = 0;
        ProdNo3_1 = 0;
        ProdNo3_2 = 0;
        ProdNo4_1 = 0;
        ProdNo4_2 = 0;
        ProdNo4_3 = 0;
        ProdNo5_1 = 0;
        ProdNo5_2 = 0;
        ProdNo5_3 = 0;

        ClieNo1_1 = 0;
        ClieNo1_2 = 0;
        ClieNo1_3 = 0;
        ClieNo2_1 = 0;
        ClieNo2_2 = 0;
        ClieNo2_3 = 0;
        ClieNo3_1 = 0;
        ClieNo3_2 = 0;
        ClieNo4_1 = 0;
        ClieNo4_2 = 0;
        ClieNo4_3 = 0;
        ClieNo5_1 = 0;
        ClieNo5_2 = 0;
        ClieNo5_3 = 0;
        int[] Prodstate = { 1 };


        //NewProducer_Onodera.state = 1;

        Gameover = false;
    }

    public static void UpdataClim()
    {
        ClieNo1_1 = 0;
        ClieNo1_2 = 0;
        ClieNo1_3 = 0;
        ClieNo2_1 = 0;
        ClieNo2_2 = 0;
        ClieNo2_3 = 0;
        ClieNo3_1 = 0;
        ClieNo3_2 = 0;
        ClieNo4_1 = 0;
        ClieNo4_2 = 0;
        ClieNo4_3 = 0;
        ClieNo5_1 = 0;
        ClieNo5_2 = 0;
        ClieNo5_3 = 0;
    }


    public static void SurviveCheck()
    {
        for (int i = 0; i < 46; i++)
        {
            if(ProdApp[i]==true)
            {


                if (Prodstate[i] == 1)
                {

                    if (ProdSales[i] < 500)
                    {
                        Prodstate[i] = 2;


                    }
                }
                else if (Prodstate[i] == 2)
                {

                    if (ProdSales[i] < 500)
                    {
                        Prodstate[i] = 3;
                        if (i == 0 || i == 1)
                        {
                            ProdNo1_1 -= 1;
                            if (ProdNo1_1 <= 0)
                            {
                                Gameover = true;
                            }

                        }
                        if (i == 2 || i == 3)
                        {
                            Areamanager_Onodera.ProdNo1_2 -= 1;
                            if (Areamanager_Onodera.ProdNo1_2 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 4 || i == 5 || i == 6 || i == 7 || i == 8)
                        {
                            Areamanager_Onodera.ProdNo1_3 -= 1;
                            if (Areamanager_Onodera.ProdNo1_3 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 9 || i == 10)
                        {
                            Areamanager_Onodera.ProdNo2_1 -= 1;
                            if (Areamanager_Onodera.ProdNo2_1 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 11 || i == 12 || i == 13)
                        {
                            Areamanager_Onodera.ProdNo2_2 -= 1;
                            if (Areamanager_Onodera.ProdNo2_2 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 14 || i == 15 || i == 16 || i == 17)
                        {
                            Areamanager_Onodera.ProdNo2_3 -= 1;
                            if (Areamanager_Onodera.ProdNo2_3 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 18 || i == 19)
                        {
                            Areamanager_Onodera.ProdNo3_1 -= 1;
                            if (Areamanager_Onodera.ProdNo3_1 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 20 || i == 21 || i == 22 || i == 23)
                        {
                            Areamanager_Onodera.ProdNo3_2 -= 1;
                            if (Areamanager_Onodera.ProdNo3_2 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 24 || i == 25 || i == 26 || i == 27)
                        {
                            Areamanager_Onodera.ProdNo4_1 -= 1;
                            if (Areamanager_Onodera.ProdNo4_1 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 28 || i == 29 || i == 30)
                        {
                            Areamanager_Onodera.ProdNo4_2 -= 1;
                            if (Areamanager_Onodera.ProdNo4_2 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 31 || i == 32 || i == 33)
                        {
                            Areamanager_Onodera.ProdNo4_3 -= 1;
                            if (Areamanager_Onodera.ProdNo4_3 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 34 || i == 35 || i == 36)
                        {
                            Areamanager_Onodera.ProdNo5_1 -= 1;
                            if (Areamanager_Onodera.ProdNo5_1 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 37 || i == 38 || i == 39 || i == 40)
                        {
                            Areamanager_Onodera.ProdNo5_2 -= 1;
                            if (Areamanager_Onodera.ProdNo5_2 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                        if (i == 41 || i == 42 || i == 43 || i == 44 || i == 45)
                        {
                            Areamanager_Onodera.ProdNo5_3 -= 1;
                            if (Areamanager_Onodera.ProdNo5_3 <= 0)
                            {
                                Areamanager_Onodera.Gameover = true;
                            }

                        }
                    }
                    else
                    {
                        Prodstate[i] = 1;

                    }
                }
            }
        }
    }

    public int get(int i)
    {
        int k = 0;

        k = database.manufacturers[i].AmountofSales;
        return k;
    }

   

    }
