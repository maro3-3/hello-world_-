using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class TurnManager_ishikado : MonoBehaviour
{
    DataBase database = null;
    GameObject transaction;　//宣言 

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        transaction = GameObject.Find("TransactionManager");　//スタートに書く 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnUp()
    {
        //ターン終了時処理

        if(database.TurnNum % 4==0)
        {
            //月末処理
            transaction.GetComponent<Transaction_Tanaka>().Transaction();　//呼び出したいところ 
        }

        database.TurnNum++;

        EditorUtility.SetDirty(database);
        AssetDatabase.SaveAssets();
        //ターン開始時処理
    }
}
