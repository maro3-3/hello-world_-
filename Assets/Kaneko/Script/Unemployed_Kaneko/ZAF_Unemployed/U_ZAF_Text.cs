using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class U_ZAF_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;
    void Awake()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");
    }

    // ¸‹ÆÒ
    [SerializeField] private Text ZAF_Pretoria_AreaLv;                             // ’†‘–k‹’nˆæƒŒƒxƒ‹
    [SerializeField] private Text ZAF_Bloemfontein_AreaLv;                            // ’†‘ãŠC’nˆæƒŒƒxƒ‹
    [SerializeField] private Text ZAF_CapeTown_AreaLv;                             // ’†‘lì’nˆæƒŒƒxƒ‹

    [SerializeField] private Text ZAF_Pretoria_EmploymentNum;                      // ’†‘–k‹ŒÙ—p”
    [SerializeField] private Text ZAF_Bloemfontein_EmploymentNum;                     // ’†‘ãŠCŒÙ—p”
    [SerializeField] private Text ZAF_CapeTown_EmploymentNum;                      // ’†‘lìŒÙ—p”

    [SerializeField] private Text[] ZAF_Pretoria_TotalUnemployedNum = new Text[2];   // ’†‘–k‹“o˜^Ò”
    [SerializeField] private Text[] ZAF_Bloemfontein_TotalUnemployedNum = new Text[2];  // ’†‘ãŠC“o˜^Ò”
    [SerializeField] private Text[] ZAF_CapeTown_TotalUnemployedNum = new Text[2];   // ’†‘lì“o˜^Ò”

    [SerializeField] private Text ZAF_Pretoria_Death_tollNum;                        // ’†‘–k‹€–SÒ”
    [SerializeField] private Text ZAF_Bloemfontein_Death_tollNum;                       // ’†‘–k‹€–SÒ”
    [SerializeField] private Text ZAF_CapeTown_Death_tollNum;                        // ’†‘–k‹€–SÒ”

    //[SerializeField] private Text[] CHN_Beijing_name = new Text[2];                // ’†‘–k‹–¼‘O
    //[SerializeField] private Text[] CHN_Beijing_LaborForce = new Text[2];          // ’†‘–k‹˜J“­—Í
    //[SerializeField] private Text[] CHN_Beijing_Totalassets = new Text[2];         // ’†‘–k‹‘‘Y

    // Start is called before the first frame update
    void Start()
    {
        ZAF_Pretoria_AreaLv.text = database.unemployed[11].UnemployedAreaNo.ToString();
        ZAF_Pretoria_EmploymentNum.text = database.unemployed[11].EmploymentNum.ToString();
        ZAF_Pretoria_TotalUnemployedNum[0].text = database.unemployed[11].InitUnemployedNum.ToString();
        ZAF_Pretoria_TotalUnemployedNum[1].text = database.unemployed[11].CurrentUnemployedNum.ToString();
        ZAF_Pretoria_Death_tollNum.text = database.unemployed[11].Death_tollNum.ToString();

        ZAF_Bloemfontein_AreaLv.text = database.unemployed[12].UnemployedAreaNo.ToString();
        ZAF_Bloemfontein_EmploymentNum.text = database.unemployed[12].EmploymentNum.ToString();
        ZAF_Bloemfontein_TotalUnemployedNum[0].text = database.unemployed[12].InitUnemployedNum.ToString();
        ZAF_Bloemfontein_TotalUnemployedNum[1].text = database.unemployed[12].CurrentUnemployedNum.ToString();
        ZAF_Bloemfontein_Death_tollNum.text = database.unemployed[12].Death_tollNum.ToString();

        ZAF_CapeTown_AreaLv.text = database.unemployed[13].UnemployedAreaNo.ToString();
        ZAF_CapeTown_EmploymentNum.text = database.unemployed[13].EmploymentNum.ToString();
        ZAF_CapeTown_TotalUnemployedNum[0].text = database.unemployed[13].InitUnemployedNum.ToString();
        ZAF_CapeTown_TotalUnemployedNum[1].text = database.unemployed[13].CurrentUnemployedNum.ToString();
        ZAF_CapeTown_Death_tollNum.text = database.unemployed[13].Death_tollNum.ToString();

        //CHN_Beijing_name[0].text = database.manufacturers[0].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
        //CHN_Beijing_Totalassets[0].text = database.manufacturers[0].Totalassets.ToString();
        //CHN_Beijing_name[1].text = database.manufacturers[1].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[1].text = database.manufacturers[1].LaborForce.ToString();
        //CHN_Beijing_Totalassets[1].text = database.manufacturers[1].Totalassets.ToString();


    }
}
