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

        Debug.Log("クライアントタイプの１行目：" + lc.sheets[0].list[0].int_ClientType);
        Debug.Log("クライアントナンバーのの１行目：" + lc.sheets[0].list[0].int_ClientNo);
        Debug.Log("クライアントタイプの2行目：" + lc.sheets[0].list[1].int_ClientType);
        Debug.Log("クライアント名：" + lc.sheets[0].list[0].string_ClientName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
