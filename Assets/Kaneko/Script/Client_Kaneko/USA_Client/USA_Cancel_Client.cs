using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject USA_AreaPage_Client_Panel;   // アメリカ地域クライアントページ

    [SerializeField] private GameObject USA_NewYork_ClientList_Panel;    // アメリカ　ニューヨーククライアントリストページ
    [SerializeField] private GameObject USA_StLouis_ClientList_Panel;    // アメリカ　セントルイスクライアントリストページ
    [SerializeField] private GameObject USA_Atlanta_ClientList_Panel;    // アメリカ　アトランタクライアントリストページ

    [SerializeField] private GameObject[] USA_NewYork_ClientPage_Panel = new GameObject[2];    // アメリカ　ニューヨーククライアントページ
    [SerializeField] private GameObject[] USA_StLouis_ClientPage_Panel = new GameObject[3];    // アメリカ　セントルイスクライアントページ
    [SerializeField] private GameObject[] USA_Atlanta_ClientPage_Panel = new GameObject[2];    // アメリカ　アトランタクライアントページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (USA_NewYork_ClientList_Panel.activeInHierarchy == true ||
            USA_StLouis_ClientList_Panel.activeInHierarchy == true ||
            USA_Atlanta_ClientList_Panel.activeInHierarchy == true)
            USA_ClientListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        for (int i = 0; i < 3; i++)
        {
            if (USA_NewYork_ClientPage_Panel[i].activeInHierarchy == true)
            {
                USA_NewYork_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                USA_NewYork_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 2; i++)
        {
            if (USA_StLouis_ClientPage_Panel[i].activeInHierarchy == true)
            {
                USA_StLouis_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                USA_StLouis_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (USA_Atlanta_ClientPage_Panel[i].activeInHierarchy == true)
            {
                USA_Atlanta_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                USA_Atlanta_ClientList_Panel.SetActive(true);
            }
        }
    }

    // 各地域生産者リストページから地域ページへ移動
    void USA_ClientListPage_AreaPage_ChangeActive()
    {
        USA_NewYork_ClientList_Panel.SetActive(false);
        USA_StLouis_ClientList_Panel.SetActive(false);
        USA_Atlanta_ClientList_Panel.SetActive(false);
        USA_AreaPage_Client_Panel.SetActive(true);
    }

}
