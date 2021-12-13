using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ManuCountry_Kaneko : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject ClientPanel;
    [SerializeField] GameObject ManufacturerPanel;
    [SerializeField] GameObject UnemployedPanel;
    [SerializeField] GameObject ManuCountryMenuPanel;
    [SerializeField] Vector3 TargetPos;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        ClientPanel.SetActive(false);
        UnemployedPanel.SetActive(false);
        // ç∂Ç…ìÆÇ≠èàóùÇµÇƒÇ©ÇÁï\é¶
        GameObject Parent = this.transform.parent.gameObject;
        Parent.transform.position = TargetPos;
        ManuCountryMenuPanel.SetActive(true);
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
