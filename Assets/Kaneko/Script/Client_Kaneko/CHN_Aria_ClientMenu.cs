using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Aria_ClientMenu : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] private GameObject CHN__Aria_ClientPanel;
    [SerializeField] private GameObject ClientListMenuPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        CHN__Aria_ClientPanel.SetActive(false);
        ClientListMenuPanel.SetActive(true);
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
