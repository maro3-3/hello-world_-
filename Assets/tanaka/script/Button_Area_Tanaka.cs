using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button_Area_Tanaka : MonoBehaviour
{
    [SerializeField] private GameObject map;//地図のサイズ変更のためにオブジェクト取得

    [SerializeField] GameObject area1;
    [SerializeField] GameObject area2;
    [SerializeField] GameObject area3;


    [SerializeField] GameObject country1;
    [SerializeField] GameObject country2;
    [SerializeField] GameObject country3;
    [SerializeField] GameObject country4;
    [SerializeField] GameObject country5;

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
        Debug.Log("押された");  // ログを出力


        //スケール変更-------------------------------------------------------------------------------
        float mapw = 5000;
        float maph = 3000;
        map.GetComponent<RectTransform>().sizeDelta = new Vector2(mapw, maph);
        //------------------------------------------------------------------------------------------

        //ポジション変更-----------------------------------------------------------------------------
        // Vector3 pos = (855,-469,0);
        Vector3 pos;
        pos.x = 855;
        pos.y = -469;
        pos.z = 0;
        //map.transform.position = pos;
        // Debug.Log(pos.x);
        //map.localPosition = new Vector3(pos.x, pos.y, pos.z);
        //------------------------------------------------------------------------------------------


        //ボタンを表示させる----------
        area1.SetActive(true);
        area2.SetActive(true);
        area3.SetActive(true);
        //--------------------------
        //非表示にする----------------------------
        country1.SetActive(false);
        country2.SetActive(false);
        country3.SetActive(false);
        country4.SetActive(false);
        country5.SetActive(false);
        //---------------------------------------
    }
}
