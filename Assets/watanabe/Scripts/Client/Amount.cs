using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amount : MonoBehaviour
{
    public GameObject AmountText_obj;
    [SerializeField] private GameObject RedHighLight;
    public int amount; // âºÉfÅ[É^
    public bool FairTrade;
    public bool Choice;

    // Start is called before the first frame update
    void Start()
    {
        AmountText_obj = transform.Find("AmountText").gameObject;
        Text Amount_Text = AmountText_obj.GetComponent<Text>();
        RedHighLight = this.transform.Find("RedHighLight").gameObject;
        Amount_Text.text = "\néxï• : " + amount;

        Choice = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickAmount()
    {
        GameObject Minimana = GameObject.Find("MinigameManager");
        MinigameManager script = Minimana.GetComponent<MinigameManager>();
        if(FairTrade)
        {
            script.FairTrade = true;
        }
        Choice = true;
    }

    public void OnHightLight()
    {
        RedHighLight.SetActive(true);
    }

    public void OffHightLight()
    {
        RedHighLight.SetActive(false);
    }

}
