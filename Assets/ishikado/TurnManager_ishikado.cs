using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager_ishikado : MonoBehaviour
{
    private int TurnNum;
    Turn turn = new Turn();

    // Start is called before the first frame update
    void Start()
    {
        //ゲッター
        TurnNum = turn.GetSetTurnNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TurnUp()
    {
        //ターン終了時

        TurnNum++;

        //セッター
        turn.GetSetTurnNum = TurnNum;

        //ターン開始時
    }
}
