using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Canberra_ManuList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject AUS_Area_ListPanel;
    [SerializeField] private GameObject AUS_Canberra_ManuListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        AUS_Area_ListPanel.SetActive(false);
        AUS_Canberra_ManuListPanel.SetActive(true);
    }
}
