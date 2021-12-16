using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductionList : MonoBehaviour
{
    [SerializeField] DataBase database;

    [SerializeField] private GameObject Clientlist;
    [SerializeField] private ClientList Cliscript;

    public Production[] Productions;
    public bool isSearch;
    public bool isSend; // 情報送信の確認

    public int debug; // 受け取ったデータを確認する為の仮変数

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        isSearch = true;
        isSend = false;

        Clientlist = GameObject.Find("ClientList");
        Cliscript = Clientlist.GetComponent<ClientList>();

        for (int i = 0; i < Productions.Length; i++)
        {

            switch (i)
            {
                case 0: // 同じ地域
                    for(int j = 0; j < database.manufacturers.Length; j++) // 生産者分forを回す
                    {
                        if (database.clients[database.MiniClieNo].ClientCountryNo == database.manufacturers[j].ManufacturerCountryNo) // 国は同じか
                        {
                            if (database.clients[database.MiniClieNo].ClientAreaNo == database.manufacturers[j].ManufacturerAreaNo)   // 地域は同じか
                            {
                               //for(int n = 0; n < database.clients[database.MiniClieNo].Transactions.Length; n++)                    // クライアントの取引物の回数回す
                               //{
                               //     if (database.clients[database.MiniClieNo].Transactions[n] == database.manufacturers[j].Products)  // 取引物と要求物は同じか
                               //     {
                               //         // Productions[i]に名前を配置、場合によっては生産者を指定する数字も配置
                               //     }
                               //}

                                Productions[i].Production_Text.text = database.manufacturers[j].ManufacturerName;
                                Productions[i].production = database.manufacturers[j].Products;
                                j = database.manufacturers.Length; // for文終了
                                Debug.Log("同じ国、同じ地域の生産者抽選");
                            }
                        }
                    }
                    break;

                case 1:// 同じ国、違う地域
                    for (int j = 0; j < database.manufacturers.Length; j++) // 生産者分forを回す
                    {
                        if (database.clients[database.MiniClieNo].ClientCountryNo == database.manufacturers[j].ManufacturerCountryNo) // 国は同じか
                        {
                            if (database.clients[database.MiniClieNo].ClientAreaNo != database.manufacturers[j].ManufacturerAreaNo)   // 地域は違うか
                            {
                                //for (int n = 0; n < database.clients[database.MiniClieNo].Transactions.Length; n++)                    // クライアントの取引物の回数回す
                                //{
                                //    if (database.clients[database.MiniClieNo].Transactions[n] == database.manufacturers[j].Products)  // 取引物と要求物は同じか
                                //    {
                                //        // Productions[i]に名前を配置、場合によっては生産者を指定する数字も配置
                                //    }
                                //}
                                Productions[i].Production_Text.text = database.manufacturers[j].ManufacturerName;
                                Productions[i].production = database.manufacturers[j].Products;
                                j = database.manufacturers.Length; // for文終了
                                Debug.Log("同じ国、違う地域の生産者抽選");
                            }
                        }
                    }
                    break;

                case 2:// 他国
                    for (int j = 0; j < database.manufacturers.Length; j++)// 生産者分forを回す
                    {
                        if (database.clients[database.MiniClieNo].ClientCountryNo != database.manufacturers[j].ManufacturerCountryNo) // 国は違うか
                        {
                            Productions[i].Production_Text.text = database.manufacturers[j].ManufacturerName;
                            Productions[i].production = database.manufacturers[j].Products;
                            j = database.manufacturers.Length; // for文終了
                            Debug.Log("他国の生産者を抽選");
                        }
                    }
                    break;

                default:// エラー
                    Debug.Log("生産者の抽選に異常が生じています。");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isSearch)
        {
            // 要求物の情報を取得していない状態

            for (int i = 0; i < Productions.Length; i++)
            {
                if ((Productions[i].Choice)&&(Productions[i]))
                {
                    Debug.Log("生産者を検出");
                    debug = Productions[i].production;
                    isSearch = false;
                }
            }
        }
        else
        {
            // 要求物の情報を取得している状態

            if (!isSend)
            {
                GameObject Minimana = GameObject.Find("MinigameManager");
                MinigameManager script = Minimana.GetComponent<MinigameManager>();
                script.ProductionData = debug;
                
                isSend = true;
                script.ProductionSend = isSend;
            }
            else
            {
                // 情報送信完了
            }
        }
    }
}
