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
  //  [SerializeField] DataBase_Tanaka database = null;
    DataBase database = null;
    GameObject turnmanager;
    GameObject transaction;
    // Start is called before the first frame update
    void Start()
    {
        turnmanager = GameObject.Find("TurnManager");
        transaction = GameObject.Find("TransactionManager");
        database = Resources.Load<DataBase>("DataBase");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onclick_TitleToGenchi()
    {
<<<<<<< HEAD
         // SceneManager.LoadScene("Genchi");
       SceneManager.LoadScene("Chi_shisen");
=======
          SceneManager.LoadScene("Genchi");
       // SceneManager.LoadScene("Chi_shisen");
>>>>>>> parent of ae06cd1 (no message)
    }

    public void OnClick_Homepage()//ホームページに遷移
    {
        SceneManager.LoadScene("homepage");
    }

   
    public void OnClick_Sekai()//世界画面への遷移
    {
        SceneManager.LoadScene("SekaiGamen");
    }

    public void OnClick_Minigame()//ミニゲーム画面への遷移
    {
        SceneManager.LoadScene("minigame");
    }

    void Turn()
    {
        database.TurnNum++;//ターン+１
        transaction.GetComponent<Transaction_Tanaka>().Transaction();
    }

    public void OnClick_Flymo()//fly.m.oから出る（今いる現地に戻る？）
    {
        switch (area_t.area)
        {
            case 0:
                area_t.area = 0;
                SceneManager.LoadScene("Chi_shisen");
                break;
            case 1:
                area_t.area = 1;
                SceneManager.LoadScene("Chi_pekin");
                break;
            case 2:
                area_t.area = 2;
                SceneManager.LoadScene("Chi_syanhai");
                break;
            case 3:
                area_t.area = 3;
                SceneManager.LoadScene("Ame_Newyork");
                break;
            case 4:
                area_t.area = 4;
                SceneManager.LoadScene("Ame_sentlouis");
                break;
            case 5:
                area_t.area = 5;
                SceneManager.LoadScene("Ame_Atlanta");
                break;
            case 6:
                area_t.area = 6;
                SceneManager.LoadScene("Rsa_Moscow");
                break;
            case 7:
                area_t.area = 7;
                SceneManager.LoadScene("Rsa_Ufa");
                break;
            case 8:
                area_t.area = 8;
                SceneManager.LoadScene("Asl_Canberra");
                break;
            case 9:
                area_t.area = 9;
                SceneManager.LoadScene("Asl_Perth");
                break;
            case 10:
                area_t.area = 10;
                SceneManager.LoadScene("Asl_Melbourne");
                break;
            case 11:
                area_t.area = 11;
                SceneManager.LoadScene("S.Af_pretoria");
                break;
            case 12:
                area_t.area = 12;
                SceneManager.LoadScene("S.Af_Bloemfontein");
                break;
            case 13:
                area_t.area = 13;
                SceneManager.LoadScene("S.Af_Cape Town");
                break;
            default:
                break;
        }
        
    }

    public void OnClick_Genchi()//現地画面飛ぶ（テスト運用）
    {
        //ターン+１
        Turn();

        //エリアに番号保存


        //遷移
        switch (transform.name)
        {
            case "Sichuan_Button_Genchi":
                area_t.area = 0;
                SceneManager.LoadScene("Chi_shisen");
                break;
            case "Beijing_Button_Genchi":
                area_t.area = 1;
                SceneManager.LoadScene("Chi_pekin");
                break;
            case "Shanghai_Button_Genchi":
                area_t.area = 2;
                SceneManager.LoadScene("Chi_syanhai");
                break;
            case "NewYork_Button_Genchi":
                area_t.area = 3;
                SceneManager.LoadScene("Ame_Newyork");
                break;
            case "SaintLouis_Button_Genchi":
                area_t.area = 4;
                SceneManager.LoadScene("Ame_sentlouis");
                break;
            case "Atlanta_Button_Genchi":
                area_t.area = 5;
                SceneManager.LoadScene("Ame_Atlanta");
                break;
            case "Moscow_Button_Genchi":
                area_t.area = 6;
                SceneManager.LoadScene("Rsa_Moscow");
                break;
            case "Ufa_Button_Genchi":
                area_t.area = 7;
                SceneManager.LoadScene("Rsa_Ufa");
                break;
            case "Canberra_Button_Genchi":
                area_t.area = 8;
                SceneManager.LoadScene("Asl_Canberra");
                break;
            case "Perth_Button_Genchi":
                area_t.area = 9;
                SceneManager.LoadScene("Asl_Perth");
                break;
            case "Melbourne_Button_Genchi":
                area_t.area = 10;
                SceneManager.LoadScene("Asl_Melbourne");
                break;
            case "Pretoria_Button_Genchi":
                area_t.area = 11;
                SceneManager.LoadScene("S.Af_pretoria");
                break;
            case "Bloemfontein_Button_Genchi":
                area_t.area = 12;
                SceneManager.LoadScene("S.Af_Bloemfontein");
                break;
            case "CapeTown_Button_Genchi":
                area_t.area = 13;
                SceneManager.LoadScene("S.Af_Cape Town");
                break;
            default:
                break;
        }
        
    }
}
