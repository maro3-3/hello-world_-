using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Pretoria_Unemployed : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject UnemployedPanel;
    [SerializeField] private GameObject UnemployedAreaPanel;
    [SerializeField] private GameObject ZAF_Pretoria_UnemployedPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        UnemployedPanel.SetActive(false);
        UnemployedAreaPanel.SetActive(false);
        ZAF_Pretoria_UnemployedPanel.SetActive(true);
    }
}
