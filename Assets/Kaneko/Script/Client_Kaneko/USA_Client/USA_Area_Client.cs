using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_Area_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject Client_Page1Panel;
    [SerializeField] GameObject Client_Page2Panel;
    [SerializeField] GameObject Manufacturer_Page1Panel;
    [SerializeField] GameObject Manufacturer_Page2Panel;
    [SerializeField] GameObject Unemployed_Page1Panel;
    [SerializeField] GameObject Unemployed_Page2Panel;
    [SerializeField] GameObject CHN_Area_ClientPanel;
    [SerializeField] GameObject USA_Area_ClientPanel;
    [SerializeField] GameObject RUS_Area_ClientPanel;
    [SerializeField] GameObject AUS_Area_ClientPanel;
    [SerializeField] GameObject ZAF_Area_ClientPanel;
    [SerializeField] Vector3 TargetPos;

    public void OnPointerClick(PointerEventData eventData)
    {


        Manufacturer_Page1Panel.SetActive(false);
        Manufacturer_Page2Panel.SetActive(false);
        Unemployed_Page1Panel.SetActive(false);
        Unemployed_Page2Panel.SetActive(false);
        CHN_Area_ClientPanel.SetActive(false);
        RUS_Area_ClientPanel.SetActive(false);
        AUS_Area_ClientPanel.SetActive(false);
        ZAF_Area_ClientPanel.SetActive(false);

        // ç∂Ç…ìÆÇ≠èàóùÇµÇƒÇ©ÇÁï\é¶
        Client_Page1Panel.transform.position = TargetPos;
        Client_Page2Panel.transform.position = TargetPos;

        USA_Area_ClientPanel.SetActive(true);

    }
}
