using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_AreaPage_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject ClientPanel;
    [SerializeField] GameObject ManufacturerPanel;
    [SerializeField] GameObject UnemployedPanel;
    [SerializeField] GameObject CHN_AreaPage_UnemployedPanel;
    [SerializeField] GameObject USA_AreaPage_UnemployedPanel;
    [SerializeField] GameObject RUS_AreaPage_UnemployedPanel;
    [SerializeField] GameObject AUS_AreaPage_UnemployedPanel;
    [SerializeField] GameObject ZAF_AreaPage_UnemployedPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        ClientPanel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        CHN_AreaPage_UnemployedPanel.SetActive(false);
        USA_AreaPage_UnemployedPanel.SetActive(false);
        RUS_AreaPage_UnemployedPanel.SetActive(false);
        ZAF_AreaPage_UnemployedPanel.SetActive(false);
        AUS_AreaPage_UnemployedPanel.SetActive(true);
    }
}
