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

    // �ƐэX�V�֐��i�v�����@, �x���z�@, �Ɛу^�C�v�@, �Ɛ�
    public int PerformanceSystem(int requestNumclientType ,int paformance)
    {


        return 0;
    }
    public int AmoPaySystem()
    {
        return 0;
    }

    // �Ɛѕϓ��l (�Ɛу^�C�v)
    //public int FluctuationValue(int clienttype)
    //{

    //    int Paformance = 0;
    //    float Probability = 0.0f;

    //    switch (clienttype)
    //    {
    //        // ����^�C�v
    //        case 0:
    //            Probability = Random.value;
    //            if (Probability <= 0.4)
    //                Paformance = 0;
    //            else if (Probability <= 0.7)
    //                Paformance = -30;
    //            else
    //                Paformance = +30;
    //            break;
    //        // �K�オ��^�C�v
    //        case 1:
    //            Probability = Random.value;
    //            if (Probability <= 0.7)
    //                Paformance = 50;
    //            else
    //                Paformance = -50;
    //            break;
    //        // �K������^�C�v
    //        case 2:
    //            Probability = Random.value;
    //            if (Probability <= 0.7)
    //                Paformance = -50;
    //            else
    //                Paformance = 50;
    //            break;
    //        // �s�[�L�[�^�C�v
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
