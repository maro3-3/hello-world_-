using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Test : MonoBehaviour
{
    List_Client lc;

    // Start is called before the first frame update
    void Start()
    {
        lc = Resources.Load("List_Client") as List_Client;

        Debug.Log("numberの１行目：" + lc.sheets[0].list[0].int_ClientType);
        Debug.Log("nameの１行目：" + lc.sheets[0].list[0].int_ClientNo);
        Debug.Log("numberの2行目：" + lc.sheets[0].list[1].int_ClientType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
