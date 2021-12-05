using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Production : MonoBehaviour 
{
    [SerializeField] private GameObject Clientlist;
    [SerializeField] private ClientList Cliscript;

    [SerializeField] private GameObject ProductionText_obj;
    public Text Production_Text;

    [SerializeField] private GameObject DifficultMark_obj;

    public int CountryNo;  // �����f�[�^
    public int AreaNo;     // �n�扼�f�[�^
    public int ProductionNo;// �n�搶�Y�҃i���o�[�f�[�^
    public string ProductionName; // ���Y�҂̖��O
    public int production; // ���Y�����f�[�^
    public bool Choice;

    // Start is called before the first frame update
    void Start()
    {
        Clientlist = GameObject.Find("ClientList");
        Cliscript = Clientlist.GetComponent<ClientList>();

        ProductionText_obj = transform.Find("ProductionText").gameObject;
        Production_Text = ProductionText_obj.GetComponent<Text>();

        Choice = false;
    }

    // Update is called once per frame
    void Update()
    {
        
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

    }
}
