using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewProducer_Onodera : MonoBehaviour
{
    public int ProdCountry = 0;//ê∂éYé“ÇÃçë 
    public int ProdArea = 0;//ê∂éYé“ÇÃínàÊÅ@
    public int ProdNum = 0;
    public int ProdLv = 0;
    // Start is called before the first frame update
    [SerializeField] Text label1, label2, label3, label4;
    public int emp_count;
    private bool employees;
    [SerializeField] Text sousisan, uriage, roudouryoku, koyou;

    [SerializeField] GameObject Object;
    
    [SerializeField] GameObject Producer;
    [SerializeField] GameObject Object1;
    [SerializeField] GameObject Object2;
    [SerializeField] GameObject Object3;
    DataBase database = null;
 
    int oldturn = 0;

    int getArealv,Arealv, sisan = 0, uri = 0, roudou = 0, koyo = 0;
    int state = 1;
    bool app = false;

    void Start()
    {
        // DataBase database = new DataBase();
        database = Resources.Load<DataBase>("DataBase");
        getArealv = Areamanager_Onodera.GetArealv(ProdCountry, ProdArea);
        Arealv = database.countrys[getArealv].AreaLv;

        employees = false;
        emp_count = 5;
        UpdateCount();

        oldturn = database.TurnNum;
        app = false;
    }
    private void Update()
    {

       if (oldturn!=database.TurnNum)
        {
            if (state == 1)
            {
                oldturn = database.TurnNum;
                if (database.manufacturers[getArealv].AmountofSales < 500)
                {
                    state = 2;
                }
            }
            if (state == 2)
            {
                oldturn = database.TurnNum;
                if (database.manufacturers[getArealv].AmountofSales < 500)
                {
                    state = 3;
                    if (getArealv == 0)
                    {
                        Areamanager_Onodera.ProdNo1_1 -= 1;
                        if(Areamanager_Onodera.ProdNo1_1<=0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 1)
                    {
                        Areamanager_Onodera.ProdNo1_2 -= 1;
                        if (Areamanager_Onodera.ProdNo1_2 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 2)
                    {
                        Areamanager_Onodera.ProdNo1_3 -= 1;
                        if (Areamanager_Onodera.ProdNo1_3 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 3)
                    {
                        Areamanager_Onodera.ProdNo2_1 -= 1;
                        if (Areamanager_Onodera.ProdNo2_1 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 4)
                    {
                        Areamanager_Onodera.ProdNo2_2 -= 1;
                        if (Areamanager_Onodera.ProdNo2_2 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 5)
                    {
                        Areamanager_Onodera.ProdNo2_3 -= 1;
                        if (Areamanager_Onodera.ProdNo2_3 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 6)
                    {
                        Areamanager_Onodera.ProdNo3_1 -= 1;
                        if (Areamanager_Onodera.ProdNo3_1 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 7)
                    {
                        Areamanager_Onodera.ProdNo3_2 -= 1;
                        if (Areamanager_Onodera.ProdNo3_2 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 8)
                    {
                        Areamanager_Onodera.ProdNo4_1 -= 1;
                        if (Areamanager_Onodera.ProdNo4_1 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 9)
                    {
                        Areamanager_Onodera.ProdNo4_2 -= 1;
                        if (Areamanager_Onodera.ProdNo4_2 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 10)
                    {
                        Areamanager_Onodera.ProdNo4_3 -= 1;
                        if (Areamanager_Onodera.ProdNo4_3 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 11)
                    {
                        Areamanager_Onodera.ProdNo5_1 -= 1;
                        if (Areamanager_Onodera.ProdNo5_1 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 12)
                    {
                        Areamanager_Onodera.ProdNo5_2 -= 1;
                        if (Areamanager_Onodera.ProdNo5_2 <= 0)
                        {
                            Areamanager_Onodera.Gameover = true;
                        }

                    }
                    if (getArealv == 13)
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
                    state = 1;
                }
            }
        }

        if (ProdLv > Arealv)
        {
            Arealv = Areamanager_Onodera.GetArealv(ProdCountry, ProdArea);
            Producer.SetActive(false);
        }
        else
        {
            Producer.SetActive(true);
            if(app == false)
            {
                app = true;
                if(getArealv==0)
                {
                    Areamanager_Onodera.ProdNo1_1 += 1;

                }
                if (getArealv == 1)
                {
                    Areamanager_Onodera.ProdNo1_2 += 1;

                }
                if (getArealv == 2)
                {
                    Areamanager_Onodera.ProdNo1_3 += 1;

                }
                if (getArealv == 3)
                {
                    Areamanager_Onodera.ProdNo2_1 += 1;

                }
                if (getArealv == 4)
                {
                    Areamanager_Onodera.ProdNo2_2 += 1;

                }
                if (getArealv == 5)
                {
                    Areamanager_Onodera.ProdNo2_3 += 1;

                }
                if (getArealv == 6)
                {
                    Areamanager_Onodera.ProdNo3_1 += 1;

                }
                if (getArealv == 7)
                {
                    Areamanager_Onodera.ProdNo3_2 += 1;

                }
                if (getArealv == 8)
                {
                    Areamanager_Onodera.ProdNo4_1 += 1;

                }
                if (getArealv == 9)
                {
                    Areamanager_Onodera.ProdNo4_2 += 1;

                }
                if (getArealv == 10)
                {
                    Areamanager_Onodera.ProdNo4_3 += 1;

                }
                if (getArealv == 11)
                {
                    Areamanager_Onodera.ProdNo5_1 += 1;

                }
                if (getArealv == 12)
                {
                    Areamanager_Onodera.ProdNo5_2 += 1;

                }
                if (getArealv == 13)
                {
                    Areamanager_Onodera.ProdNo5_3 += 1;

                }
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        int num = Areamanager_Onodera.CheckProdNum(ProdCountry, ProdArea, ProdNum);
        sisan = database.manufacturers[num].Totalassets;
        uri = database.manufacturers[num].AmountofSales;
        roudou = database.manufacturers[num].LaborForce;
        koyo = database.manufacturers[num].NumberofEmployees;
        //sousisan, uriage, roudouryoku, koyou;
        
    }

    public void OnTriggerStay(Collider other)
    {
        int num = Areamanager_Onodera.CheckProdNum(ProdCountry, ProdArea, ProdNum);

        //if (other.gameObject == PLAYER)
        //{
        Object.SetActive(true);
        // }

        sousisan.text = "ëçéëéY:" + sisan;
        uriage.text = "îÑè„çÇ:" + uri;
        roudouryoku.text = "òJì≠óÕ:" + roudou;
        koyou.text = ""+koyo;

        if (employees == false)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                emp_count += 1;
                if (emp_count >= 100)
                    emp_count = 100;

            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                emp_count -= 1;
                if (emp_count <= 0)
                    emp_count = 0;

            }


            if (Input.GetKey(KeyCode.Space))
            {

                employees = true;
                label2.text = "";
                label3.text = "";
                label4.text = "";
                Employees();
                database.manufacturers[0].NumberofEmployees += emp_count;
            }
            UpdateCount();
        }
    }

   

    private void OnTriggerExit(Collider other)
    {
        Object.SetActive(false);
    }

    void UpdateCount()
    {
        if (emp_count <= 100)
        {

            label1.text = emp_count + "êl";
        }
    }

    public int Employees()
    {
        int number_employees = 0;
        number_employees = emp_count;
        return number_employees;
    }
}
