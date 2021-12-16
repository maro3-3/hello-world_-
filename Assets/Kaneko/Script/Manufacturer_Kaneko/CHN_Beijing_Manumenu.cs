using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Beijing_Manumenu : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] private GameObject ManuCountryMenuPanel;
    [SerializeField] private GameObject CHN_Beijing_ManumenuPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        ManuCountryMenuPanel.SetActive(false);
        CHN_Beijing_ManumenuPanel.SetActive(true);
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
