using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Moscow_Manufacturer_A : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject ManufacturerPanel;
    [SerializeField] private GameObject RUS_Moscow_ManuList_Panel;
    [SerializeField] private GameObject RUS_Moscow_Manufacturer_A_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        RUS_Moscow_ManuList_Panel.SetActive(false);
        RUS_Moscow_Manufacturer_A_Panel.SetActive(true);
    }
}
