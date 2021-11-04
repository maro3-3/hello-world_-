using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ManufacturerData : MonoBehaviour
{
    List_Manufacturer lm;

    // Start is called before the first frame update
    void Start()
    {
        lm = Resources.Load("List_manufacturer") as List_Manufacturer;

        Debug.Log("生産者がいる国：" + lm.sheets[0].list[0].int_CountryNo);
        Debug.Log("生産者がいる地域：" + lm.sheets[0].list[0].int_AreaNo);
        Debug.Log("生産者の地域ナンバー：" + lm.sheets[0].list[1].int_ManufacturerNo);
        Debug.Log("生産者名：" + lm.sheets[0].list[1].string_ManufacturerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
