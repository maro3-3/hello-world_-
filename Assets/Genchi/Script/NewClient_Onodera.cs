using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewClient_Onodera : MonoBehaviour
{
    DataBase database = null;
    public int ClieCountry = 0;//�N���C�A���g�̍� 
    public int ClieArea = 0;//�N���C�A���g�̒n��@
    public int ClieNum = 0;
    public int ClieLv = 0;
   
    [SerializeField] GameObject Client;
    [SerializeField] GameObject Object;
    
   

    int Arealv, Clitable;

    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
        ClieLv = database.clients[Arealv].ClientLv;
        Clitable = -1;
       // for (int i = 0; i < 20; i++)
        //{
         //   database.ClientArrivalTables[Arealv].Client_Person[i] = 0;
        //}
        Client.SetActive(false);
    }

    void Update()
    {
        if (Clitable < 0)
        {
            int ran=Random.Range(0, 1);
            if(ran==1)
            {
                for (int i = 0; i < 20; i++)
                {
                    int check;
                    check = database.ClientArrivalTables[Arealv].Client_Person[i];
                    if(check==0)
                    {
                        database.ClientArrivalTables[Arealv].Client_Person[i] = 1;
                        Clitable = i;
                    }
                }
            }
        }


        if (Clitable == 0)//1�l�ڂ̃N���C�A���g
        {
            Client.SetActive(true);

        }
        else if (Clitable == 1)//2�l�ڂ̃N���C�A���g
        {

            if (Arealv != 3 && Arealv != 5 && Arealv != 8 && Arealv != 13)
            {
                Client.SetActive(true);
            }
            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 1000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 5 || Arealv == 8)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 500)
                {
                    Client.SetActive(true);
                }
            }

        }
        else if (Clitable == 2)//3�l�ڂ̃N���C�A���g
        {

            if (Arealv != 2 && Arealv != 3 && Arealv != 4 && Arealv != 5 && Arealv != 7 && Arealv != 8 && Arealv != 9 && Arealv != 11 && Arealv != 13)
            {
                Client.SetActive(true);
            }
            if (Arealv == 2 || Arealv == 5 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 1000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 4 || Arealv == 7 || Arealv == 8)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 1500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 500)
                {
                    Client.SetActive(true);
                }
            }

        }


        else if (Clitable == 3)//4�l�ڂ̃N���C�A���g
        {


            if (Arealv == 0 || Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 1500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 1000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 4 || Arealv == 9 || Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2500)
                {
                    Client.SetActive(true);
                }
            }


        }

        else if (Clitable == 4)//5�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0 || Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 3 || Arealv == 13 )
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 5 || Arealv == 6 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 11 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 5)//6�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0 || Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 4 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2|| Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 3 || Arealv == 11 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 2500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 6)//7�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0 || Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 7)//8�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0 )
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true);
                }
            }
            if ( Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 3500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 8)//9�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4500)
                {
                    Client.SetActive(true);
                }
            }
            
            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 9)//10�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 4500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 11000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 10)//11�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5500)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 11)//12�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 11000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 5500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 12)//13�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10000)
                {
                    Client.SetActive(true);
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
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6500)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 11500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 13)//14�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 11000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 6500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12500)
                {
                    Client.SetActive(true);
                }
            }
        }


        else if (Clitable == 14)//15�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 12000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7500)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13500)
                {
                    Client.SetActive(true);
                }
            }
        }


        else if (Clitable == 15)//16�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 19500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 13000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 7500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 20000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 16)//17�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 21000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 14000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8500)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 21500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 17)//18�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 22500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 15000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 8500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 23000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 18)//19�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 24000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 16000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9500)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 24500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17500)
                {
                    Client.SetActive(true);
                }
            }
        }

        else if (Clitable == 19)//20�l�ڂ̃N���C�A���g
        {

            if (Arealv == 0)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 25500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 1 || Arealv == 6)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 17000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 2 || Arealv == 9)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 3 || Arealv == 13)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 19000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 4)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 10000)
                {
                    Client.SetActive(true);
                }
            }

            if (Arealv == 5 || Arealv == 10)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 9500)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 11)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 26000)
                {
                    Client.SetActive(true);
                }
            }
            if (Arealv == 7 || Arealv == 8 || Arealv == 12)
            {
                int num = database.clients[Arealv].Performance;
                if (num >= 18500)
                {
                    Client.SetActive(true);
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
            Object.SetActive(true);

            if (Input.GetKey(KeyCode.Space))
            {
                database.MiniClieNo = database.clients[num].ClientNo;//�~�j�Q�[���V�[���փN���C�A���g����n��
                SceneManager.LoadScene("minigame");

            }
        }
   
    }
    private void OnTriggerExit(Collider other)
    {

        Object.SetActive(false);

    }
}
