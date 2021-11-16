using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// クライアントリストが生産者リストで条件にあてはまるものをハイライトさせる
public class ClientHighLight : MonoBehaviour
{
    private GameObject Productionlist;
    [SerializeField] private GameObject[] production;
    [SerializeField] private Production[] Proscript;
    [SerializeField] private GameObject[] ProductionHighLight;
    private GameObject RedHighLight;

    private Request request; // 自身の生産物ナンバーを取得する用

    // Start is called before the first frame update
    void Start()
    {
        Productionlist = GameObject.Find("ProductionList");

        for (int i = 0; i < production.Length; i++) // ※必ずインスペクターで配列数を決める事
        {
            // クライアントリストの要求物objとスクリプトと要求物青ハイライトobjを取得
            production[i] = Productionlist.transform.GetChild(i).gameObject;
            Proscript[i] = production[i].GetComponent<Production>();
            ProductionHighLight[i] = production[i].transform.Find("DarkHighLight").gameObject;
        }

        RedHighLight = this.transform.Find("RedHighLight").gameObject;

        request = this.GetComponent<Request>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnHightLight() // 生産物と要求物が同じであればハイライトを表示
    {
        for (int i = 0; i < production.Length; i++)
        {
            if (Proscript[i].production == request.request)
            {
                ProductionHighLight[i].SetActive(true);
            }
        }
        RedHighLight.SetActive(true);

    }

    public void OffHightLight()
    {
        for (int i = 0; i < production.Length; i++)
        {
            ProductionHighLight[i].SetActive(false);
        }
        RedHighLight.SetActive(false);
    }
}
