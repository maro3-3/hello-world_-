using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Production : MonoBehaviour 
{
    [SerializeField] private GameObject Clientlist;
    [SerializeField] private ClientList Cliscript;

    [SerializeField] private GameObject RedHighLight;

    [SerializeField] private GameObject ProductionText_obj;
    public Text Production_Text;

    [SerializeField] private GameObject DifficultMark_obj;

    public int production; // ê∂éYï®âºÉfÅ[É^
    public int thisNo;
    public bool Choice;

    // Start is called before the first frame update
    void Start()
    {
        Clientlist = GameObject.Find("ClientList");
        Cliscript = Clientlist.GetComponent<ClientList>();

        RedHighLight = this.transform.Find("RedHighLight").gameObject;

        ProductionText_obj = transform.Find("ProductionText").gameObject;
        Production_Text = ProductionText_obj.GetComponent<Text>();



        Choice = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!Clientlist) // éÊìæÇ≈Ç´ÇƒÇ¢Ç»Ç¢èÍçáíTçı
        {
            Clientlist = GameObject.Find("ClientList");
            if (Clientlist)
            {
                Cliscript = Clientlist.GetComponent<ClientList>();
            }
        }
    }

    public void ClickProduction()
    {
        GameObject Minimana = GameObject.Find("MinigameManager");
        MinigameManager script = Minimana.GetComponent<MinigameManager>();

        if(DifficultMark_obj)
        {
            if (0 < script.intLog)
            {
                script.intLog -= 1;
                script.boolLog = true;
            }
        }

        for (int i = 0; i < Cliscript.Requestlist.Length; i++)
        {
            if (Cliscript.Requestlist[i].request == production)
            {
                script.RequestData = Cliscript.Requestlist[i].request;
                script.ProductionName = Production_Text.text;
                Cliscript.Requestlist[i].Choice = true;
                Choice = true;
            }
        }

        script.ProductionNo = thisNo;
    }

    public void OnHightLight()
    {
        GameObject Minimana = GameObject.Find("MinigameManager");
        MinigameManager Mini_scr = Minimana.GetComponent<MinigameManager>();

        Mini_scr.intHighLight = production;

        GameObject[] Requests = GameObject.FindGameObjectsWithTag("Request");

        for (int i = 0; i < Requests.Length; i++)
        {
            Request Reqscript = Requests[i].GetComponent<Request>();
            GameObject RequestHighLight = Requests[i].transform.Find("BlueHighLight").gameObject;
            if (Reqscript.request == Mini_scr.intHighLight)
            {
                RequestHighLight.SetActive(true);
            }
        }

        RedHighLight.SetActive(true);
    }

    public void OffHightLight()
    {
        GameObject[] Requests = GameObject.FindGameObjectsWithTag("Request");

        for (int i = 0; i < Requests.Length; i++)
        {
            GameObject RequestHighLight = Requests[i].transform.Find("BlueHighLight").gameObject;
            RequestHighLight.SetActive(false);
        }

        RedHighLight.SetActive(false);
    }

    public void MarkInit()
    {
        DifficultMark_obj = this.transform.Find("Mark").gameObject;
    }
}
