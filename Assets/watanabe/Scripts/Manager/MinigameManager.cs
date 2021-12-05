using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MinigameManager : MonoBehaviour　// 破壊命令、生成命令作る
{
    [SerializeField] DataBase database;

    public enum MINIGAMESTEP
    {
        ONE,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        WIN,
        LOSE,
    }
    public MINIGAMESTEP Step;   // ミニゲームの進行状況管理変数

    public enum UILIST
    {
        CLIENT,
        PAYMENT,
        PRODUCTION,
        RESULTCLIENT,
        RESULTPRODUCTION,
        LOGISTICS,
        LOGEXPLAN,
        PRODUCTIONCHOICE,
        PAYMENTCHOICE,
        VS,
        STEPBACK,
        WIN,
        LOSE,
    }
    public Image[] UIimage;

    public UIManager[] UImanager;

    public bool stepback;

    // クライアントの情報
    public int RequestData;
    public bool RequestSend;
    public bool FairTrade;

    // 取引額の情報
    public int AmountData;
    public bool AmountSend;

    // 生産者の情報
    public int ProductionData;
    public bool ProductionSend;
    public string ProductionName;

    // 物流権の情報
    public int intLog;
    public bool boolLog; // 仮でbool型

    public GameObject Game;
    public GameObject Player;
    public GameObject Enemy;

    public bool isWin;
    public bool isLose;

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");


        FairTrade = false;
        isWin = false;
        isLose = false;

        for (int i = 0; i < UImanager.Length;i++)
        {
            UImanager[i] = UImanager[i].GetComponent<UIManager>();
        }

        UImanager[0].UICreate(UIimage[(int)UILIST.CLIENT]);
        UImanager[1].UICreate(UIimage[(int)UILIST.PRODUCTION]);
        UImanager[2].UICreate(UIimage[(int)UILIST.PRODUCTIONCHOICE]);

        if ( 0 < intLog)
        {
            UImanager[3].UICreate(UIimage[(int)UILIST.LOGISTICS]);
            UImanager[4].UICreate(UIimage[(int)UILIST.LOGEXPLAN]);
        }

        

        Step = MINIGAMESTEP.ONE;

    }

    // Update is called once per frame
    void Update()
    {
        switch(Step)
        {
            case MINIGAMESTEP.ONE:
                one();
                break;

            case MINIGAMESTEP.TWO:
                two();
                break;

            case MINIGAMESTEP.THREE:
                three();
                break;

            case MINIGAMESTEP.FOUR:
                four();
                break;

            case MINIGAMESTEP.FIVE:
                five();
                break;

            case MINIGAMESTEP.SIX:
                six();
                break;

            case MINIGAMESTEP.SEVEN:
                seven();
                break;

            case MINIGAMESTEP.WIN:
                win();
                break;

            case MINIGAMESTEP.LOSE:
                lose();
                break;

            default:
                Debug.Log("どの状態にも属していない");
                break;
        }
    }

    void one()
    {
        if (ProductionSend)
        {
            UImanager[0].UIDestroy();
            UImanager[0].UICreate(UIimage[(int)UILIST.PAYMENT]);
            UImanager[2].UICreate(UIimage[(int)UILIST.PAYMENTCHOICE]);
            UImanager[5].UICreate(UIimage[(int)UILIST.STEPBACK]);
            Step = MINIGAMESTEP.TWO;
        }
    }

    void two()
    {
        if(stepback) // 戻るを押した場合
        {
            UIAllDestroy();

            UImanager[0].UICreate(UIimage[(int)UILIST.CLIENT]);
            UImanager[1].UICreate(UIimage[(int)UILIST.PRODUCTION]);
            if (0 < intLog)
            {
                UImanager[3].UICreate(UIimage[(int)UILIST.LOGISTICS]);
                UImanager[4].UICreate(UIimage[(int)UILIST.LOGEXPLAN]);
            }

            if(boolLog) intLog += 1; boolLog = false;
            if (FairTrade) FairTrade = false;
            ProductionSend = false;
            stepback = false;
            Step = MINIGAMESTEP.ONE;
            Debug.Log("一段階戻ります。");
        }

        if(boolLog) // 物流権を使用した場合UI削除
        {
            UImanager[3].UIDestroy();
            UImanager[4].UIDestroy();
        }

        if(AmountSend)
        {
            UIAllDestroy();

            Step = MINIGAMESTEP.THREE;
            Game.SetActive(true);

            UImanager[4].UICreate(UIimage[(int)UILIST.VS]);
        }
    }

    void three()
    {
        if(!Player)
        {
            UIAllDestroy();

            UImanager[0].UICreate(UIimage[(int)UILIST.RESULTCLIENT]);
            UImanager[1].UICreate(UIimage[(int)UILIST.RESULTPRODUCTION]);
            UImanager[2].UICreate(UIimage[(int)UILIST.LOSE]);
            database.Lose = true;
            Step = MINIGAMESTEP.LOSE;
            Game.SetActive(false);
        }
        if(!Enemy)
        {
            UIAllDestroy();

            UImanager[0].UICreate(UIimage[(int)UILIST.RESULTCLIENT]);
            UImanager[1].UICreate(UIimage[(int)UILIST.RESULTPRODUCTION]);
            UImanager[2].UICreate(UIimage[(int)UILIST.WIN]);

            database.Win = true;
            database.Amount = AmountData;
            Step = MINIGAMESTEP.WIN;
            Game.SetActive(false);
        }
    }

    void four()
    {

    }

    void five()
    {

    }

    void six()
    {

    }

    void seven()
    {

    }

    void win() // プレイヤー勝利
    {
        if (database.Win)
        {
            Debug.Log("勝利");
        }
        if (Input.GetKeyDown("space")) // スペース押したら現地画面へ遷移
        {
            SceneManager.LoadScene("Genchi");
        }
    }

    void lose() // プレイヤー敗北
    {
        if (database.Lose)
        {
            Debug.Log("敗北");
        }
        if (Input.GetKeyDown("space")) // スペース押したら現地画面へ遷移
        {
            SceneManager.LoadScene("Genchi");
        }
    }

    private void SetStep(MINIGAMESTEP nextstep)
    {
        Step = nextstep;
    }

    private void UIAllDestroy()
    {
        for (int i = 0; i < UImanager.Length; i++)
        {
            UImanager[i].UIDestroy();
        }
    }
}
