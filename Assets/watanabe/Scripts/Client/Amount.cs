using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amount : MonoBehaviour
{
    public GameObject Amount_obj;
    public int amount; // ???f?[?^
    public bool Choice;

    // Start is called before the first frame update
    void Start()
    {
        Amount_obj = transform.Find("AmountText").gameObject;
        Text Amount_Text = Amount_obj.GetComponent<Text>();
        Amount_Text.text = "\n?x?? : " + amount;

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
