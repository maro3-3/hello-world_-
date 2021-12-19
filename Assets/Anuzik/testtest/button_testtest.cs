using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_testtest : MonoBehaviour
{

    public Button[] button_ishikado = new Button[1];

    Collider2D col;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        OnTriggerStay2D(col);




    }


    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("“–‚½‚Á‚½");
    }







}
