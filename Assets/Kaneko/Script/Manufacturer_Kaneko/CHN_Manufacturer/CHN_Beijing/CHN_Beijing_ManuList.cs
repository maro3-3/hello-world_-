using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Beijing_ManuList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject CHN_Area_ListPanel;
    [SerializeField] private GameObject CHN_Beijing_ManuListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        CHN_Area_ListPanel.SetActive(false);
        CHN_Beijing_ManuListPanel.SetActive(true);
    }
}
