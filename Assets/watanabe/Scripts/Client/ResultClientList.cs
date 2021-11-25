using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultClientList : MonoBehaviour
{
    [SerializeField] DataBase database;

    [SerializeField] private GameObject ClientNameText_obj;
    [SerializeField] private Text ClientName_Text;

    [SerializeField] private GameObject ClientLevelText_obj;
    [SerializeField] private Text ClientLevel_Text;

    public int ClientLevel;// クライアントレベル
    public string ClientName;   // クライアントネーム
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        ClientNameText_obj = transform.Find("ClientName").gameObject;
        ClientName_Text = ClientNameText_obj.GetComponent<Text>();

        ClientLevelText_obj = transform.Find("ClientLevel").gameObject;
        ClientLevel_Text = ClientLevelText_obj.GetComponent<Text>();

        ClientName = database.clients[database.MiniClieNo].ClientName;
        ClientLevel = database.clients[database.MiniClieNo].ClientLv;

        ClientLevel_Text.text = "Lv " + ClientLevel;
        ClientName_Text.text = ClientName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
