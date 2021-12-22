using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CancelButton_Kaneko : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject Client_Panel;
    [SerializeField] private GameObject Manufacturer_Panel;
    [SerializeField] private GameObject Unemployed_Panel;
    [SerializeField] private GameObject CHN_Beijing_ClientList_Panel;    // 中国北京クライアントページ
    [SerializeField] private GameObject CHN_Beijing_ManuList_Panel;      // 中国北京生産者ページ

    [SerializeField] private GameObject CHN_Aria_ClientList_Panel;       // 中国地域クライアントページ
    [SerializeField] private GameObject CHN_Aria_ManuList_Panel;         // 中国地域生産者ページ
    [SerializeField] private GameObject CHN_Aria_UnemployedMenu_Panel;         // 中国地域生産者ページ

    [SerializeField] private GameObject CHN_Beijing_ClientA_Panel;       // 中国北京クライアントAページ
    [SerializeField] private GameObject CHN_Beijing_ManuA_Panel;         // 中国北京生産者Aページ
    [SerializeField] private GameObject CHN_Beijing_Unemployed_Panel;         // 中国北京生産者Aページ

    [SerializeField] private Vector3 ClientStartPos;
    [SerializeField] private Vector3 ManufacturerStartPos;


    public void OnPointerClick(PointerEventData eventData)
    {
        // 各メニューからスタート画面に戻る
        if (CHN_Aria_ClientList_Panel.activeInHierarchy == true ||
            CHN_Aria_ManuList_Panel.activeInHierarchy == true ||
            CHN_Aria_UnemployedMenu_Panel.activeInHierarchy == true)
                StartPage_ChangeActive();

        // 中国地域リストに戻る
        if (CHN_Beijing_ClientList_Panel.activeInHierarchy == true)
            CHN_Aria_Client_ChangeActive();
        if (CHN_Beijing_ManuList_Panel.activeInHierarchy == true)
            CHN_Aria_Manu_ChangeActive();
        if (CHN_Beijing_Unemployed_Panel.activeInHierarchy == true)
            CHN_Aria_Unemployed_ChangeActive();

        // 中国北京リストに戻る
        //if (CHN_Beijing_ClientA_Panel.activeInHierarchy == true)
        //    CHN_Beijing_UnemployedList_ChangeActive();
        if (CHN_Beijing_ManuA_Panel.activeInHierarchy == true)
            CHN_Beijing_ManuList_ChangeActive();
        if (CHN_Beijing_ClientA_Panel.activeInHierarchy == true)
            CHN_Beijing_ClientList_ChangeActive();



        // 中国地域リストに戻る
    }

    // 一番最初の画面に戻る
    private void StartPage_ChangeActive()
    {
        // クライアントと生産者を元の場所に戻す
        GameObject Ccild = Client_Panel.transform.GetChild(0).gameObject;
        Ccild.transform.position = ClientStartPos;
        GameObject Mcild = Manufacturer_Panel.transform.GetChild(0).gameObject;
        Mcild.transform.position = ManufacturerStartPos;

        if (CHN_Aria_ClientList_Panel.activeInHierarchy == true)
            CHN_Aria_ClientList_Panel.SetActive(false);
        if(CHN_Aria_ManuList_Panel.activeInHierarchy == true)
            CHN_Aria_ManuList_Panel.SetActive(false);
        if(CHN_Aria_UnemployedMenu_Panel.activeInHierarchy == true)
            CHN_Aria_UnemployedMenu_Panel.SetActive(false);
        
        // BG・クライアント・生産者・失業者を表示
        BG_Panel.SetActive(true);
        Client_Panel.SetActive(true);
        Manufacturer_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
    }

    // 中国北京失業者リストに戻る
    //private void CHN_Beijing_UnemployedList_ChangeActive()
    //{
    //    CHN_Beijing_UnemployedA_Panel.SetActive(false);
    //    BG_Panel.SetActive(true);
    //    CHN_Beijing_UnemployedMenu_Panel.SetActive(true);
    //    CHN_Beijing_UnemployedA_Panel.SetActive(true);

    //}

    // 中国地域リストに戻る
    private void CHN_Aria_Unemployed_ChangeActive()
    {
        CHN_Beijing_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        CHN_Aria_UnemployedMenu_Panel.SetActive(true);

    }
    // 中国北京生産者リストに戻る
    private void CHN_Beijing_ManuList_ChangeActive()
    {
        CHN_Beijing_ManuA_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Manufacturer_Panel.SetActive(true);
        CHN_Beijing_ManuList_Panel.SetActive(true);

    }
    // 中国北京クライアントリストに戻る
    private void CHN_Beijing_ClientList_ChangeActive()
    {
        CHN_Beijing_ClientA_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Client_Panel.SetActive(true);
        CHN_Beijing_ClientList_Panel.SetActive(true);

    }

    // 中国地域生産者リストに戻る
    private void CHN_Aria_Manu_ChangeActive()
    {
        CHN_Beijing_ManuList_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        CHN_Aria_ManuList_Panel.SetActive(true);

    }
    // 中国地域クライアントリストに戻る
    private void CHN_Aria_Client_ChangeActive()
    {
        CHN_Beijing_ClientList_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        CHN_Aria_ClientList_Panel.SetActive(true);

    }
}
;    

