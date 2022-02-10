using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Pretoria_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject ZAF_Area_ListPanel;
    [SerializeField] private GameObject ZAF_Pretoria_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        ZAF_Area_ListPanel.SetActive(false);
        ZAF_Pretoria_ClientListPanel.SetActive(true);
    }
}
