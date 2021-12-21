using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewClient_Onodera : MonoBehaviour
{
    DataBase database = null;
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

    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
        //ClieLv = database.clients[Arealv].ClientLv;
         Clitable = -1;

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
                int num = database.clients[Arealv].Performance;
                if (num >= 1000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 5 || Arealv == 8)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 500)
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
                int num = database.clients[Arealv].Performance;
                if (num >= 1000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 4 || Arealv == 7 || Arealv == 8)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 1500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

        }


        else if (Clitable == 3)//4人目のクライアント
        {


            if (Arealv == 0 || Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 1500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 1000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 4 || Arealv == 9 || Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }


        }

        else if (Clitable == 4)//5人目のクライアント
        {

            if (Arealv == 0 || Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 3 || Arealv == 13 )
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 5 || Arealv == 6 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 11 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 5)//6人目のクライアント
        {

            if (Arealv == 0 || Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 4 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2|| Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 3 || Arealv == 11 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 6)//7人目のクライアント
        {

            if (Arealv == 0 || Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 7)//8人目のクライアント
        {

            if (Arealv == 0 )
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if ( Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 8)//9人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            
            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 9)//10人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 11000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 10)//11人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 11)//12人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 11000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 12)//13人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 11000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 11500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 13)//14人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 11000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }


        else if (Clitable == 14)//15人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }


        else if (Clitable == 15)//16人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 19500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 20000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 16)//17人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 21000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 21500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 17)//18人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 22500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 23000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
        }

        else if (Clitable == 18)//19人目のクライアント
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 24000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 24500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17500)
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
                if (num >= 25500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 19000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9500)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 26000)
                {
                    Client.SetActive(true); cliapp = true;
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18500)
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
