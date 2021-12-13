using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager_ishikado : MonoBehaviour
{
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

    void TurnUp()
    {
        //ターン終了時

        if(database.TurnNum % 4==0)
        {
            //月末処理
        }

        database.TurnNum++;

        //ターン開始時
    }
}
