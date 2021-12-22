using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;

    [SerializeField] private GameObject RUS_AreaPage_Unemployed_Panel;  // ロシア地域失業者ページ

    [SerializeField] private GameObject RUS_Moscow_Unemployed_Panel;    // ロシア　モスクワ失業者ページ
    [SerializeField] private GameObject RUS_Ufa_Unemployed_Panel;       // ロシア　ウファ失業者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域失業者ページで×ボタン押したら地域を表示
        if (RUS_Moscow_Unemployed_Panel.activeInHierarchy == true ||
            RUS_Ufa_Unemployed_Panel.activeInHierarchy == true)
            RUS_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // 各地域失業者ページから地域ページへ移動
    void RUS_UnemployedPage_AreaPage_ChangeActive()
    {
        RUS_Moscow_Unemployed_Panel.SetActive(false);
        RUS_Ufa_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        RUS_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
