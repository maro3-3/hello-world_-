using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Canberra_Manufacturer_B : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject ManufacturerPanel;
    [SerializeField] private GameObject AUS_Canberra_ManuList_Panel;
    [SerializeField] private GameObject AUS_Canberra_Manufacturer_B_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        AUS_Canberra_ManuList_Panel.SetActive(false);
        AUS_Canberra_Manufacturer_B_Panel.SetActive(true);
    }
}
