using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject RUS_AreaPage_Client_Panel;      // ロシア地域クライアントページ

    [SerializeField] private GameObject RUS_Moscow_ClientList_Panel;    // ロシア　モスクワクライアントリストページ
    [SerializeField] private GameObject RUS_Ufa_ClientList_Panel;       // ロシア　ウファ　クライアントリストページ

    [SerializeField] private GameObject[] RUS_Moscow_ClientPage_Panel = new GameObject[4];    // ロシアモスクワクライアントページ
    [SerializeField] private GameObject[] RUS_Ufa_ClientPage_Panel = new GameObject[3];       // ロシアウファ　クライアントページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (RUS_Moscow_ClientList_Panel.activeInHierarchy == true ||
            RUS_Ufa_ClientList_Panel.activeInHierarchy == true)
            RUS_ClientListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        for (int i = 0; i < 4; i++)
        {
            if (RUS_Moscow_ClientPage_Panel[i].activeInHierarchy == true)
            {
                RUS_Moscow_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                RUS_Moscow_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (RUS_Ufa_ClientPage_Panel[i].activeInHierarchy == true)
            {
                RUS_Ufa_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                RUS_Ufa_ClientList_Panel.SetActive(true);
            }
        }
    }

    // 各地域生産者リストページから地域ページへ移動
    void RUS_ClientListPage_AreaPage_ChangeActive()
    {
        RUS_Moscow_ClientList_Panel.SetActive(false);
        RUS_Ufa_ClientList_Panel.SetActive(false);
        RUS_AreaPage_Client_Panel.SetActive(true);
    }

}
