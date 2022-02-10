using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Pretoria_ManuList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject ZAF_Area_ListPanel;
    [SerializeField] private GameObject ZAF_Pretoria_ManuListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        ZAF_Area_ListPanel.SetActive(false);
        ZAF_Pretoria_ManuListPanel.SetActive(true);
    }
}
