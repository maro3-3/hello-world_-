using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour // �f�[�^�x�[�X���悭�������̂ł�����f�[�^�x�[�X���Ɖ��肵�Ă���
{
    // �~�j�Q�[���̏��s�ƁA����̊z��ێ�����B
    public GameObject Minigame_obj;
    MinigameManager Minigame_scr;

    public int AmoData;
    public bool Win;
    public bool Lose;

    // Start is called before the first frame update
    void Start()
    {
        Minigame_obj = GameObject.Find("MinigameManager");
        Minigame_scr = Minigame_obj.GetComponent<MinigameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        AmoData = Minigame_scr.AmountData;
        Win = Minigame_scr.isWin;
        Lose = Minigame_scr.isLose;
    }
}
