using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Button_Genti_Tanaka : MonoBehaviour
{
    [SerializeField] GameObject genti;
  //  [SerializeField] int scenenum;
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
        //�{�^����\��������----------
        genti.SetActive(true);
        //--------------------------
        //��\���ɂ���----------------------------
       // this.gameObject.SetActive(false);
        //---------------------------------------
      //  SceneManager.LoadScene(scenenum);
    }
}