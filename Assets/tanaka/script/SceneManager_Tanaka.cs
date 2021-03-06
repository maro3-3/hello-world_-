using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//シーンマネージャー
public class SceneManager_Tanaka : MonoBehaviour
{
    [SerializeField] Area_Tanaka area_t = null;//エリアのデータ

    GameObject turnmanager;
    // Start is called before the first frame update
    void Start()
    {
        turnmanager = GameObject.Find("TurnManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Genchi()//現地画面飛ぶ（テスト運用）
    {
        //ターン+１
        turnmanager.GetComponent<TurnManager_ishikado>().TurnUp();
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
        
        turnmanager.GetComponent<TurnManager_ishikado>().TurnUp();
        SceneManager.LoadScene("test");
    }
    public void OnClick_Sekai()//世界画面への遷移
    {
        SceneManager.LoadScene("SekaiGamen");
    }
}
