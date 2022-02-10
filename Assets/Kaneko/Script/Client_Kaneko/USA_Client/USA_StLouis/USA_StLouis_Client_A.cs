using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_StLouis_Client_A : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject Client_page1Panel;
    [SerializeField] private GameObject Client_page2Panel;
    [SerializeField] private GameObject USA_StLouis_ClientList_Panel;
    [SerializeField] private GameObject USA_StLouis_Client_A_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        BG_Panel.SetActive(false);
        Client_page1Panel.SetActive(false);
        Client_page2Panel.SetActive(false);
        USA_StLouis_ClientList_Panel.SetActive(false);
        USA_StLouis_Client_A_Panel.SetActive(true);
    }
}
