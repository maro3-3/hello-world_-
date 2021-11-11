using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Unemployed_Kaneko: MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject ClientPanel;
    [SerializeField] GameObject ManufacturerPanel;
    [SerializeField] GameObject UnemployedPanel;
    [SerializeField] GameObject UnemployedMenuPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        ClientPanel.SetActive(false);
        ManufacturerPanel.SetActive(false);
        UnemployedMenuPanel.SetActive(true);
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
