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
    public void OnClick_Genchi()//現地画面飛ぶ（テスト運用）
    {
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
    public void OnClick_Sekai()
    {
        SceneManager.LoadScene("SekaiGamen");
    }
}
