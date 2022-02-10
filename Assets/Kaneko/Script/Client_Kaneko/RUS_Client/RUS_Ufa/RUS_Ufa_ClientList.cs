using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Ufa_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject RUS_Area_ListPanel;
    [SerializeField] private GameObject RUS_Ufa_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        RUS_Area_ListPanel.SetActive(false);
        RUS_Ufa_ClientListPanel.SetActive(true);
    }
}
