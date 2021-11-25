using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//最大ドローン数用のスクリプト
public class MaxDrone_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase_Tanaka database = null;
    // Start is called before the first frame update
    void Start()
    {
       // database = Resources.Load<DataBase>("DataBase");


        int droneNum = database.PossessionDroneNum;
        string droneNumS = droneNum.ToString();
        gameObject.GetComponent<Text>().text = droneNumS;
    }

    // Update is called once per frame
    void Update()
    {

    }
}