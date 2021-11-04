using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // セッター使用例
        DataBase database = new DataBase();
        database.GetSetProperty = 10;
        Unemployed unemployed = new Unemployed();
        unemployed.GetSetUnemployedNum = 30;

        // ゲッター使用例
        int a = database.GetSetProperty;
        Debug.Log(a);
        int b = unemployed.GetSetEmploymentNum;
        Debug.Log(b);

        // ミッションenum仕様テスト
        Mission mission = new Mission();
        Mission.MissionRewards missionRewards = Mission.MissionRewards.selected;
        Debug.Log(missionRewards);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
