using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject CHN_AreaPage_Client_Panel;   // 中国地域クライアントページ

    [SerializeField] private GameObject CHN_Beijing_ClientList_Panel;     // 中国　北京クライアントリストページ
    [SerializeField] private GameObject CHN_Shanghai_ClientList_Panel;    // 中国　上海クライアントリストページ
    [SerializeField] private GameObject CHN_Sichuan_ClientList_Panel;     // 中国　四川クライアントリストページ

    [SerializeField] private GameObject[] CHN_Beijing_ClientPage_Panel = new GameObject[2];     // 中国　北京クライアントページ
    [SerializeField] private GameObject[] CHN_Shanghai_ClientPage_Panel = new GameObject[3];    // 中国　上海クライアントページ
    [SerializeField] private GameObject[] CHN_Sichuan_ClientPage_Panel = new GameObject[4];     // 中国　四川クライアントページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (CHN_Beijing_ClientList_Panel.activeInHierarchy == true ||
            CHN_Shanghai_ClientList_Panel.activeInHierarchy == true ||
            CHN_Sichuan_ClientList_Panel.activeInHierarchy == true)
            CHN_ClientListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        for (int i = 0; i < 2; i++)
        {
            if (CHN_Beijing_ClientPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Beijing_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                CHN_Beijing_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (CHN_Shanghai_ClientPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Shanghai_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                CHN_Shanghai_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (CHN_Sichuan_ClientPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Sichuan_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                CHN_Sichuan_ClientList_Panel.SetActive(true);
            }
        }
    }

    // 各地域生産者リストページから地域ページへ移動
    void CHN_ClientListPage_AreaPage_ChangeActive()
    {
        CHN_Beijing_ClientList_Panel.SetActive(false);
        CHN_Shanghai_ClientList_Panel.SetActive(false);
        CHN_Sichuan_ClientList_Panel.SetActive(false);
        CHN_AreaPage_Client_Panel.SetActive(true);
    }

}
