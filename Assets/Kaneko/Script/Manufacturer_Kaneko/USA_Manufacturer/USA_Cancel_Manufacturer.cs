using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_Cancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject USA_AreaPage_Manufacturer_Panel;   // アメリカ地域失業者ページ

    [SerializeField] private GameObject USA_NewYork_ManuList_Panel;    // アメリカ　ニューヨーク生産者リストページ
    [SerializeField] private GameObject USA_StLouis_ManuList_Panel;    // アメリカ　セントルイス生産者リストページ
    [SerializeField] private GameObject USA_Atlanta_ManuList_Panel;    // アメリカ　アトランタ生産者リストページ

    [SerializeField] private GameObject[] USA_NewYork_ManuPage_Panel = new GameObject[2];    // アメリカ　ニューヨーク生産者ページ
    [SerializeField] private GameObject[] USA_StLouis_ManuPage_Panel = new GameObject[3];    // アメリカ　セントルイス生産者ページ
    [SerializeField] private GameObject[] USA_Atlanta_ManuPage_Panel = new GameObject[4];    // アメリカ　アトランタ生産者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (USA_NewYork_ManuList_Panel.activeInHierarchy == true ||
            USA_StLouis_ManuList_Panel.activeInHierarchy == true ||
            USA_Atlanta_ManuList_Panel.activeInHierarchy == true)
            USA_ManuListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        if (USA_NewYork_ManuPage_Panel[0].activeInHierarchy == true ||
           USA_NewYork_ManuPage_Panel[1].activeInHierarchy == true)
        {
            USA_NewYork_ManuPage_Panel[0].SetActive(false);
            USA_NewYork_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            USA_NewYork_ManuList_Panel.SetActive(true);
        }
        if (USA_StLouis_ManuPage_Panel[0].activeInHierarchy == true ||
            USA_StLouis_ManuPage_Panel[1].activeInHierarchy == true ||
            USA_StLouis_ManuPage_Panel[2].activeInHierarchy == true)
        {
            USA_StLouis_ManuPage_Panel[0].SetActive(false);
            USA_StLouis_ManuPage_Panel[1].SetActive(false);
            USA_StLouis_ManuPage_Panel[2].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            USA_StLouis_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 4; i++)
        {
            if (USA_Atlanta_ManuPage_Panel[i].activeInHierarchy == true)
            {
                USA_Atlanta_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                USA_Atlanta_ManuList_Panel.SetActive(true);
            }
        }

        // 
    }

    // 各地域生産者リストページから地域ページへ移動
    void USA_ManuListPage_AreaPage_ChangeActive()
    {
        USA_NewYork_ManuList_Panel.SetActive(false);
        USA_StLouis_ManuList_Panel.SetActive(false);
        USA_Atlanta_ManuList_Panel.SetActive(false);
        // Manufacturer_Panel.SetActive(true);
        USA_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // 各地域生産者ページから各地域生産者リストページへ移動
    void USA_ManufacturerPage_ManuList_ChangeActive()
    {
        // どの地域の生産者かで表示する生産者リストをかえる
        if (USA_NewYork_ManuPage_Panel[0].activeInHierarchy == true ||
           USA_NewYork_ManuPage_Panel[1].activeInHierarchy == true)
        {
            USA_NewYork_ManuPage_Panel[0].SetActive(false);
            USA_NewYork_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            USA_NewYork_ManuList_Panel.SetActive(true);
        }
        if (USA_StLouis_ManuPage_Panel[0].activeInHierarchy == true ||
            USA_StLouis_ManuPage_Panel[1].activeInHierarchy == true)
        {
            USA_StLouis_ManuPage_Panel[0].SetActive(false);
            USA_StLouis_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            USA_StLouis_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (USA_Atlanta_ManuPage_Panel[i].activeInHierarchy == true)
            {
                USA_Atlanta_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                USA_Atlanta_ManuList_Panel.SetActive(true);
            }
        }
    }
}
