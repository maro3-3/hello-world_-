using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//ターン用スクリプト
public class Turn_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase_Tanaka database = null;
    // Start is called before the first frame update
    void Start()
    {
       // database = Resources.Load<DataBase>("DataBase");

        TurnCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void TurnCount()//ターン計算用
    {

        int turnNum = database.TurnNum;

        if(turnNum>=5)
        {
            turnNum %= 4;
            if (turnNum == 0)
            {
                turnNum = 4;
            }
        }
        string turnNumS = turnNum.ToString();
        gameObject.GetComponent<Text>().text = turnNumS;
    }
}
