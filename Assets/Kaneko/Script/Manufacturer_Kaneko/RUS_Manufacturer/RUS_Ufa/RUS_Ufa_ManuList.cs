using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Ufa_ManuList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject RUS_Area_ListPanel;
    [SerializeField] private GameObject RUS_Ufa_ManuListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        RUS_Area_ListPanel.SetActive(false);
        RUS_Ufa_ManuListPanel.SetActive(true);
    }
}
