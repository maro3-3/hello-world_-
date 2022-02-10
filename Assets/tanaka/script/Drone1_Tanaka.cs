using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Drone1_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase database = null;

    GameObject drone;

    public static bool[] droneflag;
    public static int[] droneCount;
    public static int[] dronePattern;
    public static int[] droneErea;

    [SerializeField] GameObject icon1;
    [SerializeField] int ereapool;
    GameObject target1;
    Transform target2;
    Transform target3;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        drone = GameObject.Find("DroneManager");
     
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < database.PossessionDroneNum; i++)
        {
            if (droneflag[i] == true)
            {
                switch (dronePattern[i])
                {
                    case 0:
                        drone1(i);
                        break;
                    case 1:
                        drone2(i);
                        break;
                    case 2:
                        drone3(i);
                        break;
                }
            }
        }
    }

    public void OnClick(int num)
    {
        if (database.PossessionDroneNum >= 1)
        {
            switch (num)
            {
                case 0:
                    for (int i = 0; i < database.PossessionDroneNum; i++)
                    {
                        if (droneflag[i] == false)
                        {
                            drone.GetComponent<drone_ishikado>().setdrone(i);
                            droneflag[i] = true;
                            dronePattern[i] = 0;
                            droneCount[i] = drone_ishikado.TurnCount[i];
                            icon1.SetActive(true);
                            database.TempingDroneNum++;
                            droneErea[i] = ereapool;
                            break;
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < database.PossessionDroneNum; i++)
                    {
                        if (droneflag[i] == false)
                        {
                            drone.GetComponent<drone_ishikado>().setdrone(i);
                            droneflag[i] = true;
                            dronePattern[i] = 1;
                            droneCount[i] = drone_ishikado.TurnCount[i];
                            icon1.SetActive(true);
                            database.TempingDroneNum++;
                            droneErea[i] = ereapool;
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < database.PossessionDroneNum; i++)
                    {
                        if (droneflag[i] == false)
                        {
                            drone.GetComponent<drone_ishikado>().setdrone(i);
                            droneflag[i] = true;
                            dronePattern[i] = 2;
                            droneCount[i] = drone_ishikado.TurnCount[i];
                            icon1.SetActive(true);
                            database.TempingDroneNum++;
                            droneErea[i] = ereapool;
                            break;
                        }
                    }
                    break;
            }
        }
        else
        {
            return;
        }
          
    }

    void drone1(int num)
    {
        if (droneCount[num] + 2 == database.TurnNum)
        {
           
            switch (droneErea[num])
            {
                case 0:
                    target1 = GameObject.Find("北京");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 1:
                    target1 = GameObject.Find("上海");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 2:
                    target1 = GameObject.Find("四川");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 3:
                    target1 = GameObject.Find("ニューヨーク");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 4:
                    target1 = GameObject.Find("セントルイス");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 5:
                    target1 = GameObject.Find("アトランタ");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 6:
                    target1 = GameObject.Find("モスクワ");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 7:
                    target1 = GameObject.Find("ウファ");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 8:
                    target1 = GameObject.Find("キャンベラ");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 9:
                    target1 = GameObject.Find("パース");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 10:
                    target1 = GameObject.Find("メルボルン");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 11:
                    target1 = GameObject.Find("プレトリア");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 12:
                    target1 = GameObject.Find("ブルームフォンテイン");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 13:
                    target1 = GameObject.Find("ケープタウン");//地域名
                    target2 = target1.transform.Find("DroneResult1");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
            }

            //  Transform.Find
            target2.gameObject.SetActive(true);
            target3.gameObject.SetActive(false);
            droneflag[num] = false;
            database.TempingDroneNum--;

            int poolUnemployed = 0;
            for (int i = 0; i < 14; i++)
            {
                poolUnemployed += database.unemployed[i].CurrentUnemployedNum;
            }
            database.UnemployedNum = poolUnemployed;
        }
    }

    void drone2(int num)
    {

        if (droneCount[num] + 2 == database.TurnNum)
        {

            switch (droneErea[num])
            {
                case 0:
                    target1 = GameObject.Find("北京");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 1:
                    target1 = GameObject.Find("上海");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 2:
                    target1 = GameObject.Find("四川");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 3:
                    target1 = GameObject.Find("ニューヨーク");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 4:
                    target1 = GameObject.Find("セントルイス");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 5:
                    target1 = GameObject.Find("アトランタ");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 6:
                    target1 = GameObject.Find("モスクワ");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 7:
                    target1 = GameObject.Find("ウファ");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 8:
                    target1 = GameObject.Find("キャンベラ");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 9:
                    target1 = GameObject.Find("パース");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 10:
                    target1 = GameObject.Find("メルボルン");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 11:
                    target1 = GameObject.Find("プレトリア");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 12:
                    target1 = GameObject.Find("ブルームフォンテイン");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 13:
                    target1 = GameObject.Find("ケープタウン");//地域名
                    target2 = target1.transform.Find("DroneResult2");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
            }

            //  Transform.Find
            target2.gameObject.SetActive(true);
            target3.gameObject.SetActive(false);
            droneflag[num] = false;
            database.TempingDroneNum--;
        }
    }

    void drone3(int num)
    {
        if (droneCount[num] + 2 == database.TurnNum)
        {

            switch (droneErea[num])
            {
                case 0:
                    target1 = GameObject.Find("北京");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 1:
                    target1 = GameObject.Find("上海");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 2:
                    target1 = GameObject.Find("四川");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 3:
                    target1 = GameObject.Find("ニューヨーク");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 4:
                    target1 = GameObject.Find("セントルイス");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 5:
                    target1 = GameObject.Find("アトランタ");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 6:
                    target1 = GameObject.Find("モスクワ");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 7:
                    target1 = GameObject.Find("ウファ");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 8:
                    target1 = GameObject.Find("キャンベラ");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 9:
                    target1 = GameObject.Find("パース");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 10:
                    target1 = GameObject.Find("メルボルン");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 11:
                    target1 = GameObject.Find("プレトリア");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 12:
                    target1 = GameObject.Find("ブルームフォンテイン");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
                case 13:
                    target1 = GameObject.Find("ケープタウン");//地域名
                    target2 = target1.transform.Find("DroneResult3");//ドローン帰還のオブジェクト名
                    target3 = target1.transform.Find("DroneWork");//仕事中のアイコン名
                    break;
            }

            //  Transform.Find
            target2.gameObject.SetActive(true);
            target3.gameObject.SetActive(false);
            droneflag[num] = false;
            database.TempingDroneNum--;
        }
    }
}
