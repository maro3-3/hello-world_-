using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Sichuan_ManuList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject CHN_Area_ListPanel;
    [SerializeField] private GameObject CHN_Sichuan_ManuListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        CHN_Area_ListPanel.SetActive(false);
        CHN_Sichuan_ManuListPanel.SetActive(true);
    }
}
