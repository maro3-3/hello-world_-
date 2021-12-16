using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ClientData : ScriptableObject
{
    // 僋儔僀傾儞僩 //
    // 拞崙杒嫗僋儔僀傾儞僩 // 
    public struct CHN_Beijing_Client
    {
        public int CHN_Beijing_CountryNo;                      // 崙僫儞僶乕
        public int CHN_Beijing_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int CHN_Beijing_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string CHN_Beijing_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int CHN_Beijing_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int CHN_Beijing_ClientType;                     // 嬈愌僞僀僾
        public int[] CHN_Beijing_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int CHN_Beijing_Transaction;                    // 庢堷暔
        public int CHN_Beijing_TransactionStatus;              // 庢堷忬嫷
        public string CHN_Beijing_ManufacturerName;            // 庢堷憡庤
        public int CHN_Beijing_Performance;                    // 嬈愌
        public int[] CHN_Beijing_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] CHN_Beijing_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] CHN_Beijing_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] CHN_Beijing_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] CHN_Beijing_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] CHN_Beijing_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] CHN_Beijing_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int CHN_Beijing_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int CHN_Beijing_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
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

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
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
        // 巟暐妟弶婜壔
        public void CHN_Beijing_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            CHN_Beijing_ContractAmoPay[n] = 0;
            CHN_Beijing_RequNum[n] = rn;
            CHN_Beijing_AmoPayHigh[n] = apH;
            CHN_Beijing_AmoPayMid[n] = apM;
            CHN_Beijing_AmoPayLow[n] = amL;
        }

        // 嬈愌僞僀僾暿曄摦抣愝掕丂寧弶傔偵屇傇
        public void FluctuationValue(int clienttype)
        {

            float random = 0.0f;

            switch (clienttype)
            {
                // 埨掕僞僀僾
                case 0:
                    random = Random.value;
                    if (random <= 0.4)
                        CHN_Beijing_Performance += 0;
                    else if (random <= 0.7)
                        CHN_Beijing_Performance += -30;
                    else
                        CHN_Beijing_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
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
                // 怟壓偑傝僞僀僾
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
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        CHN_Beijing_Performance += 200;
                    else
                        CHN_Beijing_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum , int amoPay ,int performance , int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i =  1; i <= 20;i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
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

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = CHN_Beijing_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            CHN_Beijing_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public CHN_Beijing_Client[] CHN_Beijing_Clients = new CHN_Beijing_Client[20];
}
