using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewClient_Onodera : MonoBehaviour
{
    DataBase database = null;
    ClientData clientdata = null;
    public int ClieCountry = 0;//クライアントの国 
    public int ClieArea = 0;//クライアントの地域　
    public int ClieNum = 0;
    public int ClieLv = 0;
    public int Clitable = -1;

    [SerializeField] GameObject Client;
    [SerializeField] GameObject Object;

    public AudioClip sound;
    AudioSource audioSource;

    private float timer = 0;
    private float interval = 0.3f;
    private float scaleRate = 0.2f;

    int Arealv;
    //int Clitable;
    bool cliapp = false;
    //private int appNum = -1;

    int g_num = 0;

    string Area;

    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientdata = Resources.Load<ClientData>("ClientData");
        Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
        //ClieLv = database.clients[Arealv].ClientLv;
         Clitable = -1;
        g_num = 0;
        Areamanager_Onodera.UpdataClim();

        cliapp = false;
        Client.SetActive(false);
        audioSource = GetComponent<AudioSource>();


        
    }

    void Update()
    {
        if (Clitable < 0)
        {

            int rand = 1;//Random.Range(0, 2);
            if(rand>=1)
            {
                /*
                for (int i = 0; i < 20; i++)
                {
                    int check;
                    check = database.ClientArrivalTables[Arealv].Client_Person[i];
                    if(check<=0)
                    {
                        database.ClientArrivalTables[Arealv].Client_Person[i] = 1;
                        Clitable = i;
                    }
                }
                */
                int check;
                check = Areamanager_Onodera.CheckClieNum(ClieCountry, ClieArea);
                Clitable = check;


                /*
                if(Areamanager_Onodera.GetArealv(ClieCountry, ClieArea)==0)
                {
                    Areamanager_Onodera.ClieNo1_1 += 1;
                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 1)
                {
                    Areamanager_Onodera.ClieNo1_2 += 1;
                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 2)
                {
                    Areamanager_Onodera.ClieNo1_3 += 1;
                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 3)
                {
                    Areamanager_Onodera.ClieNo2_1 += 1;

                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 4)
                {
                    Areamanager_Onodera.ClieNo2_2 += 1;
                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 5)
                {
                    Areamanager_Onodera.ClieNo2_3 += 1;
                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 6)
                {
                    Areamanager_Onodera.ClieNo3_1 += 1;
                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 7)
                {
                    Areamanager_Onodera.ClieNo3_2 += 1;
                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 8)
                {
                    Areamanager_Onodera.ClieNo4_1 += 1;

                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 9)
                {
                    Areamanager_Onodera.ClieNo4_2 += 1;

                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 10)
                {
                    Areamanager_Onodera.ClieNo4_3 += 1;

                }
                 if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 11)
                {
                    Areamanager_Onodera.ClieNo5_1 += 1;

                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 12)
                {
                    Areamanager_Onodera.ClieNo5_2 += 1;

                }
                if (Areamanager_Onodera.GetArealv(ClieCountry, ClieArea) == 13)
                {
                    Areamanager_Onodera.ClieNo5_3 += 1;

                }
                */
            }
        }


        if (Arealv == 0)
        {
            g_num = clientdata.CHN_Beijing_Clients[0].CHN_Beijing_Performance;
        }
        else if (Arealv == 1)
        {
            g_num = clientdata.CHN_Shanghai_Clients[0].CHN_Shanghai_Performance;
        }
        else if (Arealv == 2)
        {
            g_num = clientdata.CHN_Sichuan_Clients[0].CHN_Sichuan_Performance;
        }
        else if (Arealv == 3)
        {
            g_num = clientdata.USA_NewYork_Clients[0].USA_NewYork_Performance;
        }
        else if (Arealv == 4)
        {
            g_num = clientdata.USA_StLouis_Clients[0].USA_StLouis_Performance;
        }
        else if (Arealv == 5)
        {
            g_num = clientdata.USA_Atlanta_Clients[0].USA_Atlanta_Performance;
        }
        else if (Arealv == 6)
        {
            g_num = clientdata.RUS_Moscow_Clients[0].RUS_Moscow_Performance;
        }
        else if (Arealv == 7)
        {
            g_num = clientdata.RUS_Ufa_Clients[0].RUS_Ufa_Performance;
        }
        else if (Arealv == 8)
        {
            g_num = clientdata.AUS_Canberra_Clients[0].AUS_Canberra_Performance;
        }
        else if (Arealv == 9)
        {
            g_num = clientdata.AUS_Perth_Clients[0].AUS_Perth_Performance;
        }
        else if (Arealv == 10)
        {
            g_num = clientdata.AUS_Melbourne_Clients[0].AUS_Melbourne_Performance;
        }
        else if (Arealv == 11)
        {
            g_num = clientdata.ZAF_Pretoria_Clients[0].ZAF_Pretoria_Performance;
        }
        else if (Arealv == 12)
        {
            g_num = clientdata.ZAF_Bloemfontein_Clients[0].ZAF_Bloemfontein_Performance;
        }
        else if (Arealv == 13)
        {
            g_num = clientdata.ZAF_CapeTown_Clients[0].ZAF_CapeTown_Performance;
        }




        if (this.timer > 0)
        {
            this.timer -= Time.deltaTime;
            this.transform.localScale = (this.scaleRate * this.timer / this.interval) * Vector3.one;
        }

        if (Clitable == 0)//1人目のクライアント
        {
            Client.SetActive(true);
            cliapp = true;

        }
        else if (Clitable == 1)//2人目のクライアント
        {

            if (Arealv != 3 && Arealv != 5 && Arealv != 8 && Arealv != 13)
            {
                Client.SetActive(true);
                cliapp = true;
            }
            if (Arealv == 3 || Arealv == 13)
            {
               //int num = database.clients[Arealv].Performance;
                
                if (g_num >= 1000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 5 || Arealv == 8)
            {
       //         int num = database.clients[Arealv].Performance;
                if (g_num >= 500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

        }
        else if (Clitable == 2)//3人目のクライアント
        {

            if (Arealv != 2 && Arealv != 3 && Arealv != 4 && Arealv != 5 && Arealv != 7 && Arealv != 8 && Arealv != 9 && Arealv != 11 && Arealv != 13)
            {
                Client.SetActive(true); cliapp = true;
            }
            if (Arealv == 2 || Arealv == 5 || Arealv == 9)
            {
       //         int num = database.clients[Arealv].Performance;
                if (g_num >= 1000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 3 || Arealv == 13)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 2000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 4 || Arealv == 7 || Arealv == 8)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 1500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

        }


        else if (Clitable == 3)//4人目のクライアント
        {


            if (Arealv == 0 || Arealv == 5 || Arealv == 10)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 1500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
        //        int num = database.clients[Arealv].Performance;
                if (g_num >= 1000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 4 || Arealv == 9 || Arealv == 11)
            {
        //        int num = database.clients[Arealv].Performance;
                if (g_num >= 2000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 3 || Arealv == 13)
            {
             //   int num = database.clients[Arealv].Performance;
                if (g_num >= 3000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
        //        int num = database.clients[Arealv].Performance;
                if (g_num >= 2500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }


        }

        else if (Clitable == 4)//5人目のクライアント
        {

            if (Arealv == 0 || Arealv == 2 || Arealv == 9)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 3000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 3 || Arealv == 13 )
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 5 || Arealv == 6 || Arealv == 10)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 2000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 4)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 2500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 11 || Arealv == 12)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 3500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 5)//6人目のクライアント
        {

            if (Arealv == 0 || Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 4500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 4 || Arealv == 6)
            {
              //  int num = database.clients[Arealv].Performance;
                if (g_num >= 3000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2|| Arealv == 9)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 3 || Arealv == 11 || Arealv == 13)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 5 || Arealv == 10)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 2500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 6)//7人目のクライアント
        {

            if (Arealv == 0 || Arealv == 3 || Arealv == 13)
            {
       //         int num = database.clients[Arealv].Performance;
                if (g_num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
        //        int num = database.clients[Arealv].Performance;
                if (g_num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 4)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 3500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 5 || Arealv == 10)
            {
        //        int num = database.clients[Arealv].Performance;
                if (g_num >= 3000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
        //        int num = database.clients[Arealv].Performance;
                if (g_num >= 5500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 6500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 7)//8人目のクライアント
        {

            if (Arealv == 0 )
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 7500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 4)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if ( Arealv == 3 || Arealv == 13)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 3500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 8)//9人目のクライアント
        {

            if (Arealv == 0)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 4500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            
            if (Arealv == 5 || Arealv == 10)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 9500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 7500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 9)//10人目のクライアント
        {

            if (Arealv == 0)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 10500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 4500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 11000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 8500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 10)//11人目のクライアント
        {

            if (Arealv == 0)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 12000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 10000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 5500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 12500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 9500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 11)//12人目のクライアント
        {

            if (Arealv == 0)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 13500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 10000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 11000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 5500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 14000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 10500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 12)//13人目のクライアント
        {

            if (Arealv == 0)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 15000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 10000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 11000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 12000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 6500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 15500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 11500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 13)//14人目のクライアント
        {

            if (Arealv == 0)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 16500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 11000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 12000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 13000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 6500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 17000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 12500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }


        else if (Clitable == 14)//15人目のクライアント
        {

            if (Arealv == 0)
            {
         //       int num = database.clients[Arealv].Performance;
                if (g_num >= 18000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 12000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 13000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
             //   int num = database.clients[Arealv].Performance;
                if (g_num >= 14000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
              //  int num = database.clients[Arealv].Performance;
                if (g_num >= 7500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
              //  int num = database.clients[Arealv].Performance;
                if (g_num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
              //  int num = database.clients[Arealv].Performance;
                if (g_num >= 18500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 13500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }


        else if (Clitable == 15)//16人目のクライアント
        {

            if (Arealv == 0)
            {
             //   int num = database.clients[Arealv].Performance;
                if (g_num >= 19500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 13000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 14000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 15000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 7500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 20000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 14500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 16)//17人目のクライアント
        {

            if (Arealv == 0)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 21000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 14000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 15000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
              //  int num = database.clients[Arealv].Performance;
                if (g_num >= 16000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 8500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 21500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 15500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 17)//18人目のクライアント
        {

            if (Arealv == 0)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 22500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 15000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 16000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 17000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 8500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 23000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                //int num = database.clients[Arealv].Performance;
                if (g_num >= 16500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 18)//19人目のクライアント
        {

            if (Arealv == 0)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 24000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 16000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (g_num >= 17000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
              //  int num = database.clients[Arealv].Performance;
                if (g_num >= 18000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 9500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 24500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 17500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 19)//20人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (g_num >= 25500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (g_num >= 17000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (g_num >= 18000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 19000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
          //      int num = database.clients[Arealv].Performance;
                if (g_num >= 10000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
           //     int num = database.clients[Arealv].Performance;
                if (g_num >= 9500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
            //    int num = database.clients[Arealv].Performance;
                if (g_num >= 26000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
               // int num = database.clients[Arealv].Performance;
                if (g_num >= 18500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }





        /*
        if (ClieLv > Arealv)
        {
           // Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
            Client.SetActive(false);
          
        }
        else
        {
            Client.SetActive(true);
        }
        */


    }
    public void OnTriggerStay(Collider other)
    {
        int num = Areamanager_Onodera.CheckClieNum(ClieCountry, ClieArea, ClieNum);
        if (other.gameObject.CompareTag("Player"))
        {
            if (cliapp == true)
            {
                Area = "Ame_Atlanta";//SceneManager.GetActiveScene().name;
                database.SceneName = Area;

                int a = num;
                Object.SetActive(true);
                database.MiniClieNo = a;//ミニゲームシーンへクライアント情報を渡す
                if (Input.GetKey(KeyCode.Space))
                {


                    this.timer = this.interval;
                    audioSource.Play();
                    
                    Client.SetActive(true);
                    //SceneManager.LoadScene("minigame");
                    StartCoroutine("GoToGameScene");

                }
                
            }
        }
   
    }

    public void OnTriggerEnter(Collider other)
    {
        if (cliapp == true)
        {
            audioSource.PlayOneShot(sound);
        }
    }

    IEnumerator GoToGameScene()
    {
        yield return new WaitForSeconds(1.5f);
        Client.SetActive(true);
        SceneManager.LoadScene("minigame");
    }

    private void OnTriggerExit(Collider other)
    {

        Object.SetActive(false);

    }
}
