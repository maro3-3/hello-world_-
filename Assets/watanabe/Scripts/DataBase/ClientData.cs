using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ClientData : MonoBehaviour
{

    List_Client lc;

    // Start is called before the first frame update
    void Start()
    {
        lc = Resources.Load("List_Client") as List_Client;

        Debug.Log("�N���C�A���g�^�C�v�̂P�s�ځF" + lc.sheets[0].list[0].int_ClientType);
        Debug.Log("�N���C�A���g�i���o�[�̂̂P�s�ځF" + lc.sheets[0].list[0].int_ClientNo);
        Debug.Log("�N���C�A���g�^�C�v��2�s�ځF" + lc.sheets[0].list[1].int_ClientType);
        Debug.Log("�N���C�A���g���F" + lc.sheets[0].list[0].string_ClientName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
