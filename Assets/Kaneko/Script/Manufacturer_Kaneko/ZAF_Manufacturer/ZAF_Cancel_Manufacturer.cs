using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Cancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject ZAF_AreaPage_Manufacturer_Panel;   // 南アフリカ地域失業者ページ

    [SerializeField] private GameObject ZAF_Pretoria_ManuList_Panel;    // 南アフリカ　プレトリア生産者リストページ
    [SerializeField] private GameObject ZAF_Bloemfontein_ManuList_Panel;    // 南アフリカ　ブルームフォンテイン生産者リストページ
    [SerializeField] private GameObject ZAF_CapeTown_ManuList_Panel;    // 南アフリカ　ケープタウン生産者リストページ

    [SerializeField] private GameObject[] ZAF_Pretoria_ManuPage_Panel = new GameObject[3];    // 南アフリカ　プレトリア生産者ページ
    [SerializeField] private GameObject[] ZAF_Bloemfontein_ManuPage_Panel = new GameObject[4];    // 南アフリカ　ブルームフォンテイン生産者ページ
    [SerializeField] private GameObject[] ZAF_CapeTown_ManuPage_Panel = new GameObject[5];    // 南アフリカ　ケープタウン生産者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域生産者リストで×ボタン押したら地域を表示
        if (ZAF_Pretoria_ManuList_Panel.activeInHierarchy == true ||
            ZAF_Bloemfontein_ManuList_Panel.activeInHierarchy == true ||
            ZAF_CapeTown_ManuList_Panel.activeInHierarchy == true)
            ZAF_ManuListPage_AreaPage_ChangeActive();

        // どの地域の生産者かで表示する生産者リストをかえる
        for (int i = 0; i < 3; i++)
        {
            if (ZAF_Pretoria_ManuPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_Pretoria_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                ZAF_Pretoria_ManuList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (ZAF_Bloemfontein_ManuPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_Bloemfontein_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                ZAF_Bloemfontein_ManuList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (ZAF_CapeTown_ManuPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_CapeTown_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                ZAF_CapeTown_ManuList_Panel.SetActive(true);
            }
        }

        // 
    }

    // 各地域生産者リストページから地域ページへ移動
    void ZAF_ManuListPage_AreaPage_ChangeActive()
    {
        ZAF_Pretoria_ManuList_Panel.SetActive(false);
        ZAF_Bloemfontein_ManuList_Panel.SetActive(false);
        ZAF_CapeTown_ManuList_Panel.SetActive(false);
        // Manufacturer_Panel.SetActive(true);
        ZAF_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // 各地域生産者ページから各地域生産者リストページへ移動
    void ZAF_ManufacturerPage_ManuList_ChangeActive()
    {
        // どの地域の生産者かで表示する生産者リストをかえる
        if (ZAF_Pretoria_ManuPage_Panel[0].activeInHierarchy == true ||
           ZAF_Pretoria_ManuPage_Panel[1].activeInHierarchy == true)
        {
            ZAF_Pretoria_ManuPage_Panel[0].SetActive(false);
            ZAF_Pretoria_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            ZAF_Pretoria_ManuList_Panel.SetActive(true);
        }
        if (ZAF_Bloemfontein_ManuPage_Panel[0].activeInHierarchy == true ||
            ZAF_Bloemfontein_ManuPage_Panel[1].activeInHierarchy == true)
        {
            ZAF_Bloemfontein_ManuPage_Panel[0].SetActive(false);
            ZAF_Bloemfontein_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            ZAF_Bloemfontein_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (ZAF_CapeTown_ManuPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_CapeTown_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                ZAF_CapeTown_ManuList_Panel.SetActive(true);
            }
        }
    }
}
