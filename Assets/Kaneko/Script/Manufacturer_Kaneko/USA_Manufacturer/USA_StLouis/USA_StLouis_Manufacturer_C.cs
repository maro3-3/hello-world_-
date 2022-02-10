using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_StLouis_Manufacturer_C : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject ManufacturerPanel;
    [SerializeField] private GameObject USA_StLouis_ManuList_Panel;
    [SerializeField] private GameObject USA_StLouis_Manufacturer_C_Panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        USA_StLouis_ManuList_Panel.SetActive(false);
        USA_StLouis_Manufacturer_C_Panel.SetActive(true);
    }
}
