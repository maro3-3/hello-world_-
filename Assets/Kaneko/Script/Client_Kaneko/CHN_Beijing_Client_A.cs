using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Beijing_Client_A : MonoBehaviour, IPointerClickHandler
{
   // private ClientData clientData = null;

    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject ClientPanel;
    [SerializeField] private GameObject ClientMenuPanel;
    [SerializeField] private GameObject USA_Client_APanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        //clientData = Resources.Load<ClientData>("ClientData");

        //for (int i = 0; i < 20; i++)
        //{
        //    clientData.CHN_Beijing_Clients[i].FluctuationValue(clientData.CHN_Beijing_Clients[i].CHN_Beijing_ClientType);
        //    for (int n = 0; n < 6; n++)
        //    {
        //        clientData.CHN_Beijing_Clients[i].Requ_Pay_In_de_crease(clientData.CHN_Beijing_Clients[i].CHN_Beijing_RequNum[n],
        //            clientData.CHN_Beijing_Clients[i].CHN_Beijing_ContractAmoPay[n],
        //            clientData.CHN_Beijing_Clients[i].CHN_Beijing_Performance,
        //            n);
        //    }
        //}
        //throw new System.NotImplementedException();
        BG_Panel.SetActive(false);
        ClientPanel.SetActive(false);
        ClientMenuPanel.SetActive(false);
        USA_Client_APanel.SetActive(true);
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
