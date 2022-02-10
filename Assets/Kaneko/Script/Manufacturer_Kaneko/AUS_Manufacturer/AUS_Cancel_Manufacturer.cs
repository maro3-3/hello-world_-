using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Cancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject AUS_AreaPage_Manufacturer_Panel;   // アメリカ地域失業者ページ

    [SerializeField] private GameObject AUS_Canberra_ManuList_Panel;    // アメリカ　ニューヨーク生産者リストページ
    [SerializeField] private GameObject AUS_Perth_ManuList_Panel;    // アメリカ　セントルイス生産者リストページ
    [SerializeField] private GameObject AUS_Melbourne_ManuList_Panel;    // アメリカ　アトランタ生産者リストページ

    [SerializeField] private GameObject[] AUS_Canberra_ManuPage_Panel = new GameObject[4];    // アメリカ　ニューヨーク生産者ページ
    [SerializeField] private GameObject[] AUS_Perth_ManuPage_Panel = new GameObject[3];    // アメリカ　セントルイス生産者ページ
    [SerializeField] private GameObject[] AUS_Melbourne_ManuPage_Panel = new GameObject[3];    // アメリカ　アトランタ生産者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (AUS_Canberra_ManuList_Panel.activeInHierarchy == true ||
            AUS_Perth_ManuList_Panel.activeInHierarchy == true ||
            AUS_Melbourne_ManuList_Panel.activeInHierarchy == true)
            USA_ManuListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        for (int i = 0; i < 4; i++)
        {
            if (AUS_Canberra_ManuPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Canberra_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                AUS_Canberra_ManuList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Perth_ManuPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Perth_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                AUS_Perth_ManuList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Melbourne_ManuPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Melbourne_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                AUS_Melbourne_ManuList_Panel.SetActive(true);
            }
        }
        // 
    }

    // 各地域生産者リストページから地域ページへ移動
    void USA_ManuListPage_AreaPage_ChangeActive()
    {
        AUS_Canberra_ManuList_Panel.SetActive(false);
        AUS_Perth_ManuList_Panel.SetActive(false);
        AUS_Melbourne_ManuList_Panel.SetActive(false);
        // Manufacturer_Panel.SetActive(true);
        AUS_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // 各地域生産者ページから各地域生産者リストページへ移動
    void USA_ManufacturerPage_ManuList_ChangeActive()
    {
        // どの地域の生産者かで表示する生産者リストをかえる
        if (AUS_Canberra_ManuPage_Panel[0].activeInHierarchy == true ||
           AUS_Canberra_ManuPage_Panel[1].activeInHierarchy == true)
        {
            AUS_Canberra_ManuPage_Panel[0].SetActive(false);
            AUS_Canberra_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            AUS_Canberra_ManuList_Panel.SetActive(true);
        }
        if (AUS_Perth_ManuPage_Panel[0].activeInHierarchy == true ||
            AUS_Perth_ManuPage_Panel[1].activeInHierarchy == true)
        {
            AUS_Perth_ManuPage_Panel[0].SetActive(false);
            AUS_Perth_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            AUS_Perth_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (AUS_Melbourne_ManuPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Melbourne_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                AUS_Melbourne_ManuList_Panel.SetActive(true);
            }
        }
    }
}
