using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Moscow_Client_D : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject Client_page1Panel;
    [SerializeField] private GameObject Client_page2Panel;
    [SerializeField] private GameObject RUS_Moscow_ClientList_Panel;
    [SerializeField] private GameObject RUS_Moscow_Client_D_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        BG_Panel.SetActive(false);
        Client_page1Panel.SetActive(false);
        Client_page2Panel.SetActive(false);
        RUS_Moscow_ClientList_Panel.SetActive(false);
        RUS_Moscow_Client_D_Panel.SetActive(true);
    }
}
