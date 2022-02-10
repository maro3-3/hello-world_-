using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Perth_ClientList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject AUS_Area_ListPanel;
    [SerializeField] private GameObject AUS_Perth_ClientListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        AUS_Area_ListPanel.SetActive(false);
        AUS_Perth_ClientListPanel.SetActive(true);
    }
}
