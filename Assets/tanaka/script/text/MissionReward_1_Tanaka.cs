using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MissionReward_1_Tanaka : MonoBehaviour
{
    DataBase database = null;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        text();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void text()
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
                    reward = "���J�����J����";
                    break;
                case 1:
                    reward = "�h���[�����{�P";
                    break;
                case 2:
                    reward = "�h���[���@�\�g��";
                    break;
                case 3:
                    reward = "�������l��";
                    break;

            }
        }

        gameObject.GetComponent<Text>().text = reward;
    }
}
