using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//派遣中ドローンのテキスト用のスクリプト
public class DispatchedDrone_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase_Tanaka database = null;

    // Start is called before the first frame update
    void Start()
    {
      //  database = Resources.Load<DataBase>("DataBase");

       
        int droneNum = database.TempingDroneNum;
        string droneNumS = droneNum.ToString();
        gameObject.GetComponent<Text>().text = droneNumS;
    }

    // Update is called once per frame
    void Update()
    {

    }
}