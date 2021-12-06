using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Text_Manager_Tanaka : MonoBehaviour
{
    DataBase database = null;
    [SerializeField] Text month;
    [SerializeField] Text currentTurn;
    [SerializeField] Text targetEmployment;
    [SerializeField] Text employment;
    [SerializeField] Text unemployed;
    [SerializeField] Text dispatchedDrone;
    [SerializeField] Text maxDrone;
    [SerializeField] Text missionReward_1;
    [SerializeField] Text missionReward_2;
   
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        monthCount();
        TurnCount();
        targetEmploymentCount();
        employmentCount();
        unemployedCount();
        dispatchedDroneCount();
        maxDroneCount();
        missionReward1Text();
        missionReward2Text();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void monthCount()//���݂̌��v�Z
    {
        //�^�[���擾
        int turn = database.TurnNum;

        int count = 0;//�J�E���g�p

        while (turn > 4)//�^�[����4�ȉ��ɂȂ�܂łS�Ŋ���
        {
            turn -= 4;
            count++;
        }

        count += 4;//�X�^�[�g���S���Ȃ̂łS�𑫂�

        if (count > 12)//�P�Q��葽�������ꍇ�P�Q�Ŋ��������܂�����߂�
        {
            count %= 12;
        }

        string monthNumS = count.ToString();//string�ɕϊ�
        month.GetComponent<Text>().text = monthNumS;//�o��
    }

    void TurnCount()//�^�[���v�Z�p
    {

        int turnNum = database.TurnNum;

        if (turnNum >= 5)
        {
            turnNum %= 4;
            if (turnNum == 0)
            {
                turnNum = 4;
            }
        }
        string turnNumS = turnNum.ToString();
        currentTurn.GetComponent<Text>().text = turnNumS;
    }

    void targetEmploymentCount()
    {
        targetEmployment.GetComponent<Text>().text = database.EmploymentTarget[0].ToString();
    }

    void employmentCount()
    {
        employment.GetComponent<Text>().text = database.EmploymentNum.ToString();
    }

    void unemployedCount()
    {
        unemployed.GetComponent<Text>().text = database.UnemployedNum.ToString();
    }

    void dispatchedDroneCount()
    {
        dispatchedDrone.GetComponent<Text>().text = database.TempingDroneNum.ToString();
    }

    void maxDroneCount()
    {
        maxDrone.GetComponent<Text>().text = database.PossessionDroneNum.ToString();
    }

    void missionReward1Text()
    {
        string reward = "NULL";
        int count = 0;
        while (count <= 12)
        {
            if (database.RewartState[count] == 1) break;
            count++;
        }
        if (database.RewartState[count] == 1)
        {
            switch (database.RewartContent[count])
            {
                case 0:
                    reward = "���J�����J����";
                    break;
                case 1:
                    reward = "�h���[�����{�P";
                    break;
                case 2:
                    reward = "�h���[���@�\�g��";
                    break;
                case 3:
                    reward = "�������l��";
                    break;

            }
        }

        missionReward_1.GetComponent<Text>().text = reward;
    }
    void missionReward2Text()
    {
        string reward = "NULL";
        int count = 0;
        while (count <= 12)
        {
            if (database.RewartState[count] == 1) break;
            count++;
        }
        if (database.RewartState[count + 1] == 1)
        {
            switch (database.RewartContent[count + 1])
            {
                case 0:
                    reward = "���J�����J����";
                    break;
                case 1:
                    reward = "�h���[�����{�P";
                    break;
                case 2:
                    reward = "�h���[���@�\�g��";
                    break;
                case 3:
                    reward = "�������l��";
                    break;

            }
        }

        missionReward_2.GetComponent<Text>().text = reward;
    }
}
