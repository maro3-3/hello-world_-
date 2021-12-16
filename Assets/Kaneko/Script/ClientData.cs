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
        public int[] CHN_Beijing_CountryNo;        // ���i���o�[
        public int[] CHN_Beijing_ClientAreaNo;           // �n��i���o�[
        public int[] CHN_Beijing_ClientNo;               // �N���C�A���g�i���o�[
        public string[] CHN_Beijing_ClientName;          // �N���C�A���g�l�[��
        public int[] CHN_Beijing_ClientLv;               // �N���C�A���g���x��
        public int[] CHN_Beijing_ClientType;             // �Ɛу^�C�v
        public int[] CHN_Beijing_T1;          // ������i�����@�l�`�w�U�� �j
        public int[] CHN_Beijing_T2;          // ������i�����@�l�`�w�U�� �j
        public int[] CHN_Beijing_T3;          // ������i�����@�l�`�w�U�� �j
        public int[] CHN_Beijing_T4;          // ������i�����@�l�`�w�U�� �j
        public int[] CHN_Beijing_T5;          // ������i�����@�l�`�w�U�� �j
        public int[] CHN_Beijing_T6;          // ������i�����@�l�`�w�U�� �j

        public int[] Transaction;             // �����
        public int[] TransactionStatus;       // �����
        public string[] ManufacturerName;     // �������
        public int[] Performance;             // �Ɛ�

        public int[] CHN_Beijing_RN1;           // ������v�����H
        public int[] CHN_Beijing_RN2;           // ������v�����H
        public int[] CHN_Beijing_RN3;           // ������v�����H
        public int[] CHN_Beijing_RN4;           // ������v�����H
        public int[] CHN_Beijing_RN5;           // ������v�����H
        public int[] CHN_Beijing_RN6;           // ������v�����H

        public int[] CHN_Beijing_AmoPayH1;      // ������x���z�HHigh
        public int[] CHN_Beijing_AmoPayH2;      // ������x���z�H
        public int[] CHN_Beijing_AmoPayH3;      // ������x���z�H
        public int[] CHN_Beijing_AmoPayH4;      // ������x���z�H
        public int[] CHN_Beijing_AmoPayH5;      // ������x���z�H
        public int[] CHN_Beijing_AmoPayH6;      // ������x���z�H

        public int[] CHN_Beijing_AmoPayM1;      // ������x���z�HMid
        public int[] CHN_Beijing_AmoPayM2;      // ������x���z�H
        public int[] CHN_Beijing_AmoPayM3;      // ������x���z�H
        public int[] CHN_Beijing_AmoPayM4;      // ������x���z�H
        public int[] CHN_Beijing_AmoPayM5;      // ������x���z�H
        public int[] CHN_Beijing_AmoPayM6;      // ������x���z�H

        public int[] CHN_Beijing_AmoPayL1;  �@�@// ������x���z�HLow
        public int[] CHN_Beijing_AmoPayL2;  �@�@// ������x���z�H
        public int[] CHN_Beijing_AmoPayL3;  �@�@// ������x���z�H
        public int[] CHN_Beijing_AmoPayL4;  �@�@// ������x���z�H
        public int[] CHN_Beijing_AmoPayL5;  �@�@// ������x���z�H
        public int[] CHN_Beijing_AmoPayL6;    // ������x���z�H

        // �������֐�
        public void CHN_Beijing_Init()
        {
            CHN_Beijing_CountryNo = new int[2]; CHN_Beijing_ClientAreaNo = new int[2];
            CHN_Beijing_ClientNo = new int[2]; CHN_Beijing_ClientName = new string[2];
            CHN_Beijing_ClientLv = new int[2]; CHN_Beijing_ClientType = new int[2];
            CHN_Beijing_T1 = new int[2]; CHN_Beijing_T2 = new int[2];
            CHN_Beijing_T3 = new int[2]; CHN_Beijing_T4 = new int[2];
            CHN_Beijing_T5 = new int[2]; CHN_Beijing_T6 = new int[2];
            CHN_Beijing_RN1 = new int[2]; CHN_Beijing_RN2 = new int[2];
            CHN_Beijing_RN3 = new int[2]; CHN_Beijing_RN4 = new int[2];
            CHN_Beijing_RN5 = new int[2]; CHN_Beijing_RN6 = new int[2];
            CHN_Beijing_AmoPayH1 =new int[2]; CHN_Beijing_AmoPayH2 =new int[2];
            CHN_Beijing_AmoPayH3 =new int[2]; CHN_Beijing_AmoPayH4 =new int[2];
            CHN_Beijing_AmoPayH5 =new int[2]; CHN_Beijing_AmoPayH6 =new int[2];
            CHN_Beijing_AmoPayM1 =new int[2]; CHN_Beijing_AmoPayM2 =new int[2];
            CHN_Beijing_AmoPayM3 =new int[2]; CHN_Beijing_AmoPayM4 =new int[2];
            CHN_Beijing_AmoPayM5 =new int[2]; CHN_Beijing_AmoPayM6 =new int[2];
            CHN_Beijing_AmoPayL1 =new int[2]; CHN_Beijing_AmoPayL2 =new int[2];
            CHN_Beijing_AmoPayL3 =new int[2]; CHN_Beijing_AmoPayL4 =new int[2];
            CHN_Beijing_AmoPayL5 =new int[2]; CHN_Beijing_AmoPayL6 = new int[2];
            Transaction = new int[2]; TransactionStatus = new int[2];
            ManufacturerName = new string[2]; Performance = new int[2];
        }
        public void InitCHN_Beijing_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int index)
        {


            CHN_Beijing_CountryNo[index] = clientCountryNo;
            CHN_Beijing_ClientAreaNo[index] = clientAreaNo;
            CHN_Beijing_ClientNo[index] = clientNo;
            CHN_Beijing_ClientName[index] = clientName;
            CHN_Beijing_ClientLv[index] = clientLv;
            CHN_Beijing_ClientType[index] = clientType;
            CHN_Beijing_T1[index] = t1;
            CHN_Beijing_T2[index] = t2;
            CHN_Beijing_T3[index] = t3;
            CHN_Beijing_T4[index] = t4;
            CHN_Beijing_T5[index] = t5;
            CHN_Beijing_T6[index] = t6;
            Transaction[index] = transaction;
            TransactionStatus[index] = transactionStatus;
            ManufacturerName[index] = manufacturerName;
            Performance[index] = performance;

        }
        public void CHN_Beijing_TransactionInit(int rn1, int rn2, int rn3, int rn4, int rn5, int rn6, int h1, int h2, int h3, int h4, int h5, int h6,
                                                int m1, int m2, int m3, int m4, int m5, int m6, int l1, int l2, int l3, int l4, int l5, int l6, int index)
        {
            CHN_Beijing_RN1[index] = rn1;
            CHN_Beijing_RN2[index] = rn2;
            CHN_Beijing_RN3[index] = rn3;
            CHN_Beijing_RN4[index] = rn4;
            CHN_Beijing_RN5[index] = rn5;
            CHN_Beijing_RN6[index] = rn6;
            CHN_Beijing_AmoPayH1[index] = h1;
            CHN_Beijing_AmoPayH2[index] = h2;
            CHN_Beijing_AmoPayH3[index] = h3;
            CHN_Beijing_AmoPayH4[index] = h4;
            CHN_Beijing_AmoPayH5[index] = h5;
            CHN_Beijing_AmoPayH6[index] = h6;
            CHN_Beijing_AmoPayM1[index] = m1;
            CHN_Beijing_AmoPayM2[index] = m2;
            CHN_Beijing_AmoPayM3[index] = m3;
            CHN_Beijing_AmoPayM4[index] = m4;
            CHN_Beijing_AmoPayM5[index] = m5;
            CHN_Beijing_AmoPayM6[index] = m6;
            CHN_Beijing_AmoPayL1[index] = l1;
            CHN_Beijing_AmoPayL2[index] = l2;
            CHN_Beijing_AmoPayL3[index] = l3;
            CHN_Beijing_AmoPayL4[index] = l4;
            CHN_Beijing_AmoPayL5[index] = l5;
            CHN_Beijing_AmoPayL6[index] = l6;
        }
    };
    public CHN_Beijing_Client[] CHN_Beijing_Clients = new CHN_Beijing_Client[20];

    // ������C�N���C�A���g // 
    //public struct CHN_Shanghai_Client
    //{
    //    public int[] ClientCountryNo;        // ���i���o�[
    //    public int[] ClientAreaNo;           // �n��i���o�[
    //    public int[] ClientNo;               // �N���C�A���g�i���o�[
    //    public string[] ClientName;          // �N���C�A���g�l�[��
    //    public int[] ClientLv;               // �N���C�A���g���x��
    //    public int[] ClientType;             // �Ɛу^�C�v
    //    public int[] Transaction_1;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_2;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_3;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_4;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_5;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_6;          // ������i�����@�l�`�w�U�� �j

    //    public int[] Transaction;             // �����
    //    public int[] TransactionStatus;       // �����
    //    public string[] ManufacturerName;     // �������
    //    public int[] Performance;             // �Ɛ�


    //    // �������֐�
    //    public void InitCHN_Shanghai_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
    //                           int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
    //                           int transaction, int transactionStatus, string manufacturerName, int performance, int index)
    //    {
    //        ClientNo = new int[3]; ClientName = new string[3];
    //        ClientLv = new int[3]; ClientType = new int[3];
    //        Transaction_1 = new int[3]; Transaction_2 = new int[3];
    //        Transaction_3 = new int[3]; Transaction_4 = new int[3];
    //        Transaction_5 = new int[3]; Transaction_6 = new int[3];

    //        Transaction = new int[3]; TransactionStatus = new int[3];
    //        ManufacturerName = new string[3]; Performance = new int[3];

    //        ClientCountryNo = clientCountryNo;
    //        ClientAreaNo = clientAreaNo;
    //        ClientNo[index] = clientNo;
    //        ClientName[index] = clientName;
    //        ClientLv[index] = clientLv;
    //        ClientType[index] = clientType;
    //        Transaction_1[index] = t1;
    //        Transaction_2[index] = t2;
    //        Transaction_3[index] = t3;
    //        Transaction_4[index] = t4;
    //        Transaction_5[index] = t5;
    //        Transaction_6[index] = t6;
    //        Transaction[index] = transaction;
    //        TransactionStatus[index] = transactionStatus;
    //        ManufacturerName[index] = manufacturerName;
    //        Performance[index] = performance;
    //    }
    //};
    //public CHN_Shanghai_Client[] CHN_Shanghai_Clients = new CHN_Shanghai_Client[20];

    //// �����l��N���C�A���g // 
    //public struct CHN_Sichuan_Client
    //{
    //    public int ClientCountryNo;        // ���i���o�[
    //    public int ClientAreaNo;           // �n��i���o�[
    //    public int[] ClientNo;               // �N���C�A���g�i���o�[
    //    public string[] ClientName;          // �N���C�A���g�l�[��
    //    public int[] ClientLv;               // �N���C�A���g���x��
    //    public int[] ClientType;             // �Ɛу^�C�v
    //    public int[] Transaction_1;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_2;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_3;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_4;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_5;          // ������i�����@�l�`�w�U�� �j
    //    public int[] Transaction_6;          // ������i�����@�l�`�w�U�� �j

    //    public int[] Transaction;             // �����
    //    public int[] TransactionStatus;       // �����
    //    public string[] ManufacturerName;     // �������
    //    public int[] Performance;             // �Ɛ�


    //    // �������֐�
    //    public void InitCHN_Sichuan_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
    //                           int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
    //                           int transaction, int transactionStatus, string manufacturerName, int performance, int index)
    //    {
    //        ClientNo = new int[4]; ClientName = new string[4];
    //        ClientLv = new int[4]; ClientType = new int[4];
    //        Transaction_1 = new int[4]; Transaction_2 = new int[4];
    //        Transaction_3 = new int[4]; Transaction_4 = new int[4];
    //        Transaction_5 = new int[4]; Transaction_6 = new int[4];

    //        Transaction = new int[4]; TransactionStatus = new int[4];
    //        ManufacturerName = new string[4]; Performance = new int[4];

    //        ClientCountryNo = clientCountryNo;
    //        ClientAreaNo = clientAreaNo;
    //        ClientNo[index] = clientNo;
    //        ClientName[index] = clientName;
    //        ClientLv[index] = clientLv;
    //        ClientType[index] = clientType;
    //        Transaction_1[index] = t1;
    //        Transaction_2[index] = t2;
    //        Transaction_3[index] = t3;
    //        Transaction_4[index] = t4;
    //        Transaction_5[index] = t5;
    //        Transaction_6[index] = t6;
    //        Transaction[index] = transaction;
    //        TransactionStatus[index] = transactionStatus;
    //        ManufacturerName[index] = manufacturerName;
    //        Performance[index] = performance;
    //    }
    //};
    //public CHN_Sichuan_Client[] CHN_Sichuan_Clients = new CHN_Sichuan_Client[20];
}
