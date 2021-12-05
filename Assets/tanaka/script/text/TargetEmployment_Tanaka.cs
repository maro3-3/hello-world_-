using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//雇用目標数用のスクリプト
public class TargetEmployment_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase_Tanaka database = null;
  
    // Start is called before the first frame update
    void Start()
    {
        //database = Resources.Load<DataBase>("DataBase");
       
        int targetEmploymentNum = database.EmploymentTarget[0];
        string targetEmploymentNumS = targetEmploymentNum.ToString();
        gameObject.GetComponent<Text>().text = targetEmploymentNumS;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
