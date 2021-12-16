using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vsUI : MonoBehaviour
{

    [SerializeField] DataBase database;

    [SerializeField] private GameObject Minimana;
    [SerializeField] private MinigameManager Miniscript;

    [SerializeField] private GameObject ProductionNameText_obj;
    [SerializeField] private Text ProductionName_Text;

    [SerializeField] private GameObject ClientNameText_obj;
    [SerializeField] private Text ClientName_Text;
    
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        Minimana = GameObject.Find("MinigameManager");
        Miniscript = Minimana.GetComponent<MinigameManager>();

        ProductionNameText_obj = transform.Find("ProductionName").gameObject;
        ProductionName_Text = ProductionNameText_obj.GetComponent<Text>();
        ProductionName_Text.text = Miniscript.ProductionName;


        ClientNameText_obj = transform.Find("ClientName").gameObject;
        ClientName_Text = ClientNameText_obj.GetComponent<Text>();
        ClientName_Text.text = database.clients[database.MiniClieNo].ClientName;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
