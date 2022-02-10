using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Perth_ManuList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject AUS_Area_ListPanel;
    [SerializeField] private GameObject AUS_Perth_ManuListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        AUS_Area_ListPanel.SetActive(false);
        AUS_Perth_ManuListPanel.SetActive(true);
    }
}
