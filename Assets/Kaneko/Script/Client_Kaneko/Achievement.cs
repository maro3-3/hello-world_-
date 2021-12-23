using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 業績更新関数（要求数　, 支払額　, 業績タイプ　, 業績
    public int PerformanceSystem(int requestNumclientType ,int paformance)
    {


        return 0;
    }
    public int AmoPaySystem()
    {
        return 0;
    }

    // 業績変動値 (業績タイプ)
    //public int FluctuationValue(int clienttype)
    //{

    //    int Paformance = 0;
    //    float Probability = 0.0f;

    //    switch (clienttype)
    //    {
    //        // 安定タイプ
    //        case 0:
    //            Probability = Random.value;
    //            if (Probability <= 0.4)
    //                Paformance = 0;
    //            else if (Probability <= 0.7)
    //                Paformance = -30;
    //            else
    //                Paformance = +30;
    //            break;
    //        // 尻上がりタイプ
    //        case 1:
    //            Probability = Random.value;
    //            if (Probability <= 0.7)
    //                Paformance = 50;
    //            else
    //                Paformance = -50;
    //            break;
    //        // 尻下がりタイプ
    //        case 2:
    //            Probability = Random.value;
    //            if (Probability <= 0.7)
    //                Paformance = -50;
    //            else
    //                Paformance = 50;
    //            break;
    //        // ピーキータイプ
    //        case 3:
    //            if (Probability <= 0.5)
    //                Paformance = 50;
    //            else
    //                Paformance = -50;
    //            break;
    //    }
    //    return Paformance;

    //}
}
