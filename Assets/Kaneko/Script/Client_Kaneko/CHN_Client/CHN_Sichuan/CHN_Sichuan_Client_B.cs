using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Sichuan_Client_B : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject Client_page1Panel;
    [SerializeField] private GameObject Client_page2Panel;
    [SerializeField] private GameObject CHN_Sichuan_ClientList_Panel;
    [SerializeField] private GameObject CHN_Sichuan_ClientB_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        BG_Panel.SetActive(false);
        Client_page1Panel.SetActive(false);
        Client_page2Panel.SetActive(false);
        CHN_Sichuan_ClientList_Panel.SetActive(false);
        CHN_Sichuan_ClientB_Panel.SetActive(true);
    }
}
