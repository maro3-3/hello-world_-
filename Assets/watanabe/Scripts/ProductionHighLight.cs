using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 生産者リストがクライアントリストで条件にあてはまるものをハイライトさせる
public class ProductionHighLight : MonoBehaviour
{
    private GameObject Clientlist;
    [SerializeField] private GameObject[] request;
    [SerializeField] private Request[] Reqscript;
    [SerializeField] private GameObject[] RequestHighLight;
    private GameObject RedHighLight;

    private Production production; // 自身の生産物ナンバーを取得する用

    // Start is called before the first frame update
    void Start()
    {
        Clientlist = GameObject.Find("ClientList");

        for (int i = 0; i < request.Length ;i++) // ※必ずインスペクターで配列数を決める事
        {
            // クライアントリストの要求物objとスクリプトと要求物青ハイライトobjを取得
            request[i] = Clientlist.transform.GetChild(i).gameObject;
            Reqscript[i] = request[i].GetComponent<Request>();
            RequestHighLight[i] = request[i].transform.Find("BlueHighLight").gameObject;
        }

        RedHighLight = this.transform.Find("RedHighLight").gameObject;

        production = this.GetComponent<Production>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnHightLight() // 生産物と要求物が同じであればハイライトを表示
    {
        for (int i = 0; i < request.Length; i++)
        {
            if(Reqscript[i].request == production.production)
            {
                if (Clientlist)
                {
                    RequestHighLight[i].SetActive(true);
                }
            }
        }
        RedHighLight.SetActive(true);
    }

    public void OffHightLight()
    {
        for (int i = 0; i < request.Length; i++)
        {
            if (Clientlist)
            {
                RequestHighLight[i].SetActive(false);
            }
        }
        RedHighLight.SetActive(false);
    }
}
