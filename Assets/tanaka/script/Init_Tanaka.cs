using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Tanaka : MonoBehaviour
{
    //�^�C�g���ŌĂ�
    [SerializeField] Area_Tanaka area_t = null;//�G���A�̃f�[�^
  
     void Awake()
    {
        area_t.area = 0;
    }
}
