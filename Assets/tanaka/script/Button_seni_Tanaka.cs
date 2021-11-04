using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button_Seni_Tanaka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick_Genchi()
    {
        SceneManager.LoadScene("Genchi");
    }

    public void OnClick_Homepage()
    {
        SceneManager.LoadScene("homepage");
    }
}
