using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;

    [SerializeField] private GameObject USA_AreaPage_Unemployed_Panel;   // アメリカ地域失業者ページ
                                                                          
    [SerializeField] private GameObject USA_NewYork_Unemployed_Panel;    // アメリカ　ニューヨーク失業者ページ
    [SerializeField] private GameObject USA_StLouis_Unemployed_Panel;    // アメリカ　セントルイス失業者ページ
    [SerializeField] private GameObject USA_Atlanta_Unemployed_Panel;    // アメリカ　アトランタ失業者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域失業者ページで×ボタン押したら地域を表示
        if (USA_NewYork_Unemployed_Panel.activeInHierarchy == true ||
            USA_StLouis_Unemployed_Panel.activeInHierarchy == true ||
            USA_Atlanta_Unemployed_Panel.activeInHierarchy == true)
            USA_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // 各地域失業者ページから地域ページへ移動
    void USA_UnemployedPage_AreaPage_ChangeActive()
    {
        USA_NewYork_Unemployed_Panel.SetActive(false);
        USA_StLouis_Unemployed_Panel.SetActive(false);
        USA_Atlanta_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        USA_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
