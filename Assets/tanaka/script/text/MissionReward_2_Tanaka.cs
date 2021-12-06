using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MissionReward_2_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase_Tanaka database = null;
    // Start is called before the first frame update
    void Start()
    {
        //database = Resources.Load<DataBase>("DataBase");
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
        while (count < 12)
        {
            if (database.RewartState[count] == 1)
            {
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
                break;
            }
            count++;
        }
        
      

        gameObject.GetComponent<Text>().text = reward;
    }
}
