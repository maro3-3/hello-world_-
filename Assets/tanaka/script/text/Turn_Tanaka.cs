using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//ターン用スクリプト
public class Turn_Tanaka : MonoBehaviour
{
    DataBase database = null;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        int turnNum = database.TurnNum;
        string turnNumS = turnNum.ToString();
        gameObject.GetComponent<Text>().text = turnNumS;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
