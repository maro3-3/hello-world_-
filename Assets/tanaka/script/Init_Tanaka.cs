using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Tanaka : MonoBehaviour
{
    //タイトルで呼ぶ
    [SerializeField] Area_Tanaka area_t = null;//エリアのデータ


    void Awake()
    {
        area_t.area = 0;

        Areamanager_Onodera.InitGenchi();

        drone_ishikado.TurnCount = new int[5];
        for (int i = 0; i < 5; i++)
        {
            drone_ishikado.TurnCount[i] = 0;
        }
        Drone1_Tanaka.droneflag = new bool[5];
        for (int i = 0; i < 5; i++)
        {
            Drone1_Tanaka.droneflag[i] = false;
        }
        Drone1_Tanaka.droneCount = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Drone1_Tanaka.droneCount[i] = 0;
        }
        Drone1_Tanaka.dronePattern = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Drone1_Tanaka.dronePattern[i] = 0;
        }
        Drone1_Tanaka.droneErea = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Drone1_Tanaka.droneErea[i] = 0;
        }
    }
}
