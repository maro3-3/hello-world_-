using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class U_CHN_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;
    void Awake()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");
    }

    // ¸‹ÆÒ
    [SerializeField] private Text CHN_Beijing_AreaLv;                             // ’†‘–k‹’nˆæƒŒƒxƒ‹
    [SerializeField] private Text CHN_Shanghai_AreaLv;                            // ’†‘ãŠC’nˆæƒŒƒxƒ‹
    [SerializeField] private Text CHN_Sichuan_AreaLv;                             // ’†‘lì’nˆæƒŒƒxƒ‹

    [SerializeField] private Text CHN_Beijing_EmploymentNum;                      // ’†‘–k‹ŒÙ—p”
    [SerializeField] private Text CHN_Shanghai_EmploymentNum;                     // ’†‘ãŠCŒÙ—p”
    [SerializeField] private Text CHN_Sichuan_EmploymentNum;                      // ’†‘lìŒÙ—p”

    [SerializeField] private Text[] CHN_Beijing_TotalUnemployedNum = new Text[2];   // ’†‘–k‹“o˜^Ò”
    [SerializeField] private Text[] CHN_Shanghai_TotalUnemployedNum = new Text[2];  // ’†‘ãŠC“o˜^Ò”
    [SerializeField] private Text[] CHN_Sichuan_TotalUnemployedNum = new Text[2];   // ’†‘lì“o˜^Ò”

    [SerializeField] private Text CHN_Beijing_Death_tollNum;                        // ’†‘–k‹€–SÒ”
    [SerializeField] private Text CHN_Shanghai_Death_tollNum;                       // ’†‘–k‹€–SÒ”
    [SerializeField] private Text CHN_Sichuan_Death_tollNum;                        // ’†‘–k‹€–SÒ”

    //[SerializeField] private Text[] CHN_Beijing_name = new Text[2];                // ’†‘–k‹–¼‘O
    //[SerializeField] private Text[] CHN_Beijing_LaborForce = new Text[2];          // ’†‘–k‹˜J“­—Í
    //[SerializeField] private Text[] CHN_Beijing_Totalassets = new Text[2];         // ’†‘–k‹‘‘Y

    // Start is called before the first frame update
    void Start()
    {
        CHN_Beijing_AreaLv.text = database.unemployed[0].UnemployedAreaNo.ToString();
        CHN_Beijing_EmploymentNum.text = database.unemployed[0].EmploymentNum.ToString();
        CHN_Beijing_TotalUnemployedNum[0].text = database.unemployed[0].InitUnemployedNum.ToString();
        CHN_Beijing_TotalUnemployedNum[1].text = database.unemployed[0].CurrentUnemployedNum.ToString();
        CHN_Beijing_Death_tollNum.text = database.unemployed[0].Death_tollNum.ToString();

        CHN_Shanghai_AreaLv.text = database.unemployed[1].UnemployedAreaNo.ToString();
        CHN_Shanghai_EmploymentNum.text = database.unemployed[1].EmploymentNum.ToString();
        CHN_Shanghai_TotalUnemployedNum[0].text = database.unemployed[1].InitUnemployedNum.ToString();
        CHN_Shanghai_TotalUnemployedNum[1].text = database.unemployed[1].CurrentUnemployedNum.ToString();
        CHN_Shanghai_Death_tollNum.text = database.unemployed[1].Death_tollNum.ToString();

        CHN_Sichuan_AreaLv.text = database.unemployed[2].UnemployedAreaNo.ToString();
        CHN_Sichuan_EmploymentNum.text = database.unemployed[2].EmploymentNum.ToString();
        CHN_Sichuan_TotalUnemployedNum[0].text = database.unemployed[2].InitUnemployedNum.ToString();
        CHN_Sichuan_TotalUnemployedNum[1].text = database.unemployed[2].CurrentUnemployedNum.ToString();
        CHN_Sichuan_Death_tollNum.text = database.unemployed[2].Death_tollNum.ToString();

        //CHN_Beijing_name[0].text = database.manufacturers[0].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
        //CHN_Beijing_Totalassets[0].text = database.manufacturers[0].Totalassets.ToString();
        //CHN_Beijing_name[1].text = database.manufacturers[1].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[1].text = database.manufacturers[1].LaborForce.ToString();
        //CHN_Beijing_Totalassets[1].text = database.manufacturers[1].Totalassets.ToString();


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
