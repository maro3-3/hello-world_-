using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Sichuan_Manufacturer_A : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject ManufacturerPanel;
    [SerializeField] private GameObject CHN_Beijing_ManuList_Panel;
    [SerializeField] private GameObject CHN_Shanghai_ManufacturerA_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        CHN_Beijing_ManuList_Panel.SetActive(false);
        CHN_Shanghai_ManufacturerA_Panel.SetActive(true);
    }
}
