using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Beijing_Manufacturer_B : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject ManufacturerPanel;
    [SerializeField] private GameObject CHN_Beijing_ManuList_Panel;
    [SerializeField] private GameObject CHN_Beijing_ManufacturerB_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        CHN_Beijing_ManuList_Panel.SetActive(false);
        CHN_Beijing_ManufacturerB_Panel.SetActive(true);
    }
}
