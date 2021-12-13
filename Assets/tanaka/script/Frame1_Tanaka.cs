using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Frame1_Tanaka : MonoBehaviour
{

    [SerializeField] GameObject frame1;

    DataBase database = null;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        int count = 0;
        while (count < 12)
        {
            if (database.RewartState[count] == 1) break;
            count++;
        }
        if (database.RewartState[count] == 1)
        {
            switch (database.RewartContent[count])
            {
                case 0:
                    break;
                case 1:
                    database.PossessionDroneNum++;
                    break;
                case 2:
                    database.ExtensionStage++;
                    break;
                case 3:
                    break;
            }
        }
    }
}
