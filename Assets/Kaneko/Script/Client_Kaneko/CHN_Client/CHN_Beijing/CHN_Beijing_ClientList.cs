using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Beijing_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject CHN_Area_ListPanel;
    [SerializeField] private GameObject CHN_Beijing_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        CHN_Area_ListPanel.SetActive(false);
        CHN_Beijing_ClientListPanel.SetActive(true);
    }
}
