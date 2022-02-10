using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Shanghai_ManuList : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject CHN_Area_ListPanel;
    [SerializeField] private GameObject CHN_Shanghai_ManuListPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        CHN_Area_ListPanel.SetActive(false);
        CHN_Shanghai_ManuListPanel.SetActive(true);
    }
}
