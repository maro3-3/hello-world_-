using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using KanKikuchi.AudioManager;

public class MinigameManager : MonoBehaviour　// 破壊命令、生成命令作る
{
    [SerializeField] DataBase database;
    [SerializeField] List_ClientInformation clientdata;

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
        RESULTPLAN,
        PLAYERIMAGE,
        ENEMYIMAGE,
        BLUEPLAN,
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
    public int ProductionNo;
    public int ProductionData;
    public bool ProductionSend;
    public string ProductionName;

    //ハイライト用変数
    public int intHighLight;

    // 物流権の情報
    public int intLog;
    public bool boolLog;

    public GameObject Game;
    public GameObject Player;
    public GameObject Enemy;

    public bool isWin;
    public bool isLose;

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientdata = Resources.Load("List_ClientInformation") as List_ClientInformation;

        intLog = database.LogisticsRights;

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
        if (0 < intLog)
        {
            UImanager[3].UICreate(UIimage[(int)UILIST.LOGISTICS]);
            UImanager[4].UICreate(UIimage[(int)UILIST.LOGEXPLAN]);
        }
        else
        {
            UImanager[4].UICreate(UIimage[(int)UILIST.BLUEPLAN]);
        }
        UImanager[5].UICreate(UIimage[(int)UILIST.STEPBACK]);
        UImanager[6].UICreate(UIimage[(int)UILIST.PLAYERIMAGE]);
        UImanager[7].UICreate(UIimage[(int)UILIST.ENEMYIMAGE]);

        Step = MINIGAMESTEP.ONE;

        BGMManager.Instance.Play("Standby", 1, 0, 1, true, false);

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
            UImanager[2].UIDestroy();
            UImanager[5].UIDestroy();
            //UImanager[6].UIDestroy();
            //UImanager[7].UIDestroy();
            UImanager[0].UICreate(UIimage[(int)UILIST.PAYMENT]);
            UImanager[2].UICreate(UIimage[(int)UILIST.PAYMENTCHOICE]);
            UImanager[5].UICreate(UIimage[(int)UILIST.STEPBACK]);
            Step = MINIGAMESTEP.TWO;
        }

        if (boolLog) // 物流権を使用した場合UI削除
        {
            UImanager[3].UIDestroy();
            UImanager[4].UIDestroy();
            UImanager[4].UICreate(UIimage[(int)UILIST.BLUEPLAN]);
        }

        if (stepback) // 戻るを押した場合
        {
            SceneManager.LoadScene("Ame_Newyork");
            BGMManager.Instance.Stop();
        }
    }

    void two()
    {
        if(stepback) // 戻るを押した場合
        {
            UIAllDestroy();

            UImanager[0].UICreate(UIimage[(int)UILIST.CLIENT]);
            UImanager[1].UICreate(UIimage[(int)UILIST.PRODUCTION]);
            UImanager[2].UICreate(UIimage[(int)UILIST.PRODUCTIONCHOICE]);
            if (0 < intLog)
            {
                UImanager[3].UICreate(UIimage[(int)UILIST.LOGISTICS]);
                UImanager[4].UICreate(UIimage[(int)UILIST.LOGEXPLAN]);
            }
            UImanager[5].UICreate(UIimage[(int)UILIST.STEPBACK]);
            UImanager[6].UICreate(UIimage[(int)UILIST.PLAYERIMAGE]);
            UImanager[7].UICreate(UIimage[(int)UILIST.ENEMYIMAGE]);
            if (boolLog) intLog += 1; boolLog = false;
            if (FairTrade) FairTrade = false;
            ProductionSend = false;
            stepback = false;
            Step = MINIGAMESTEP.ONE;
            Debug.Log("一段階戻ります。");
        }

        if (boolLog) // 物流権を使用した場合UI削除
        {
            UImanager[3].UIDestroy();
            UImanager[4].UIDestroy();
            UImanager[5].UIDestroy();
            UImanager[4].UICreate(UIimage[(int)UILIST.BLUEPLAN]);
            UImanager[5].UICreate(UIimage[(int)UILIST.STEPBACK]);
        }

        if (AmountSend)
        {
            UIAllDestroy();

            Step = MINIGAMESTEP.THREE;
            Game.SetActive(true);

            //UImanager[4].UICreate(UIimage[(int)UILIST.VS]);

        BGMManager.Instance.Play("Standby", 1, 0, 1, true, false);
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
            UImanager[4].UICreate(UIimage[(int)UILIST.BLUEPLAN]);
            UImanager[6].UICreate(UIimage[(int)UILIST.PLAYERIMAGE]);
            UImanager[7].UICreate(UIimage[(int)UILIST.ENEMYIMAGE]);
            database.Lose = true;
            Step = MINIGAMESTEP.LOSE;
            Game.SetActive(false);

            SEManager.Instance.Play("Result");
            BGMManager.Instance.Play("ResultLose", 1, 0, 1, true, false);
        }
        if(!Enemy)
        {
            UIAllDestroy();

            UImanager[0].UICreate(UIimage[(int)UILIST.RESULTCLIENT]);
            UImanager[1].UICreate(UIimage[(int)UILIST.RESULTPRODUCTION]);
            UImanager[2].UICreate(UIimage[(int)UILIST.WIN]);
            UImanager[4].UICreate(UIimage[(int)UILIST.BLUEPLAN]);
            UImanager[6].UICreate(UIimage[(int)UILIST.PLAYERIMAGE]);
            UImanager[7].UICreate(UIimage[(int)UILIST.ENEMYIMAGE]);
            database.Win = true;

            database.Amount = AmountData;
            Step = MINIGAMESTEP.WIN;
            Game.SetActive(false);

            SEManager.Instance.Play("Result");
            BGMManager.Instance.Play("ResultWin", 1, 0, 1, true, false);
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
            int ClientNum = 0;

            ClientNum += clientdata.sheets[0].list[database.MiniClieNo].int_CountryNo * 1;
            ClientNum += clientdata.sheets[0].list[database.MiniClieNo].int_AreaNo * 100;
            ClientNum += clientdata.sheets[0].list[database.MiniClieNo].int_ClientNo * 10000;

            database.manufacturers[ProductionNo].BusinessPartnerClient.Add(ClientNum);

            Debug.Log(ClientNum);

            SEManager.Instance.Play("MiniGenchi");
            SceneManager.LoadScene("Ame_Newyork");
            BGMManager.Instance.Stop();
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
            SceneManager.LoadScene("Ame_Newyork");
            BGMManager.Instance.Stop();
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
