using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Production : MonoBehaviour // �N���b�N�ł͂Ȃ��n�C���C�g�����Œl��n��
{
    public int CountriNo;  // �����f�[�^
    public int AreaNo;     // �n�扼�f�[�^
    public int ProductionNo;// �n�搶�Y�҃i���o�[�f�[�^
    public string ProductionName; // ���Y�҂̖��O
    public int production; // ���Y�����f�[�^
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
