using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Client_Kaneko : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject ClientPanel;
    [SerializeField] GameObject ManufacturerPanel;
    [SerializeField] GameObject UnemployedPanel;
    [SerializeField] GameObject ClientMenuPanel;
    [SerializeField] Vector3 TargetPos;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        ManufacturerPanel.SetActive(false);
        UnemployedPanel.SetActive(false);
        // ç∂Ç…ìÆÇ≠èàóùÇµÇƒÇ©ÇÁï\é¶
        GameObject Parent = this.transform.parent.gameObject;
        Debug.Log(Parent);
        Parent.transform.position = TargetPos;
        ClientMenuPanel.SetActive(true);
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
