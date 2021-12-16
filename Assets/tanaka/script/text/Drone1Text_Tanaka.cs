using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drone1Text_Tanaka : MonoBehaviour
{
    DataBase database = null;
    [SerializeField] int area;
    [SerializeField] Text a;
    [SerializeField] Text b;
    [SerializeField] Text c;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        a.GetComponent<Text>().text = database.unemployed[area].CurrentUnemployedNum.ToString();
        b.GetComponent<Text>().text = database.unemployed[area].Faint_BreathNum.ToString();
        c.GetComponent<Text>().text = database.unemployed[area].Death_tollNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
