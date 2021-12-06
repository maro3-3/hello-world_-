using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//雇用数のテキスト用スクリプト
public class Employment_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase_Tanaka  database = null;
    // Start is called before the first frame update
    void Start()
    {
      //  database = Resources.Load<DataBase>("DataBase");

        int employmentNum = database.EmploymentNum;
        string employmentNumS = employmentNum.ToString();
        gameObject.GetComponent<Text>().text = employmentNumS;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
