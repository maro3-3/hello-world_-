using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Shanghai_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject CHN_Area_ListPanel;
    [SerializeField] private GameObject CHN_Shanghai_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        CHN_Area_ListPanel.SetActive(false);
        CHN_Shanghai_ClientListPanel.SetActive(true);
    }
}
