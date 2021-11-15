using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//シーンマネージャー
public class SceneManager_Tanaka : MonoBehaviour
{
    public Area_Tanaka area_t;

    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(area_t.area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Genchi()//現地画面飛ぶ（テスト運用）
    {
        //ターン+１
        //transform.tagでタグ取得ータグに対応する場所に飛ぶ？
        //エリアに番号保存
        SceneManager.LoadScene("Genchi");
    }

    public void OnClick_Homepage()//ホームページに遷移
    {
        SceneManager.LoadScene("homepage");
    }

    public void OnClick_Flymo()//fly.m.oから出る（今いる現地に戻る？）テスト運用
    {
        SceneManager.LoadScene("test");
    }
    public void OnClick_Sekai()//世界画面への遷移
    {
        SceneManager.LoadScene("SekaiGamen");
    }
}
