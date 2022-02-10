using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Drone1_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase database = null;

    GameObject drone;

    public static bool[] droneflag;
    public static int[] droneCount;
    public static int[] dronePattern;
    public static int[] droneErea;

    [SerializeField] GameObject icon1;
    [SerializeField] int ereapool;
    GameObject target1;
    Transform target2;
    Transform target3;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        drone = GameObject.Find("DroneManager");
     
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < database.PossessionDroneNum; i++)
        {
            if (droneflag[i] == true)
            {
                switch (dronePattern[i])
                {
                    case 0:
                        drone1(i);
                        break;
                    case 1:
                        drone2(i);
                        break;
                    case 2:
                        drone3(i);
                        break;
                }
            }
        }
    }

    public void OnClick(int num)
    {
        if (database.PossessionDroneNum >= 1)
        {
            switch (num)
            {
                case 0:
                    for (int i = 0; i < database.PossessionDroneNum; i++)
                    {
                        if (droneflag[i] == false)
                        {
                            drone.GetComponent<drone_ishikado>().setdrone(i);
                            droneflag[i] = true;
                            dronePattern[i] = 0;
                            droneCount[i] = drone_ishikado.TurnCount[i];
                            icon1.SetActive(true);
                            database.TempingDroneNum++;
                            droneErea[i] = ereapool;
                            break;
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < database.PossessionDroneNum; i++)
                    {
                        if (droneflag[i] == false)
                        {
                            drone.GetComponent<drone_ishikado>().setdrone(i);
                            droneflag[i] = true;
                            dronePattern[i] = 1;
                            droneCount[i] = drone_ishikado.TurnCount[i];
                            icon1.SetActive(true);
                            database.TempingDroneNum++;
                            droneErea[i] = ereapool;
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < database.PossessionDroneNum; i++)
                    {
                        if (droneflag[i] == false)
                        {
                            drone.GetComponent<drone_ishikado>().setdrone(i);
                            droneflag[i] = true;
                            dronePattern[i] = 2;
                            droneCount[i] = drone_ishikado.TurnCount[i];
                            icon1.SetActive(true);
                            database.TempingDroneNum++;
                            droneErea[i] = ereapool;
                            break;
                        }
                    }
                    break;
            }
        }
        else
        {
            return;
        }
          
    }

    void drone1(int num)
    {
        if (droneCount[num] + 2 == database.TurnNum)
        {
           
            switch (droneErea[num])
            {
                case 0:
                    target1 = GameObject.Find("�k��");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 1:
                    target1 = GameObject.Find("��C");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 2:
                    target1 = GameObject.Find("�l��");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 3:
                    target1 = GameObject.Find("�j���[���[�N");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 4:
                    target1 = GameObject.Find("�Z���g���C�X");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 5:
                    target1 = GameObject.Find("�A�g�����^");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 6:
                    target1 = GameObject.Find("���X�N��");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 7:
                    target1 = GameObject.Find("�E�t�@");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 8:
                    target1 = GameObject.Find("�L�����x��");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 9:
                    target1 = GameObject.Find("�p�[�X");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 10:
                    target1 = GameObject.Find("�����{����");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 11:
                    target1 = GameObject.Find("�v���g���A");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 12:
                    target1 = GameObject.Find("�u���[���t�H���e�C��");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 13:
                    target1 = GameObject.Find("�P�[�v�^�E��");//�n�於
                    target2 = target1.transform.Find("DroneResult1");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
            }

            //  Transform.Find
            target2.gameObject.SetActive(true);
            target3.gameObject.SetActive(false);
            droneflag[num] = false;
            database.TempingDroneNum--;

            int poolUnemployed = 0;
            for (int i = 0; i < 14; i++)
            {
                poolUnemployed += database.unemployed[i].CurrentUnemployedNum;
            }
            database.UnemployedNum = poolUnemployed;
        }
    }

    void drone2(int num)
    {

        if (droneCount[num] + 2 == database.TurnNum)
        {

            switch (droneErea[num])
            {
                case 0:
                    target1 = GameObject.Find("�k��");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 1:
                    target1 = GameObject.Find("��C");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 2:
                    target1 = GameObject.Find("�l��");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 3:
                    target1 = GameObject.Find("�j���[���[�N");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 4:
                    target1 = GameObject.Find("�Z���g���C�X");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 5:
                    target1 = GameObject.Find("�A�g�����^");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 6:
                    target1 = GameObject.Find("���X�N��");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 7:
                    target1 = GameObject.Find("�E�t�@");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 8:
                    target1 = GameObject.Find("�L�����x��");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 9:
                    target1 = GameObject.Find("�p�[�X");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 10:
                    target1 = GameObject.Find("�����{����");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 11:
                    target1 = GameObject.Find("�v���g���A");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 12:
                    target1 = GameObject.Find("�u���[���t�H���e�C��");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 13:
                    target1 = GameObject.Find("�P�[�v�^�E��");//�n�於
                    target2 = target1.transform.Find("DroneResult2");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
            }

            //  Transform.Find
            target2.gameObject.SetActive(true);
            target3.gameObject.SetActive(false);
            droneflag[num] = false;
            database.TempingDroneNum--;
        }
    }

    void drone3(int num)
    {
        if (droneCount[num] + 2 == database.TurnNum)
        {

            switch (droneErea[num])
            {
                case 0:
                    target1 = GameObject.Find("�k��");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 1:
                    target1 = GameObject.Find("��C");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 2:
                    target1 = GameObject.Find("�l��");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 3:
                    target1 = GameObject.Find("�j���[���[�N");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 4:
                    target1 = GameObject.Find("�Z���g���C�X");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 5:
                    target1 = GameObject.Find("�A�g�����^");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 6:
                    target1 = GameObject.Find("���X�N��");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 7:
                    target1 = GameObject.Find("�E�t�@");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 8:
                    target1 = GameObject.Find("�L�����x��");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 9:
                    target1 = GameObject.Find("�p�[�X");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 10:
                    target1 = GameObject.Find("�����{����");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 11:
                    target1 = GameObject.Find("�v���g���A");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 12:
                    target1 = GameObject.Find("�u���[���t�H���e�C��");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
                case 13:
                    target1 = GameObject.Find("�P�[�v�^�E��");//�n�於
                    target2 = target1.transform.Find("DroneResult3");//�h���[���A�҂̃I�u�W�F�N�g��
                    target3 = target1.transform.Find("DroneWork");//�d�����̃A�C�R����
                    break;
            }

            //  Transform.Find
            target2.gameObject.SetActive(true);
            target3.gameObject.SetActive(false);
            droneflag[num] = false;
            database.TempingDroneNum--;
        }
    }
}
