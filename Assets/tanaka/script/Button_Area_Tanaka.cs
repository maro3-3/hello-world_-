using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button_Area_Tanaka : MonoBehaviour
{
    [SerializeField] private RectTransform map;//地図のサイズ変更のためにオブジェクト取得

    //表示する地域
    [SerializeField] GameObject area1;  
    [SerializeField] GameObject area2;
    [SerializeField] GameObject area3;

    //国ボタン消す用
    [SerializeField] GameObject country1;
    [SerializeField] GameObject country2;
    [SerializeField] GameObject country3;
    [SerializeField] GameObject country4;
    [SerializeField] GameObject country5;


    //戻るボタン表示用
    [SerializeField] GameObject ret;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(int area)
    {
        //スケール変更-----------------------------
        float mapw = 5000;
        float maph = 3000;
        map.sizeDelta = new Vector2(mapw, maph);
        //----------------------------------------

        //ポジション変更-------------
        Vector3 pos;
        pos.x = 900;
        pos.y = -545;
        pos.z = 0;
        switch (area)
        {
            case 0://中国
                pos.x = 900;
                pos.y = -545;
                break;
            case 1://アメリカ
                pos.x = -1200;
                pos.y = -395;
                break;
            case 2://ロシア
                pos.x = 857;
                pos.y = -545;
                break;
            case 3:
                pos.x = 319;
                pos.y = 692;
                break;
            case 4:
                pos.x = 1804;
                pos.y = 530;
                break;
            default:
                break;
        }

        map.localPosition = pos;
        //-------------------------


        //ボタンを表示させる----------
        area1.SetActive(true);
        area2.SetActive(true);
        area3.SetActive(true);
        ret.SetActive(true);
        //--------------------------
        //非表示にする---------------
        country1.SetActive(false);
        country2.SetActive(false);
        country3.SetActive(false);
        country4.SetActive(false);
        country5.SetActive(false);
        //--------------------------
    }
}
