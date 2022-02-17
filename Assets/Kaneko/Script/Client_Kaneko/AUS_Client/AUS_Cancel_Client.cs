using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject AUS_AreaPage_Client_Panel;   // おーすとらりあ地域クライアントページ

    [SerializeField] private GameObject AUS_Canberra_ClientList_Panel;     // オーストラリア　キャンベラクライアントリストページ
    [SerializeField] private GameObject AUS_Perth_ClientList_Panel;        // オーストラリア　パースクライアントリストページ
    [SerializeField] private GameObject AUS_Melbourne_ClientList_Panel;    // オーストラリア　メルボルンクライアントリストページ

    [SerializeField] private GameObject[] AUS_Canberra_ClientPage_Panel = new GameObject[3];    // オーストラリア　キャンベラクライアントページ
    [SerializeField] private GameObject[] AUS_Perth_ClientPage_Panel = new GameObject[3];       // オーストラリア　パースクライアントページ
    [SerializeField] private GameObject[] AUS_Melbourne_ClientPage_Panel = new GameObject[3];   // オーストラリア　メルボルンクライアントページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (AUS_Canberra_ClientList_Panel.activeInHierarchy == true ||
            AUS_Perth_ClientList_Panel.activeInHierarchy == true ||
            AUS_Melbourne_ClientList_Panel.activeInHierarchy == true)
            AUS_ClientListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Canberra_ClientPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Canberra_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                AUS_Canberra_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Perth_ClientPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Perth_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                AUS_Perth_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Melbourne_ClientPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Melbourne_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                AUS_Melbourne_ClientList_Panel.SetActive(true);
            }
        }
    }

    // 各地域生産者リストページから地域ページへ移動
    void AUS_ClientListPage_AreaPage_ChangeActive()
    {
        AUS_Canberra_ClientList_Panel.SetActive(false);
        AUS_Perth_ClientList_Panel.SetActive(false);
        AUS_Melbourne_ClientList_Panel.SetActive(false);
        AUS_AreaPage_Client_Panel.SetActive(true);
    }

}
