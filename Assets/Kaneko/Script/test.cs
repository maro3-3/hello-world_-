using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class test : MonoBehaviour
{
    [SerializeField] private Text text;
    DataBase database = null;
    ListManufacture ManuList;

    // Start is called before the first frame update
    void Start()
    {
        //Manufacturer _manufacturer = new Manufacturer() { Totalassets = null, Direction = new Vector2Int(0, 0), Exist = false };
        ManuList = Resources.Load("List_manufacturer") as ListManufacture;

        for(int i = 0;i< ManuList.sheets[0].list.Count;i++)
        {
            database.manufacturers[i].SetInitManufacturer(ManuList.sheets[0].list[i].int_CountryNo,
                                       ManuList.sheets[0].list[i].int_AreaNo,
                                       ManuList.sheets[0].list[i].int_ManufacturerNo,
                                       ManuList.sheets[0].list[i].string_ManufacturerName,
                                       ManuList.sheets[0].list[i].int_Products,
                                       0, 0, 0, 0, 0, 0, 0, 0);

        }

        //database._count[0] = 0;
        //database.SetCount(400, 0);
        //database.SetCount(4400, 1);
        text.text = database.manufacturers[5].ManufacturerName.ToString();

        //// �Z�b�^�[�g�p��
        //DataBase database = new DataBase();
        //database.GetSetProperty = 10;
        //Unemployed unemployed = new Unemployed();
        //unemployed.GetSetUnemployedNum = 30;

        //// �Q�b�^�[�g�p��
        //int a = database.GetSetProperty;
        //Debug.Log(a);
        //int b = unemployed.GetSetEmploymentNum;
        //Debug.Log(b);

        //// �~�b�V����enum�d�l�e�X�g
        //Mission mission = new Mission();
        //Mission.MissionRewards missionRewards = Mission.MissionRewards.selected;
        //Debug.Log(missionRewards);
    }

    void Awake()
    {
        // ScriptableObject�̎擾
        database = Resources.Load<DataBase>("DataBase");
    }
    // Update is called once per frame
    void Update()
    {
    }
}
