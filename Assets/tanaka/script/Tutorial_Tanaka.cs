using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Tanaka : MonoBehaviour
{
    [SerializeField]  GameObject tutorial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if (tutorial.activeSelf == true)
        {
            tutorial.SetActive(false);
        }
        else if (tutorial.activeSelf == false)
        {
            tutorial.SetActive(true);
        }
    }
}
