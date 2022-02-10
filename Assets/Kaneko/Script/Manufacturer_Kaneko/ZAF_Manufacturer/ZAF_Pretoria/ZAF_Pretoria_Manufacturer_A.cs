using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Pretoria_Manufacturer_A : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject ManufacturerPanel;
    [SerializeField] private GameObject ZAF_Pretoria_ManuList_Panel;
    [SerializeField] private GameObject ZAF_Pretoria_Manufacturer_A_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        ZAF_Pretoria_ManuList_Panel.SetActive(false);
        ZAF_Pretoria_Manufacturer_A_Panel.SetActive(true);
    }
}
