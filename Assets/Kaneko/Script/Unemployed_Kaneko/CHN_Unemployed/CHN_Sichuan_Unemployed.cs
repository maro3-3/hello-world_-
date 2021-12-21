using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Sichuan_Unemployed : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject UnemployedPanel;
    [SerializeField] private GameObject UnemployedMenuPanel;
    [SerializeField] private GameObject CHN_Sichuan_UnemployedPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        UnemployedPanel.SetActive(false);
        UnemployedMenuPanel.SetActive(false);
        CHN_Sichuan_UnemployedPanel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
