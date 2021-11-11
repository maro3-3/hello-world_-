using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Production : MonoBehaviour // クリックではなくハイライトだけで値を渡す
{
    public int CountriNo;  // 国仮データ
    public int AreaNo;     // 地域仮データ
    public int ProductionNo;// 地域生産者ナンバーデータ
    public string ProductionName; // 生産者の名前
    public int production; // 生産物仮データ
    public bool Choice;

    // Start is called before the first frame update
    void Start()
    {
        Choice = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickProduction()
    {
        Choice = true;
    }
}
