using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Canberra_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject AUS_Area_ListPanel;
    [SerializeField] private GameObject AUS_Canberra_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        AUS_Area_ListPanel.SetActive(false);
        AUS_Canberra_ClientListPanel.SetActive(true);
    }
}
