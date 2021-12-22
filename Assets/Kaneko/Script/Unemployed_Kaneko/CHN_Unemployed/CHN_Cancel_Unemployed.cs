using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;

    [SerializeField] private GameObject CHN_AreaPage_Unemployed_Panel;   // 中国地域失業者ページ

    [SerializeField] private GameObject CHN_Beijing_Unemployed_Panel;    // 中国北京失業者ページ
    [SerializeField] private GameObject CHN_Shanghai_Unemployed_Panel;   // 中国上海失業者ページ
    [SerializeField] private GameObject CHN_Sichuan_Unemployed_Panel;    // 中国四川失業者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域失業者ページで×ボタン押したら地域を表示
        if (CHN_Beijing_Unemployed_Panel.activeInHierarchy  == true ||
            CHN_Shanghai_Unemployed_Panel.activeInHierarchy == true ||
            CHN_Sichuan_Unemployed_Panel.activeInHierarchy  == true)
                CHN_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // 各地域失業者ページから地域ページへ移動
    void CHN_UnemployedPage_AreaPage_ChangeActive()
    {
        CHN_Beijing_Unemployed_Panel.SetActive(false);
        CHN_Shanghai_Unemployed_Panel.SetActive(false);
        CHN_Sichuan_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        CHN_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
