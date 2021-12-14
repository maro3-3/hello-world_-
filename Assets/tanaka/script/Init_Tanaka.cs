using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Tanaka : MonoBehaviour
{
    //タイトルで呼ぶ
    [SerializeField] Area_Tanaka area_t = null;//エリアのデータ
  
     void Awake()
    {
        area_t.area = 0;
    }
}
