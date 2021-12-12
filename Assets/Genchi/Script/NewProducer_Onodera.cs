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


    int Arealv, sisan = 0, uri = 0, roudou = 0, koyo = 0;

    void Start()
    {
        // DataBase database = new DataBase();
        database = Resources.Load<DataBase>("DataBase");
        Arealv = Areamanager_Onodera.GetArealv(ProdCountry, ProdArea);

        employees = false;
        emp_count = 5;
        UpdateCount();
    }
    private void Update()
    {

        if (ProdLv > Arealv)
        {
            Arealv = Areamanager_Onodera.GetArealv(ProdCountry, ProdArea);
            Producer.SetActive(false);
        }
        else
        {
            Producer.SetActive(true);
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
