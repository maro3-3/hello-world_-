using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request : MonoBehaviour// �f�[�^�x�[�X����v�������󂯎��A��������
{
    public int request;//����int�^
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

    public void ClickRequest()
    {
        Choice = true;
    }
}
