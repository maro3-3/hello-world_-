using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;

    [SerializeField] private GameObject AUS_AreaPage_Unemployed_Panel;     // オーストラリア地域失業者ページ
                                                                            
    [SerializeField] private GameObject AUS_Canberra_Unemployed_Panel;     // オーストラリア　キャンベラ失業者ページ
    [SerializeField] private GameObject AUS_Perth_Unemployed_Panel;        // オーストラリア　パース失業者ページ
    [SerializeField] private GameObject AUS_Melbourne_Unemployed_Panel;    // オーストラリア　メルボルン失業者ページ

    public void OnPointerClick(PointerEventData eventData)
    {
        // 各地域失業者ページで×ボタン押したら地域を表示
        if (AUS_Canberra_Unemployed_Panel.activeInHierarchy == true ||
            AUS_Perth_Unemployed_Panel.activeInHierarchy == true ||
            AUS_Melbourne_Unemployed_Panel.activeInHierarchy == true)
            AUS_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // 各地域失業者ページから地域ページへ移動
    void AUS_UnemployedPage_AreaPage_ChangeActive()
    {
        AUS_Canberra_Unemployed_Panel.SetActive(false);
        AUS_Perth_Unemployed_Panel.SetActive(false);
        AUS_Melbourne_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        AUS_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
