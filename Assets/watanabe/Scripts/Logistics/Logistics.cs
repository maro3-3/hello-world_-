using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logistics : MonoBehaviour
{
    [SerializeField] private GameObject Minimana;
    [SerializeField] private MinigameManager Miniscript;

    [SerializeField] private GameObject LogisticsText_obj;
    public Text Logistics_Text;

    // Start is called before the first frame update
    void Start()
    {
        Minimana = GameObject.Find("MinigameManager");
        Miniscript = Minimana.GetComponent<MinigameManager>();

        LogisticsText_obj = transform.Find("LogisticsQuantity").gameObject;
        Logistics_Text = LogisticsText_obj.GetComponent<Text>();

        Logistics_Text.text = "x " + Miniscript.intLog;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
