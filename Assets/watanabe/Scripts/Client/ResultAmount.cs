using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultAmount : MonoBehaviour
{
    public GameObject Amount_obj;
    public GameObject Minigame_obj;
    MinigameManager Minigame_scr;

    public int amount; // âºÉfÅ[É^

    // Start is called before the first frame update
    void Start()
    {
        Amount_obj = transform.Find("AmountText").gameObject;
        Text Amount_Text = Amount_obj.GetComponent<Text>();

        Minigame_obj = GameObject.Find("MinigameManager");
        Minigame_scr = Minigame_obj.GetComponent<MinigameManager>();

        amount = Minigame_scr.AmountData;
        Amount_Text.text = "\néxï• : " + amount;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
