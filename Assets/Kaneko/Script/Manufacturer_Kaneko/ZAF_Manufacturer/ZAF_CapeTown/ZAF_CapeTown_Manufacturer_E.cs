using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_CapeTown_Manufacturer_E : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject ManufacturerPanel;
    [SerializeField] private GameObject ZAF_CapeTown_ManuList_Panel;
    [SerializeField] private GameObject ZAF_CapeTown_Manufacturer_E_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        ZAF_CapeTown_ManuList_Panel.SetActive(false);
        ZAF_CapeTown_Manufacturer_E_Panel.SetActive(true);
    }
}
