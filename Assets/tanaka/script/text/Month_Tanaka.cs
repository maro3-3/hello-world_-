using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//現在の月用のスクリプト
public class Month_Tanaka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        monthCount();//現在の月計算
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void monthCount()//現在の月計算
    {
        //ターン取得
        int turn = 7;//仮

        int count = 0;//カウント用

        while (turn > 3)//ターンが３以下になるまで４で割る
        {
            turn /= 4;
            count++;
        }

        count += 4;//スタートが４月なので４を足す

        if (count > 12)//１２より多かった場合１２で割ったあまりを求める
        {
            count %= 12;
        }

        string monthNumS = count.ToString();//stringに変換
        gameObject.GetComponent<Text>().text = monthNumS;//出力
    }
}
