using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Sichuan_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject CHN_Area_ListPanel;
    [SerializeField] private GameObject CHN_Sichuan_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        CHN_Area_ListPanel.SetActive(false);
        CHN_Sichuan_ClientListPanel.SetActive(true);
    }
}
