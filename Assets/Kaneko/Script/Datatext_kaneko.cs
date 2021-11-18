using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Datatext_kaneko : MonoBehaviour
{
    private DataBase database = null;

    [SerializeField] private Text UnemployedNumT;
    [SerializeField] private Text EmploymentNumT;
    [SerializeField] private Text PossessionDroneNumT;
    [SerializeField] private Text TempingDroneNumT;
    [SerializeField] private Text TurnNumT;

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        UnemployedNumT.text = database.UnemployedNum.ToString();
        EmploymentNumT.text = database.EmploymentNum.ToString();
        PossessionDroneNumT.text = database.PossessionDroneNum.ToString();
        TempingDroneNumT.text = database.TempingDroneNum.ToString();
        TurnNumT.text = database.TurnNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
}
