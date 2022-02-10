using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Bloemfontein_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject ZAF_Area_ListPanel;
    [SerializeField] private GameObject ZAF_Bloemfontein_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        ZAF_Area_ListPanel.SetActive(false);
        ZAF_Bloemfontein_ClientListPanel.SetActive(true);
    }
}
