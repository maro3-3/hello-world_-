using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Cancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject RUS_AreaPage_Manufacturer_Panel;   // ロシア地域失業者ページ

    [SerializeField] private GameObject RUS_Moscow_ManuList_Panel;    // ロシア　モスクワ生産者リストページ
    [SerializeField] private GameObject RUS_Ufa_ManuList_Panel;    // ロシア　ウファ生産者リストページ

    [SerializeField] private GameObject[] RUS_Moscow_ManuPage_Panel = new GameObject[2];    // ロシア　モスクワ生産者ページ
    [SerializeField] private GameObject[] RUS_Ufa_ManuPage_Panel = new GameObject[4];    // ロシア　ウファ生産者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (RUS_Moscow_ManuList_Panel.activeInHierarchy == true ||
            RUS_Ufa_ManuList_Panel.activeInHierarchy == true)
            USA_ManuListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        if (RUS_Moscow_ManuPage_Panel[0].activeInHierarchy == true ||
           RUS_Moscow_ManuPage_Panel[1].activeInHierarchy == true)
        {
            RUS_Moscow_ManuPage_Panel[0].SetActive(false);
            RUS_Moscow_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            RUS_Moscow_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 4; i++)
        {
            if (RUS_Ufa_ManuPage_Panel[i].activeInHierarchy == true)
            {
                RUS_Ufa_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                RUS_Ufa_ManuList_Panel.SetActive(true);
            }
        }

        // 
    }

    // 各地域生産者リストページから地域ページへ移動
    void USA_ManuListPage_AreaPage_ChangeActive()
    {
        RUS_Moscow_ManuList_Panel.SetActive(false);
        RUS_Ufa_ManuList_Panel.SetActive(false);
        // Manufacturer_Panel.SetActive(true);
        RUS_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // 各地域生産者ページから各地域生産者リストページへ移動
    void USA_ManufacturerPage_ManuList_ChangeActive()
    {
        // どの地域の生産者かで表示する生産者リストをかえる
        if (RUS_Moscow_ManuPage_Panel[0].activeInHierarchy == true ||
           RUS_Moscow_ManuPage_Panel[1].activeInHierarchy == true)
        {
            RUS_Moscow_ManuPage_Panel[0].SetActive(false);
            RUS_Moscow_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            RUS_Moscow_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 4; i++)
        {
            if (RUS_Ufa_ManuPage_Panel[i].activeInHierarchy == true)
            {
                RUS_Ufa_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                RUS_Ufa_ManuList_Panel.SetActive(true);
            }
        }
    }
}
