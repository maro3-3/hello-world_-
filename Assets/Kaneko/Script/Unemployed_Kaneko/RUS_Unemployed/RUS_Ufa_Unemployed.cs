using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Ufa_Unemployed : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject UnemployedPanel;
    [SerializeField] private GameObject UnemployedAreaPanel;
    [SerializeField] private GameObject RUS_Ufa_UnemployedPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        UnemployedPanel.SetActive(false);
        UnemployedAreaPanel.SetActive(false);
        RUS_Ufa_UnemployedPanel.SetActive(true);
    }
}
