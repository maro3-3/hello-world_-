using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//派遣中ドローンのテキスト用のスクリプト
public class DispatchedDrone_Tanaka : MonoBehaviour
{
    public Drone drone = new Drone();
    // Start is called before the first frame update
    void Start()
    {
        drone.GetSettempingDroneNum = 2;

        int droneNum = drone.GetSettempingDroneNum;
        string droneNumS = droneNum.ToString();
        gameObject.GetComponent<Text>().text = droneNumS;
    }

    // Update is called once per frame
    void Update()
    {

    }
}