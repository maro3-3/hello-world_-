using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �Z�b�^�[�g�p��
        DataBase database = new DataBase();
        database.GetSetProperty = 10;
        Unemployed unemployed = new Unemployed();
        unemployed.GetSetUnemployedNum = 30;

        // �Q�b�^�[�g�p��
        int a = database.GetSetProperty;
        Debug.Log(a);
        int b = unemployed.GetSetEmploymentNum;
        Debug.Log(b);

        // �~�b�V����enum�d�l�e�X�g
        Mission mission = new Mission();
        Mission.MissionRewards missionRewards = Mission.MissionRewards.selected;
        Debug.Log(missionRewards);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
