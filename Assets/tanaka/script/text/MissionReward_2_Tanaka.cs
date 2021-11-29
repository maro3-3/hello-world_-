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
                            reward = "–¢ŠJ•ú‘ŠJ•úŒ ";
                            break;
                        case 1:
                            reward = "ƒhƒ[ƒ“”{‚P";
                            break;
                        case 2:
                            reward = "ƒhƒ[ƒ“‹@”\Šg’£";
                            break;
                        case 3:
                            reward = "•¨—¬Œ Šl“¾";
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
