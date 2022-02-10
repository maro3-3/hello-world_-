using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_Atlanta_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject USA_Area_ListPanel;
    [SerializeField] private GameObject USA_Atlanta_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        USA_Area_ListPanel.SetActive(false);
        USA_Atlanta_ClientListPanel.SetActive(true);
    }
}
