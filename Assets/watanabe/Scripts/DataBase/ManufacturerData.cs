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

        Debug.Log("���Y�҂����鍑�F" + lm.sheets[0].list[0].int_CountryNo);
        Debug.Log("���Y�҂�����n��F" + lm.sheets[0].list[0].int_AreaNo);
        Debug.Log("���Y�҂̒n��i���o�[�F" + lm.sheets[0].list[1].int_ManufacturerNo);
        Debug.Log("���Y�Җ��F" + lm.sheets[0].list[1].string_ManufacturerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
