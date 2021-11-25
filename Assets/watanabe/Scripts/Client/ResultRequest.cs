using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultRequest : MonoBehaviour
{
    [SerializeField] private GameObject Minimana;
    [SerializeField] private MinigameManager Miniscript;

    [SerializeField] private int request;//要求物ナンバー、仮でint型

    // Start is called before the first frame update
    void Start()
    {
        Minimana = GameObject.Find("MinigameManager");
        Miniscript = Minimana.GetComponent<MinigameManager>();

        request = Miniscript.RequestData;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
