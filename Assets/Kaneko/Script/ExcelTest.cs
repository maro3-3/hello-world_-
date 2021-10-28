using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
 
 
public class ExcelTest : MonoBehaviour
{

    Entity_Sheet1 es;

    // Use this for initialization
    void Start()
    {
        es = Resources.Load("test_Data") as Entity_Sheet1;

        Debug.Log(es.sheets[0].list[0].CountryNo);
        Debug.Log(es.sheets[0].list[0].AreaNo);
        Debug.Log(es.sheets[0].list[0].ManufacturerNo);
        Debug.Log(es.sheets[0].list.Count);

        es.sheets[0].list[0].CountryNo = 3;
        Debug.Log(es.sheets[0].list[0].CountryNo);

    }

    // Update is called once per frame
    void Update()
    {

    }


}