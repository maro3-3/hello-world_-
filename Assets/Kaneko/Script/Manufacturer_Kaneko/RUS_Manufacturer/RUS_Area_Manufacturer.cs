using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Area_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject Client_Page1Panel;
    [SerializeField] GameObject Client_Page2Panel;
    [SerializeField] GameObject Manufacturer_Page1Panel;
    [SerializeField] GameObject Manufacturer_Page2Panel;
    [SerializeField] GameObject Unemployed_Page1Panel;
    [SerializeField] GameObject Unemployed_Page2Panel;
    [SerializeField] GameObject CHN_Area_ManufacturerPanel;
    [SerializeField] GameObject USA_Area_ManufacturerPanel;
    [SerializeField] GameObject RUS_Area_ManufacturerPanel;
    [SerializeField] GameObject AUS_Area_ManufacturerPanel;
    [SerializeField] GameObject ZAF_Area_ManufacturerPanel;
    [SerializeField] Vector3 TargetPos;

    public void OnPointerClick(PointerEventData eventData)
    {


        Client_Page1Panel.SetActive(false);
        Client_Page2Panel.SetActive(false);
        Unemployed_Page1Panel.SetActive(false);
        Unemployed_Page2Panel.SetActive(false);
        CHN_Area_ManufacturerPanel.SetActive(false);
        USA_Area_ManufacturerPanel.SetActive(false);
        AUS_Area_ManufacturerPanel.SetActive(false);
        ZAF_Area_ManufacturerPanel.SetActive(false);

        // ç∂Ç…ìÆÇ≠èàóùÇµÇƒÇ©ÇÁï\é¶
        Manufacturer_Page1Panel.transform.position = TargetPos;
        Manufacturer_Page2Panel.transform.position = TargetPos;
        RUS_Area_ManufacturerPanel.SetActive(true);
    }
}
