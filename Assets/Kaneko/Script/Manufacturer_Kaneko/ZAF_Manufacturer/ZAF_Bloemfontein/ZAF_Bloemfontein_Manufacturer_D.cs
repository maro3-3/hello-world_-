using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Bloemfontein_Manufacturer_D : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject ManufacturerPanel;
    [SerializeField] private GameObject ZAF_Bloemfontein_ManuList_Panel;
    [SerializeField] private GameObject ZAF_Bloemfontein_Manufacturer_D_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        ZAF_Bloemfontein_ManuList_Panel.SetActive(false);
        ZAF_Bloemfontein_Manufacturer_D_Panel.SetActive(true);
    }
}
