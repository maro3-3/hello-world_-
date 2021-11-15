using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transaction_Tanaka : MonoBehaviour
{

    private int laborforce;//˜J“­—Í
    private int requests;@//—v‹”
    private int sales;     //”„‚èã‚°
    private int profit;    //—˜‰v


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ƒ^[ƒ“I—¹‚ÉŒÄ‚Î‚ê‚é
        Transaction();
    }

    void Transaction()//æˆø
    {
        profit = sales - laborforce;//”„‚èã‚°-˜J“­—Í—˜‰v
    }
}
