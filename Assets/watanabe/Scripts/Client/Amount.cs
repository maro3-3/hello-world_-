using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amount : MonoBehaviour
{
    public GameObject AmountText_obj;
    public int amount; // âºÉfÅ[É^
    public bool Choice;

    // Start is called before the first frame update
    void Start()
    {
        AmountText_obj = transform.Find("AmountText").gameObject;
        Text Amount_Text = AmountText_obj.GetComponent<Text>();
        Amount_Text.text = "\néxï• : " + amount;

        Choice = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickAmount()
    {
        Choice = true;
    }
}
