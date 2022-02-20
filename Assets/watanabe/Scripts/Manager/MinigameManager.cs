using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using KanKikuchi.AudioManager;

public class MinigameManager : MonoBehaviour�@// �j�󖽗߁A�������ߍ��
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
    public MINIGAMESTEP Step;   // �~�j�Q�[���̐i�s�󋵊Ǘ��ϐ�

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

    // �N���C�A���g�̏��
    public int RequestData;
    public bool RequestSend;
    public bool FairTrade;

    // ����z�̏��
    public int AmountData;
    public bool AmountSend;

    // ���Y�҂̏��
    public int ProductionNo;
    public int ProductionData;
    public bool ProductionSend;
    public string ProductionName;

    //�n�C���C�g�p�ϐ�
    public int intHighLight;

    // �������̏��
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
                Debug.Log("�ǂ̏�Ԃɂ������Ă��Ȃ�");
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

        if (boolLog) // ���������g�p�����ꍇUI�폜
        {
            UImanager[3].UIDestroy();
            UImanager[4].UIDestroy();
            UImanager[4].UICreate(UIimage[(int)UILIST.BLUEPLAN]);
        }

        if (stepback) // �߂���������ꍇ
        {
            SceneManager.LoadScene("Ame_Newyork");
            BGMManager.Instance.Stop();
        }
    }

    void two()
    {
        if(stepback) // �߂���������ꍇ
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
            Debug.Log("��i�K�߂�܂��B");
        }

        if (boolLog) // ���������g�p�����ꍇUI�폜
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

    void win() // �v���C���[����
    {
        if (database.Win)
        {
            Debug.Log("����");
        }
        if (Input.GetKeyDown("space")) // �X�y�[�X�������猻�n��ʂ֑J��
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

    void lose() // �v���C���[�s�k
    {
        if (database.Lose)
        {
            Debug.Log("�s�k");
        }
        if (Input.GetKeyDown("space")) // �X�y�[�X�������猻�n��ʂ֑J��
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
