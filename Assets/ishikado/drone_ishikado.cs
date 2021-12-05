using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone_ishikado : MonoBehaviour
{
    DataBase database = null;
    int TurnNum;

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
    }

    // Update is called once per frame
    void Update()
    {
        int TurnCount = TurnNum;

        if(TurnCount+2== TurnNum)
        {
            //アイコン表示
        }
    }
}
