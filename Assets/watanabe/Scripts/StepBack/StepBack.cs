using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepBack : MonoBehaviour
{
    [SerializeField] private GameObject Minimana;
    [SerializeField] private MinigameManager Miniscript;

    // Start is called before the first frame update
    void Start()
    {
        Minimana = GameObject.Find("MinigameManager");
        Miniscript = Minimana.GetComponent<MinigameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickStepBack()
    {
        Miniscript.stepback = true;
    }
}
