using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Text_Manager_Tanaka : MonoBehaviour
{
    DataBase database = null;
    [SerializeField] Text month;
    [SerializeField] Text currentTurn;
    [SerializeField] Text targetEmployment;
    [SerializeField] Text employment;
    [SerializeField] Text unemployed;
    [SerializeField] Text dispatchedDrone;
    [SerializeField] Text maxDrone;
    [SerializeField] Text missionReward_1;
    [SerializeField] Text missionReward_2;
   
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        monthCount();
        TurnCount();
        targetEmploymentCount();
        employmentCount();
        unemployedCount();
        dispatchedDroneCount();
        maxDroneCount();
        missionReward1Text();
        missionReward2Text();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void monthCount()//現在の月計算
    {
        //ターン取得
        int turn = database.TurnNum;

        int count = 0;//カウント用

        while (turn > 4)//ターンが4以下になるまで４で割る
        {
            turn -= 4;
            count++;
        }

        count += 4;//スタートが４月なので４を足す

        if (count > 12)//１２より多かった場合１２で割ったあまりを求める
        {
            count %= 12;
        }

        string monthNumS = count.ToString();//stringに変換
        month.GetComponent<Text>().text = monthNumS;//出力
    }

    void TurnCount()//ターン計算用
    {

        int turnNum = database.TurnNum;

        if (turnNum >= 5)
        {
            turnNum %= 4;
            if (turnNum == 0)
            {
                turnNum = 4;
            }
        }
        string turnNumS = turnNum.ToString();
        currentTurn.GetComponent<Text>().text = turnNumS;
    }

    void targetEmploymentCount()
    {
        targetEmployment.GetComponent<Text>().text = database.EmploymentTarget[0].ToString();
    }

    void employmentCount()
    {
        employment.GetComponent<Text>().text = database.EmploymentNum.ToString();
    }

    void unemployedCount()
    {
        unemployed.GetComponent<Text>().text = database.UnemployedNum.ToString();
    }

    void dispatchedDroneCount()
    {
        dispatchedDrone.GetComponent<Text>().text = database.TempingDroneNum.ToString();
    }

    void maxDroneCount()
    {
        maxDrone.GetComponent<Text>().text = database.PossessionDroneNum.ToString();
    }

    void missionReward1Text()
    {
        string reward = "NULL";
        int count = 0;
        while (count <= 12)
        {
            if (database.RewartState[count] == 1) break;
            count++;
        }
        if (database.RewartState[count] == 1)
        {
            switch (database.RewartContent[count])
            {
                case 0:
                    reward = "未開放国開放権";
                    break;
                case 1:
                    reward = "ドローン数＋１";
                    break;
                case 2:
                    reward = "ドローン機能拡張";
                    break;
                case 3:
                    reward = "物流権獲得";
                    break;

            }
        }

        missionReward_1.GetComponent<Text>().text = reward;
    }
    void missionReward2Text()
    {
        string reward = "NULL";
        int count = 0;
        while (count <= 12)
        {
            if (database.RewartState[count] == 1) break;
            count++;
        }
        if (database.RewartState[count + 1] == 1)
        {
            switch (database.RewartContent[count + 1])
            {
                case 0:
                    reward = "未開放国開放権";
                    break;
                case 1:
                    reward = "ドローン数＋１";
                    break;
                case 2:
                    reward = "ドローン機能拡張";
                    break;
                case 3:
                    reward = "物流権獲得";
                    break;

            }
        }

        missionReward_2.GetComponent<Text>().text = reward;
    }
}
