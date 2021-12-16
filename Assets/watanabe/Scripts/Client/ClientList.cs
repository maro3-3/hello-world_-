using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientList : MonoBehaviour // Productionlistを取得して、生産者に該当するアイテムをハイライト表示する
{
    [SerializeField] DataBase database;

    [SerializeField] private GameObject Productionlist;
    ProductionList Proscript;

    [SerializeField] private GameObject ClientNameText_obj;
    [SerializeField] private Text ClientName_Text;

    [SerializeField] private GameObject ClientLevelText_obj;
    [SerializeField] private Text ClientLevel_Text;

    public Request[] Requestlist;
    public bool isSearch;
    public bool isSend; // 情報送信の確認

    public int debug; // 受け取ったデータを確認する為の仮変数
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        ClientNameText_obj = transform.Find("ClientName").gameObject;
        ClientName_Text = ClientNameText_obj.GetComponent<Text>();

        ClientLevelText_obj = transform.Find("ClientLevel").gameObject;
        ClientLevel_Text = ClientLevelText_obj.GetComponent<Text>();

        isSearch = true;
        isSend = false;

        ClientLevel_Text.text = "Lv " + database.clients[database.MiniClieNo].ClientLv;
        ClientName_Text.text = database.clients[database.MiniClieNo].ClientName;

        RequestInit(Requestlist, database.clients[database.MiniClieNo].Transactions);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSearch)
        {
            // 要求物の情報を取得していない状態

            for (int i = 0; i < Requestlist.Length; i++)
            {
                if (Requestlist[i].Choice)
                {
                    Debug.Log("要求物を検出");
                    debug = Requestlist[i].request;
                    isSearch = false;
                }
            }
        }
        else
        {
            // 要求物の情報を取得している状態

            if (!isSend)
            {
                // 情報未送信
                GameObject Minimana = GameObject.Find("MinigameManager");
                MinigameManager script = Minimana.GetComponent<MinigameManager>();
                script.RequestData = debug;

                isSend = true;
                script.RequestSend = isSend;
            }
            else
            {
                // 情報送信完了
            }
        }
    }

    void RequestInit(Request[] req, int[] trans)
    {
        for(int i = 0; i < req.Length; i++)
        {
            req[i].request = trans[i];
        }
        Debug.Log("クライアントの要求物を初期化");
    }
}
