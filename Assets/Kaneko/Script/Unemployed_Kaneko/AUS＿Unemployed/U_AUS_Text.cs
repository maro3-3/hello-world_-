using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class U_AUS_Text : MonoBehaviour
{
    private DataBase database = null;
    private ClientData clientData = null;
    void Awake()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientData = Resources.Load<ClientData>("ClientData");
    }

    // ¸‹ÆÒ
    [SerializeField] private Text AUS_Canberra_AreaLv;                             // ’†‘–k‹’nˆæƒŒƒxƒ‹
    [SerializeField] private Text AUS_Perth_AreaLv;                            // ’†‘ãŠC’nˆæƒŒƒxƒ‹
    [SerializeField] private Text AUS_Melbourne_AreaLv;                             // ’†‘lì’nˆæƒŒƒxƒ‹

    [SerializeField] private Text AUS_Canberra_EmploymentNum;                      // ’†‘–k‹ŒÙ—p”
    [SerializeField] private Text AUS_Perth_EmploymentNum;                     // ’†‘ãŠCŒÙ—p”
    [SerializeField] private Text AUS_Melbourne_EmploymentNum;                      // ’†‘lìŒÙ—p”

    [SerializeField] private Text[] AUS_Canberra_TotalUnemployedNum = new Text[2];   // ’†‘–k‹“o˜^Ò”
    [SerializeField] private Text[] AUS_Perth_TotalUnemployedNum = new Text[2];  // ’†‘ãŠC“o˜^Ò”
    [SerializeField] private Text[] AUS_Melbourne_TotalUnemployedNum = new Text[2];   // ’†‘lì“o˜^Ò”

    [SerializeField] private Text AUS_Canberra_Death_tollNum;                        // ’†‘–k‹€–SÒ”
    [SerializeField] private Text AUS_Perth_Death_tollNum;                       // ’†‘–k‹€–SÒ”
    [SerializeField] private Text AUS_Melbourne_Death_tollNum;                        // ’†‘–k‹€–SÒ”

    //[SerializeField] private Text[] CHN_Beijing_name = new Text[2];                // ’†‘–k‹–¼‘O
    //[SerializeField] private Text[] CHN_Beijing_LaborForce = new Text[2];          // ’†‘–k‹˜J“­—Í
    //[SerializeField] private Text[] CHN_Beijing_Totalassets = new Text[2];         // ’†‘–k‹‘‘Y

    // Start is called before the first frame update
    void Start()
    {
        AUS_Canberra_AreaLv.text = database.unemployed[8].UnemployedAreaNo.ToString();
        AUS_Canberra_EmploymentNum.text = database.unemployed[8].EmploymentNum.ToString();
        AUS_Canberra_TotalUnemployedNum[0].text = database.unemployed[8].InitUnemployedNum.ToString();
        AUS_Canberra_TotalUnemployedNum[1].text = database.unemployed[8].CurrentUnemployedNum.ToString();
        AUS_Canberra_Death_tollNum.text = database.unemployed[8].Death_tollNum.ToString();

        AUS_Perth_AreaLv.text = database.unemployed[9].UnemployedAreaNo.ToString();
        AUS_Perth_EmploymentNum.text = database.unemployed[9].EmploymentNum.ToString();
        AUS_Perth_TotalUnemployedNum[0].text = database.unemployed[9].InitUnemployedNum.ToString();
        AUS_Perth_TotalUnemployedNum[1].text = database.unemployed[9].CurrentUnemployedNum.ToString();
        AUS_Perth_Death_tollNum.text = database.unemployed[9].Death_tollNum.ToString();

        AUS_Melbourne_AreaLv.text = database.unemployed[10].UnemployedAreaNo.ToString();
        AUS_Melbourne_EmploymentNum.text = database.unemployed[10].EmploymentNum.ToString();
        AUS_Melbourne_TotalUnemployedNum[0].text = database.unemployed[10].InitUnemployedNum.ToString();
        AUS_Melbourne_TotalUnemployedNum[1].text = database.unemployed[10].CurrentUnemployedNum.ToString();
        AUS_Melbourne_Death_tollNum.text = database.unemployed[10].Death_tollNum.ToString();

        //CHN_Beijing_name[0].text = database.manufacturers[0].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[0].text = database.manufacturers[0].LaborForce.ToString();
        //CHN_Beijing_Totalassets[0].text = database.manufacturers[0].Totalassets.ToString();
        //CHN_Beijing_name[1].text = database.manufacturers[1].ManufacturerName.ToString();
        //CHN_Beijing_LaborForce[1].text = database.manufacturers[1].LaborForce.ToString();
        //CHN_Beijing_Totalassets[1].text = database.manufacturers[1].Totalassets.ToString();


    }
}
