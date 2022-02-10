using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Chancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject CHN_AreaPage_Manufacturer_Panel;   // 中国地域失業者ページ

    [SerializeField] private GameObject CHN_Beijing_ManuList_Panel;    // 中国北京生産者リストページ
    [SerializeField] private GameObject CHN_Shanghai_ManuList_Panel;   // 中国上海生産者リストページ
    [SerializeField] private GameObject CHN_Sichuan_ManuList_Panel;    // 中国四川生産者リストページ

    [SerializeField] private GameObject[] CHN_Beijing_ManuPage_Panel = new GameObject[2];    // 中国北京生産者ページ
    [SerializeField] private GameObject[] CHN_Shanghai_ManuPage_Panel = new GameObject[2];   // 中国上海生産者ページ
    [SerializeField] private GameObject[] CHN_Sichuan_ManuPage_Panel = new GameObject[5];    // 中国四川生産者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (CHN_Beijing_ManuList_Panel.activeInHierarchy == true ||
            CHN_Shanghai_ManuList_Panel.activeInHierarchy == true ||
            CHN_Sichuan_ManuList_Panel.activeInHierarchy == true)
            CHN_ManuListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        if (CHN_Beijing_ManuPage_Panel[0].activeInHierarchy == true ||
           CHN_Beijing_ManuPage_Panel[1].activeInHierarchy == true)
        {
            CHN_Beijing_ManuPage_Panel[0].SetActive(false);
            CHN_Beijing_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            CHN_Beijing_ManuList_Panel.SetActive(true);
        }
        if (CHN_Shanghai_ManuPage_Panel[0].activeInHierarchy == true ||
            CHN_Shanghai_ManuPage_Panel[1].activeInHierarchy == true)
        {
            CHN_Shanghai_ManuPage_Panel[0].SetActive(false);
            CHN_Shanghai_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            CHN_Shanghai_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (CHN_Sichuan_ManuPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Sichuan_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                CHN_Sichuan_ManuList_Panel.SetActive(true);
            }
        }

        // 
    }

    // 各地域生産者リストページから地域ページへ移動
    void CHN_ManuListPage_AreaPage_ChangeActive()
    {
        CHN_Beijing_ManuList_Panel.SetActive(false);
        CHN_Shanghai_ManuList_Panel.SetActive(false);
        CHN_Sichuan_ManuList_Panel.SetActive(false);
       // Manufacturer_Panel.SetActive(true);
        CHN_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // 各地域生産者ページから各地域生産者リストページへ移動
    void CHN_ManufacturerPage_ManuList_ChangeActive()
    {
        // どの地域の生産者かで表示する生産者リストをかえる
        if (CHN_Beijing_ManuPage_Panel[0].activeInHierarchy == true ||
           CHN_Beijing_ManuPage_Panel[1].activeInHierarchy == true)
        {
            CHN_Beijing_ManuPage_Panel[0].SetActive(false);
            CHN_Beijing_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            CHN_Beijing_ManuList_Panel.SetActive(true);
        }
        if (CHN_Shanghai_ManuPage_Panel[0].activeInHierarchy == true ||
            CHN_Shanghai_ManuPage_Panel[1].activeInHierarchy == true)
        {
            CHN_Shanghai_ManuPage_Panel[0].SetActive(false);
            CHN_Shanghai_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            CHN_Shanghai_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (CHN_Sichuan_ManuPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Sichuan_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                CHN_Sichuan_ManuList_Panel.SetActive(true);
            }
        }
    }
}
