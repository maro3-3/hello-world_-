using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//失業者数用のスクリプト
public class Unemployed_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase_Tanaka database = null;
    // Start is called before the first frame update
    void Start()
    {
        //database = Resources.Load<DataBase>("DataBase");

        int unemployedNum = database.UnemployedNum;
        string unemployedNumS = unemployedNum.ToString();
        gameObject.GetComponent<Text>().text = unemployedNumS;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
