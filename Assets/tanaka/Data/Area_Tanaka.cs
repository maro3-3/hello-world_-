using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�G���A�ۑ��p�̃X�N���v�g�i�e�X�g�^�p�����j
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
