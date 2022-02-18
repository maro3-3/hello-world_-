using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultClientList : MonoBehaviour
{
    [SerializeField] DataBase database;
    [SerializeField] List_ClientInformation clientdata;

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
        clientdata = Resources.Load("List_ClientInformation") as List_ClientInformation;

        ClientNameText_obj = transform.Find("ClientName").gameObject;
        ClientName_Text = ClientNameText_obj.GetComponent<Text>();

        ClientLevelText_obj = transform.Find("ClientLevel").gameObject;
        ClientLevel_Text = ClientLevelText_obj.GetComponent<Text>();

        ClientLevel_Text.text = "Lv " + clientdata.sheets[0].list[database.MiniClieNo].int_ClientLv;
        ClientName_Text.text = clientdata.sheets[0].list[database.MiniClieNo].string_ClientName;

        GameObject Minimana = GameObject.Find("MinigameManager");
        MinigameManager script = Minimana.GetComponent<MinigameManager>();

        if(!script.FairTrade)
        {
            GameObject FairTradeText = transform.Find("Amount/FairTrade").gameObject;
            FairTradeText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
