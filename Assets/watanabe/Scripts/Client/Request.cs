using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Request : MonoBehaviour// �f�[�^�x�[�X����v�������󂯎��A��������
{
    public int request;//����int�^
    public bool Highlight; // �n�C���C�g����ꍇtrue
    public bool Choice;

    // Start is called before the first frame update
    void Start()
    {
        Highlight = false;
        Choice = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickRequest()
    {
        Choice = true;
    }
}
