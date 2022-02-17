using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject ZAF_AreaPage_Client_Panel;   // 南アフリカ地域クライアントページ

    [SerializeField] private GameObject ZAF_Pretoria_ClientList_Panel;    // 南アフリカ　プレトリアクライアントリストページ
    [SerializeField] private GameObject ZAF_Bloemfontein_ClientList_Panel;    // 南アフリカ　ブルームフォンテインクライアントリストページ
    [SerializeField] private GameObject ZAF_CapeTown_ClientList_Panel;    // 南アフリカ　ケープタウンクライアントリストページ

    [SerializeField] private GameObject[] ZAF_Pretoria_ClientPage_Panel = new GameObject[3];    // 南アフリカ　プレトリアクライアントページ
    [SerializeField] private GameObject[] ZAF_Bloemfontein_ClientPage_Panel = new GameObject[2];    // 南アフリカ　ブルームフォンテインクライアントページ
    [SerializeField] private GameObject[] ZAF_CapeTown_ClientPage_Panel = new GameObject[3];    // 南アフリカ　ケープタウンクライアントページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (ZAF_Pretoria_ClientList_Panel.activeInHierarchy == true ||
            ZAF_Bloemfontein_ClientList_Panel.activeInHierarchy == true ||
            ZAF_CapeTown_ClientList_Panel.activeInHierarchy == true)
            ZAF_ClientListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        for (int i = 0; i < 3; i++)
        {
            if (ZAF_Pretoria_ClientPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_Pretoria_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                ZAF_Pretoria_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 2; i++)
        {
            if (ZAF_Bloemfontein_ClientPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_Bloemfontein_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                ZAF_Bloemfontein_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (ZAF_CapeTown_ClientPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_CapeTown_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                ZAF_CapeTown_ClientList_Panel.SetActive(true);
            }
        }

        // 
    }

    // 各地域生産者リストページから地域ページへ移動
    void ZAF_ClientListPage_AreaPage_ChangeActive()
    {
        ZAF_Pretoria_ClientList_Panel.SetActive(false);
        ZAF_Bloemfontein_ClientList_Panel.SetActive(false);
        ZAF_CapeTown_ClientList_Panel.SetActive(false);
        ZAF_AreaPage_Client_Panel.SetActive(true);
    }

}
