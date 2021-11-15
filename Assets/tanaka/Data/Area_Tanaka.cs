using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//エリア保存用のスクリプト（テスト運用かも）
[CreateAssetMenu(menuName = "MyScriptable/Create Area")]
public class Area_Tanaka : ScriptableObject
{
    [SerializeField] int _area = 0;
    public int area { get; set; }

    void OnEnable()
    {
        Init();
    }

    void Init()
    {
        area = _area;
    }
}
