using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Perth_Client_C : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject Client_page1Panel;
    [SerializeField] private GameObject Client_page2Panel;
    [SerializeField] private GameObject AUS_Perth_ClientList_Panel;
    [SerializeField] private GameObject AUS_Perth_Client_C_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        BG_Panel.SetActive(false);
        Client_page1Panel.SetActive(false);
        Client_page2Panel.SetActive(false);
        AUS_Perth_ClientList_Panel.SetActive(false);
        AUS_Perth_Client_C_Panel.SetActive(true);
    }
}
