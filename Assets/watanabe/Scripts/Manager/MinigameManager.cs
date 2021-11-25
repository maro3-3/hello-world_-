using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MinigameManager : MonoBehaviour�@// �j�󖽗߁A�������ߍ��
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
    }
    public MINIGAMESTEP Step;   // �~�j�Q�[���̐i�s�󋵊Ǘ��ϐ�

    public enum UILIST
    {
        CLIENT,
        PAYMENT,
        PRODUCTION,
        RESULTCLIENT,
        RESULTPRODUCTION,
        WIN,
        LOSE,
    }
    public Image[] UIimage;

    public UIManager[] UImanager;

    // �N���C�A���g�̏��
    public int RequestData;
    public bool RequestSend;
    // ����z�̏��
    public int AmountData;
    public bool AmountSend;

    // ���Y�҂̏��
    public int ProductionData;
    public string ProductionName;
    public bool ProductionSend;

    public GameObject Game;
    public GameObject Player;
    public GameObject Enemy;

    public bool isWin;
    public bool isLose;

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        for (int i=0; i < UImanager.Length;i++)
        {
            UImanager[i] = UImanager[i].GetComponent<UIManager>();

        }
        UImanager[0].UICreate(UIimage[(int)UILIST.CLIENT]);
        UImanager[1].UICreate(UIimage[(int)UILIST.PRODUCTION]);
        Step = MINIGAMESTEP.ONE;

        isWin = false;
        isLose = false;
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

            default:
                Debug.Log("�ǂ̏�Ԃɂ������Ă��Ȃ�");
                break;
        }

        if (Input.GetKeyDown("space")) // �X�y�[�X��������s�k
        {
            UImanager[0].UICreate(UIimage[(int)UILIST.RESULTCLIENT]);
            UImanager[1].UICreate(UIimage[(int)UILIST.RESULTPRODUCTION]);
            UImanager[2].UICreate(UIimage[(int)UILIST.LOSE]);
            isLose = true;
            Step = MINIGAMESTEP.FOUR;
            Game.SetActive(false);
        }
    }

    void one()
    {
        if (ProductionSend)
        {
            UImanager[0].UIDestroy();
            UImanager[0].UICreate(UIimage[(int)UILIST.PAYMENT]);
            Step = MINIGAMESTEP.TWO;
        }
    }

    void two()
    {
        if(AmountSend)
        {
            for(int i = 0;i< UImanager.Length; i++)
            {
                UImanager[i].UIDestroy();
                Step = MINIGAMESTEP.THREE;
                Game.SetActive(true);
            }
        }
    }

    void three()
    {
        if(!Player)
        {
            UImanager[0].UICreate(UIimage[(int)UILIST.RESULTCLIENT]);
            UImanager[1].UICreate(UIimage[(int)UILIST.RESULTPRODUCTION]);
            UImanager[2].UICreate(UIimage[(int)UILIST.LOSE]);
            database.Lose = true;
            Step = MINIGAMESTEP.FOUR;
            Game.SetActive(false);
        }
        if(!Enemy)
        {
            for (int i = 0; i < UImanager.Length; i++)
            {
                UImanager[i].UIDestroy();
            }

            UImanager[0].UICreate(UIimage[(int)UILIST.RESULTCLIENT]);
            UImanager[1].UICreate(UIimage[(int)UILIST.RESULTPRODUCTION]);
            UImanager[2].UICreate(UIimage[(int)UILIST.WIN]);

            database.Win = true;
            database.Amount = AmountData;
            Step = MINIGAMESTEP.FIVE;
            Game.SetActive(false);
        }
    }

    void four() // �v���C���[�s�k
    {
        if(database.Lose)
        {
            Debug.Log("�s�k");
        }
        if (Input.GetKeyDown("space")) // �X�y�[�X�������猻�n��ʂ֑J��
        {
            SceneManager.LoadScene("Genchi");
        }
    }

    void five() // �v���C���[����
    {

    }

    void six()
    {

    }

    void seven()
    {

    }

    private void SetStep(MINIGAMESTEP nextstep)
    {
        Step = nextstep;
    }
}
