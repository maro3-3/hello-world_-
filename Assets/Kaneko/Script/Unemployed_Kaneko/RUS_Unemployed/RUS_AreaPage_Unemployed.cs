using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_AreaPage_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject Client_Page1Panel;
    [SerializeField] GameObject Client_Page2Panel;
    [SerializeField] GameObject Manufacturer_Page1Panel;
    [SerializeField] GameObject Manufacturer_Page2Panel;
    [SerializeField] GameObject Unemployed_Page1Panel;
    [SerializeField] GameObject Unemployed_Page2Panel;
    [SerializeField] GameObject CHN_AreaPage_UnemployedPanel;
    [SerializeField] GameObject USA_AreaPage_UnemployedPanel;
    [SerializeField] GameObject RUS_AreaPage_UnemployedPanel;
    [SerializeField] GameObject AUS_AreaPage_UnemployedPanel;
    [SerializeField] GameObject ZAF_AreaPage_UnemployedPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Client_Page1Panel.SetActive(false);
        Client_Page2Panel.SetActive(false);
        Manufacturer_Page1Panel.SetActive(false);
        Manufacturer_Page2Panel.SetActive(false);
        CHN_AreaPage_UnemployedPanel.SetActive(false);
        USA_AreaPage_UnemployedPanel.SetActive(false);
        AUS_AreaPage_UnemployedPanel.SetActive(false);
        ZAF_AreaPage_UnemployedPanel.SetActive(false);
        RUS_AreaPage_UnemployedPanel.SetActive(true);
    }
}
