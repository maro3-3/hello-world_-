using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_CapeTown_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject ZAF_Area_ListPanel;
    [SerializeField] private GameObject ZAF_CapeTown_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        ZAF_Area_ListPanel.SetActive(false);
        ZAF_CapeTown_ClientListPanel.SetActive(true);
    }
}
