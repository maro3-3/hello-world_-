using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//現地に行くボタン表示用スクリプト
public class Button_Genti_Tanaka : MonoBehaviour
{
    [SerializeField] GameObject genti;
    [SerializeField] GameObject drone1;
    [SerializeField] GameObject drone2;
    [SerializeField] GameObject drone3;

    DataBase database = null;

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        //ボタンを表示させる----------
        genti.SetActive(true);
        drone1.SetActive(true);


        if (database.RewartState[1] == 2)
        {
            drone2.SetActive(true);
        }

        if (database.RewartState[2] == 2)
        {
            drone3.SetActive(true);
        }
        //--------------------------

    }
}