using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;
     
    [SerializeField] private GameObject ZAF_AreaPage_Unemployed_Panel;        // 南アフリカ地域失業者ページ
                                                                              
    [SerializeField] private GameObject ZAF_Pretoria_Unemployed_Panel;        // 南アフリカ　プレトリア失業者ページ
    [SerializeField] private GameObject ZAF_Bloemfontein_Unemployed_Panel;    // 南アフリカ　ブルームフォンテイン失業者ページ
    [SerializeField] private GameObject ZAF_CapeTown_Unemployed_Panel;        // 南アフリカ　ケープタウン失業者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域失業者ページで×ボタン押したら地域を表示
        if (ZAF_Pretoria_Unemployed_Panel.activeInHierarchy == true ||
            ZAF_Bloemfontein_Unemployed_Panel.activeInHierarchy == true ||
            ZAF_CapeTown_Unemployed_Panel.activeInHierarchy == true)
            ZAF_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // 各地域失業者ページから地域ページへ移動
    void ZAF_UnemployedPage_AreaPage_ChangeActive()
    {
        ZAF_Pretoria_Unemployed_Panel.SetActive(false);
        ZAF_Bloemfontein_Unemployed_Panel.SetActive(false);
        ZAF_CapeTown_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        ZAF_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
