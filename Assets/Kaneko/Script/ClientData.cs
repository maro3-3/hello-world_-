using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ClientData : ScriptableObject
{
    // �N���C�A���g //
    // �����k���N���C�A���g // 
    public struct CHN_Beijing_Client
    {
        public int CHN_Beijing_CountryNo;                      // ���i���o�[
        public int CHN_Beijing_ClientAreaNo;                   // �n��i���o�[
        public int CHN_Beijing_ClientNo;                       // �N���C�A���g�i���o�[
        public string CHN_Beijing_ClientName;                  // �N���C�A���g�l�[��
        public int CHN_Beijing_ClientLv;                       // �N���C�A���g���x��
        public int CHN_Beijing_ClientType;                     // �Ɛу^�C�v
        public int[] CHN_Beijing_Transactions;                 // ������i�����@�l�`�w�U�� �j

        public int CHN_Beijing_Transaction;                    // �����
        public int CHN_Beijing_TransactionStatus;              // �����
        public string CHN_Beijing_ManufacturerName;            // �������
        public int CHN_Beijing_Performance;                    // �Ɛ�
        public int[] CHN_Beijing_DisplayingPerformance;        // �\�����Ɛ�
        public int[] CHN_Beijing_UpdatePerformance;            // �ŐV�̋Ɛ�
        public int[] CHN_Beijing_ContractAmoPay;               // �_��x���z�@�����O���_�񎞂Ɍ��܂����z�������  �i��������j     

        public int[] CHN_Beijing_RequNum;                      // ������v�����H
        public int[] CHN_Beijing_AmoPayHigh;                   // ������x���z�HHigh        
        public int[] CHN_Beijing_AmoPayMid;                    // ������x���z�HMid
        public int[] CHN_Beijing_AmoPayLow;  �@ �@             // ������x���z�HLow

        public int CHN_Beijing_FluctuationPoint;               // �K������or�K������^�C�v�̎��ɂ̂ݎg�p�@�R��ɂP��ϓ��ʂ���������
        public int CHN_Beijing_In_de_CreaseValue;              // �K������or�K������^�C�v�̎��ɂ̂ݎg�p�@�R��ɂP�񑝌������l��ێ�


        // �z�񏉊���
        public void CHN_Beijing_Init()
        {
            CHN_Beijing_Transactions = new int[6];
            CHN_Beijing_DisplayingPerformance = new int[4];
            CHN_Beijing_UpdatePerformance = new int[4];
            CHN_Beijing_ContractAmoPay = new int[6];
            CHN_Beijing_RequNum = new int[6];
            CHN_Beijing_AmoPayHigh = new int[6];
            CHN_Beijing_AmoPayMid = new int[6];
            CHN_Beijing_AmoPayLow = new int[6];

        }

        // �N���C�A���g��b�������i���E�n��E���ް�E���O�E���x���E�^�C�v�E�����1�2�3�4�5�6�E������H�E����󋵁E�������E�ƐсE�ϓ��l�E�ϓ��l�ێ��E�v�f�ԍ��j
        public void InitCHN_Beijing_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            CHN_Beijing_CountryNo= clientCountryNo;
            CHN_Beijing_ClientAreaNo = clientAreaNo;
            CHN_Beijing_ClientNo = clientNo;
            CHN_Beijing_ClientName = clientName;
            CHN_Beijing_ClientLv = clientLv;
            CHN_Beijing_ClientType = clientType;
            CHN_Beijing_Transactions[0] = t1;
            CHN_Beijing_Transactions[1] = t2;
            CHN_Beijing_Transactions[2] = t3;
            CHN_Beijing_Transactions[3] = t4;
            CHN_Beijing_Transactions[4] = t5;
            CHN_Beijing_Transactions[5] = t6;
            CHN_Beijing_Transaction = transaction;
            CHN_Beijing_TransactionStatus = transactionStatus;
            CHN_Beijing_ManufacturerName = manufacturerName;
            CHN_Beijing_Performance = performance;
            CHN_Beijing_FluctuationPoint = fluctuationPoint;
            CHN_Beijing_In_de_CreaseValue = in_de_CreaseValue;
        }
        // �x���z������
        public void CHN_Beijing_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            CHN_Beijing_ContractAmoPay[n] = 0;
            CHN_Beijing_RequNum[n] = rn;
            CHN_Beijing_AmoPayHigh[n] = apH;
            CHN_Beijing_AmoPayMid[n] = apM;
            CHN_Beijing_AmoPayLow[n] = amL;
        }

        // �Ɛу^�C�v�ʕϓ��l�ݒ�@�����߂ɌĂ�
        public void FluctuationValue(int clienttype)
        {

            float random = 0.0f;

            switch (clienttype)
            {
                // ����^�C�v
                case 0:
                    random = Random.value;
                    if (random <= 0.4)
                        CHN_Beijing_Performance += 0;
                    else if (random <= 0.7)
                        CHN_Beijing_Performance += -30;
                    else
                        CHN_Beijing_Performance += +30;
                    break;
                // �K�オ��^�C�v
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        CHN_Beijing_FluctuationPoint += 1;
                        if (CHN_Beijing_FluctuationPoint >= 3)
                        {
                            CHN_Beijing_In_de_CreaseValue += 20;
                            CHN_Beijing_Performance += (50 + CHN_Beijing_In_de_CreaseValue);
                            if (CHN_Beijing_Performance >= 150)
                                CHN_Beijing_Performance += 150;
                            CHN_Beijing_FluctuationPoint = 0;
                        }
                        else
                            CHN_Beijing_Performance += 50;
                    }
                    else
                        CHN_Beijing_Performance += -50;
                    break;
                // �K������^�C�v
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        CHN_Beijing_FluctuationPoint += 1;
                        if (CHN_Beijing_FluctuationPoint >= 3)
                        {
                            CHN_Beijing_In_de_CreaseValue -= 20;
                            CHN_Beijing_Performance += (-50 + CHN_Beijing_In_de_CreaseValue);
                            if (CHN_Beijing_Performance <= -150)
                                CHN_Beijing_Performance += -150;
                            CHN_Beijing_FluctuationPoint = 0;
                        }
                        else
                            CHN_Beijing_Performance += -50;
                    }
                    else
                        CHN_Beijing_Performance += 50;
                    break;
                // �s�[�L�[�^�C�v
                case 3:
                    if (random <= 0.5)
                        CHN_Beijing_Performance += 200;
                    else
                        CHN_Beijing_Performance += -200;
                    break;
            }

        }

        // �v����/�x���z�@�����^�C�~���O
        public void Requ_Pay_In_de_crease(int requNum , int amoPay ,int performance , int index)
        {
            // �v�������[�P�Ȃ�Ԃ�
            if (requNum == -1)
                return;

            // �Ɛт��P�O�O�����Ȃ�Ԃ�
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i =  1; i <= 20;i++)
            {
                if (IsExit == true)
                    break;
                // 100�ȏ�200����
                if (performance >= (100*i) && performance < (100*(i+1)))
                {
                    CHN_Beijing_RequNum[index] = requNum + (100*i);
                    IsExit = true;
                }
                else if (performance <= (-100*i) && performance > (-100*(i+1)))
                {
                    CHN_Beijing_RequNum[index] = requNum - (100*i);
                    if(CHN_Beijing_RequNum[index] < 100)
                        CHN_Beijing_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // �ϓ���v���� / ���v����
            float requN = requNum; // ���v����
            float UpdaterequN = CHN_Beijing_RequNum[index]; // �ϓ���̗v����
            float AmoP = amoPay;        // ���x���z
            float UpdateAmoP = 0.0f;    // �ϓ���̎x���z

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            CHN_Beijing_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public CHN_Beijing_Client[] CHN_Beijing_Clients = new CHN_Beijing_Client[20];
}
