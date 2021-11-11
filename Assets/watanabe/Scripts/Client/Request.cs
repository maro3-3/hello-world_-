using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Request : MonoBehaviour// データベースから要求物を受け取り、所持する
{
    public int request;//仮でint型
    public bool Highlight; // ハイライトする場合true
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
