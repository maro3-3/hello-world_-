using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultProduction : MonoBehaviour
{
    public GameObject ProductionText_obj;
    public GameObject Minigame_obj;
    public Text Production_Text;

    MinigameManager Minigame_scr;

    // Start is called before the first frame update
    void Start()
    {
        ProductionText_obj = transform.Find("ProductionNameText").gameObject;
        Production_Text = ProductionText_obj.GetComponent<Text>();

        Minigame_obj = GameObject.Find("MinigameManager");
        Minigame_scr = Minigame_obj.GetComponent<MinigameManager>();

        Production_Text.text = Minigame_scr.ProductionName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
