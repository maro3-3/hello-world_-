using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Producer_Onodera : MonoBehaviour
{
    [SerializeField] GameObject Producer;
    public int ProdCountry = 0;//生産者の国 
    public int ProdArea = 0;//生産者の地域　
    public int ProdNum = 0;
    public int ProdLv = 0;
    
    int Arealv;

    void Start()
    {

        Arealv = Areamanager_Onodera.GetArealv(ProdCountry, ProdArea);
    }

    void Update()
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
}
