using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_NewYork_ManuList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject USA_Area_ListPanel;
    [SerializeField] private GameObject USA_NewYork_ManuListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        USA_Area_ListPanel.SetActive(false);
        USA_NewYork_ManuListPanel.SetActive(true);
    }
}
