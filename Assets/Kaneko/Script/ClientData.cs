using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ClientData : ScriptableObject
{
    // 拞崙丂杒嫗僋儔僀傾儞僩 // 
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

    // 拞崙丂忋奀僋儔僀傾儞僩 //
    public struct CHN_Shanghai_Client
    {
        public int CHN_Shanghai_CountryNo;                      // 崙僫儞僶乕
        public int CHN_Shanghai_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int CHN_Shanghai_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string CHN_Shanghai_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int CHN_Shanghai_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int CHN_Shanghai_ClientType;                     // 嬈愌僞僀僾
        public int[] CHN_Shanghai_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int CHN_Shanghai_Transaction;                    // 庢堷暔
        public int CHN_Shanghai_TransactionStatus;              // 庢堷忬嫷
        public string CHN_Shanghai_ManufacturerName;            // 庢堷憡庤
        public int CHN_Shanghai_Performance;                    // 嬈愌
        public int[] CHN_Shanghai_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] CHN_Shanghai_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] CHN_Shanghai_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] CHN_Shanghai_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] CHN_Shanghai_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] CHN_Shanghai_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] CHN_Shanghai_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int CHN_Shanghai_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int CHN_Shanghai_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void CHN_Shanghai_Init()
        {
            CHN_Shanghai_Transactions = new int[6];
            CHN_Shanghai_DisplayingPerformance = new int[4];
            CHN_Shanghai_UpdatePerformance = new int[4];
            CHN_Shanghai_ContractAmoPay = new int[6];
            CHN_Shanghai_RequNum = new int[6];
            CHN_Shanghai_AmoPayHigh = new int[6];
            CHN_Shanghai_AmoPayMid = new int[6];
            CHN_Shanghai_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitCHN_Shanghai_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            CHN_Shanghai_CountryNo = clientCountryNo;
            CHN_Shanghai_ClientAreaNo = clientAreaNo;
            CHN_Shanghai_ClientNo = clientNo;
            CHN_Shanghai_ClientName = clientName;
            CHN_Shanghai_ClientLv = clientLv;
            CHN_Shanghai_ClientType = clientType;
            CHN_Shanghai_Transactions[0] = t1;
            CHN_Shanghai_Transactions[1] = t2;
            CHN_Shanghai_Transactions[2] = t3;
            CHN_Shanghai_Transactions[3] = t4;
            CHN_Shanghai_Transactions[4] = t5;
            CHN_Shanghai_Transactions[5] = t6;
            CHN_Shanghai_Transaction = transaction;
            CHN_Shanghai_TransactionStatus = transactionStatus;
            CHN_Shanghai_ManufacturerName = manufacturerName;
            CHN_Shanghai_Performance = performance;
            CHN_Shanghai_FluctuationPoint = fluctuationPoint;
            CHN_Shanghai_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void CHN_Shanghai_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            CHN_Shanghai_ContractAmoPay[n] = 0;
            CHN_Shanghai_RequNum[n] = rn;
            CHN_Shanghai_AmoPayHigh[n] = apH;
            CHN_Shanghai_AmoPayMid[n] = apM;
            CHN_Shanghai_AmoPayLow[n] = amL;
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
                        CHN_Shanghai_Performance += 0;
                    else if (random <= 0.7)
                        CHN_Shanghai_Performance += -30;
                    else
                        CHN_Shanghai_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        CHN_Shanghai_FluctuationPoint += 1;
                        if (CHN_Shanghai_FluctuationPoint >= 3)
                        {
                            CHN_Shanghai_In_de_CreaseValue += 20;
                            CHN_Shanghai_Performance += (50 + CHN_Shanghai_In_de_CreaseValue);
                            if (CHN_Shanghai_Performance >= 150)
                                CHN_Shanghai_Performance += 150;
                            CHN_Shanghai_FluctuationPoint = 0;
                        }
                        else
                            CHN_Shanghai_Performance += 50;
                    }
                    else
                        CHN_Shanghai_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        CHN_Shanghai_FluctuationPoint += 1;
                        if (CHN_Shanghai_FluctuationPoint >= 3)
                        {
                            CHN_Shanghai_In_de_CreaseValue -= 20;
                            CHN_Shanghai_Performance += (-50 + CHN_Shanghai_In_de_CreaseValue);
                            if (CHN_Shanghai_Performance <= -150)
                                CHN_Shanghai_Performance += -150;
                            CHN_Shanghai_FluctuationPoint = 0;
                        }
                        else
                            CHN_Shanghai_Performance += -50;
                    }
                    else
                        CHN_Shanghai_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        CHN_Shanghai_Performance += 200;
                    else
                        CHN_Shanghai_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    CHN_Shanghai_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    CHN_Shanghai_RequNum[index] = requNum - (100 * i);
                    if (CHN_Shanghai_RequNum[index] < 100)
                        CHN_Shanghai_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = CHN_Shanghai_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            CHN_Shanghai_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public CHN_Shanghai_Client[] CHN_Shanghai_Clients = new CHN_Shanghai_Client[20];

    // 拞崙丂巐愳僋儔僀傾儞僩 // 
    public struct CHN_Sichuan_Client
    {
        public int CHN_Sichuan_CountryNo;                      // 崙僫儞僶乕
        public int CHN_Sichuan_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int CHN_Sichuan_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string CHN_Sichuan_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int CHN_Sichuan_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int CHN_Sichuan_ClientType;                     // 嬈愌僞僀僾
        public int[] CHN_Sichuan_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int CHN_Sichuan_Transaction;                    // 庢堷暔
        public int CHN_Sichuan_TransactionStatus;              // 庢堷忬嫷
        public string CHN_Sichuan_ManufacturerName;            // 庢堷憡庤
        public int CHN_Sichuan_Performance;                    // 嬈愌
        public int[] CHN_Sichuan_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] CHN_Sichuan_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] CHN_Sichuan_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] CHN_Sichuan_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] CHN_Sichuan_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] CHN_Sichuan_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] CHN_Sichuan_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int CHN_Sichuan_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int CHN_Sichuan_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void CHN_Sichuan_Init()
        {
            CHN_Sichuan_Transactions = new int[6];
            CHN_Sichuan_DisplayingPerformance = new int[4];
            CHN_Sichuan_UpdatePerformance = new int[4];
            CHN_Sichuan_ContractAmoPay = new int[6];
            CHN_Sichuan_RequNum = new int[6];
            CHN_Sichuan_AmoPayHigh = new int[6];
            CHN_Sichuan_AmoPayMid = new int[6];
            CHN_Sichuan_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitCHN_Sichuan_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            CHN_Sichuan_CountryNo = clientCountryNo;
            CHN_Sichuan_ClientAreaNo = clientAreaNo;
            CHN_Sichuan_ClientNo = clientNo;
            CHN_Sichuan_ClientName = clientName;
            CHN_Sichuan_ClientLv = clientLv;
            CHN_Sichuan_ClientType = clientType;
            CHN_Sichuan_Transactions[0] = t1;
            CHN_Sichuan_Transactions[1] = t2;
            CHN_Sichuan_Transactions[2] = t3;
            CHN_Sichuan_Transactions[3] = t4;
            CHN_Sichuan_Transactions[4] = t5;
            CHN_Sichuan_Transactions[5] = t6;
            CHN_Sichuan_Transaction = transaction;
            CHN_Sichuan_TransactionStatus = transactionStatus;
            CHN_Sichuan_ManufacturerName = manufacturerName;
            CHN_Sichuan_Performance = performance;
            CHN_Sichuan_FluctuationPoint = fluctuationPoint;
            CHN_Sichuan_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void CHN_Sichuan_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            CHN_Sichuan_ContractAmoPay[n] = 0;
            CHN_Sichuan_RequNum[n] = rn;
            CHN_Sichuan_AmoPayHigh[n] = apH;
            CHN_Sichuan_AmoPayMid[n] = apM;
            CHN_Sichuan_AmoPayLow[n] = amL;
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
                        CHN_Sichuan_Performance += 0;
                    else if (random <= 0.7)
                        CHN_Sichuan_Performance += -30;
                    else
                        CHN_Sichuan_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        CHN_Sichuan_FluctuationPoint += 1;
                        if (CHN_Sichuan_FluctuationPoint >= 3)
                        {
                            CHN_Sichuan_In_de_CreaseValue += 20;
                            CHN_Sichuan_Performance += (50 + CHN_Sichuan_In_de_CreaseValue);
                            if (CHN_Sichuan_Performance >= 150)
                                CHN_Sichuan_Performance += 150;
                            CHN_Sichuan_FluctuationPoint = 0;
                        }
                        else
                            CHN_Sichuan_Performance += 50;
                    }
                    else
                        CHN_Sichuan_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        CHN_Sichuan_FluctuationPoint += 1;
                        if (CHN_Sichuan_FluctuationPoint >= 3)
                        {
                            CHN_Sichuan_In_de_CreaseValue -= 20;
                            CHN_Sichuan_Performance += (-50 + CHN_Sichuan_In_de_CreaseValue);
                            if (CHN_Sichuan_Performance <= -150)
                                CHN_Sichuan_Performance += -150;
                            CHN_Sichuan_FluctuationPoint = 0;
                        }
                        else
                            CHN_Sichuan_Performance += -50;
                    }
                    else
                        CHN_Sichuan_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        CHN_Sichuan_Performance += 200;
                    else
                        CHN_Sichuan_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    CHN_Sichuan_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    CHN_Sichuan_RequNum[index] = requNum - (100 * i);
                    if (CHN_Sichuan_RequNum[index] < 100)
                        CHN_Sichuan_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = CHN_Sichuan_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            CHN_Sichuan_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public CHN_Sichuan_Client[] CHN_Sichuan_Clients = new CHN_Sichuan_Client[20];

    // 傾儊儕僇丂僯儏乕儓乕僋僋儔僀傾儞僩 // 
    public struct USA_NewYork_Client
    {
        public int USA_NewYork_CountryNo;                      // 崙僫儞僶乕
        public int USA_NewYork_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int USA_NewYork_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string USA_NewYork_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int USA_NewYork_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int USA_NewYork_ClientType;                     // 嬈愌僞僀僾
        public int[] USA_NewYork_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int USA_NewYork_Transaction;                    // 庢堷暔
        public int USA_NewYork_TransactionStatus;              // 庢堷忬嫷
        public string USA_NewYork_ManufacturerName;            // 庢堷憡庤
        public int USA_NewYork_Performance;                    // 嬈愌
        public int[] USA_NewYork_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] USA_NewYork_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] USA_NewYork_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] USA_NewYork_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] USA_NewYork_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] USA_NewYork_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] USA_NewYork_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int USA_NewYork_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int USA_NewYork_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void USA_NewYork_Init()
        {
            USA_NewYork_Transactions = new int[6];
            USA_NewYork_DisplayingPerformance = new int[4];
            USA_NewYork_UpdatePerformance = new int[4];
            USA_NewYork_ContractAmoPay = new int[6];
            USA_NewYork_RequNum = new int[6];
            USA_NewYork_AmoPayHigh = new int[6];
            USA_NewYork_AmoPayMid = new int[6];
            USA_NewYork_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitUSA_NewYork_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            USA_NewYork_CountryNo = clientCountryNo;
            USA_NewYork_ClientAreaNo = clientAreaNo;
            USA_NewYork_ClientNo = clientNo;
            USA_NewYork_ClientName = clientName;
            USA_NewYork_ClientLv = clientLv;
            USA_NewYork_ClientType = clientType;
            USA_NewYork_Transactions[0] = t1;
            USA_NewYork_Transactions[1] = t2;
            USA_NewYork_Transactions[2] = t3;
            USA_NewYork_Transactions[3] = t4;
            USA_NewYork_Transactions[4] = t5;
            USA_NewYork_Transactions[5] = t6;
            USA_NewYork_Transaction = transaction;
            USA_NewYork_TransactionStatus = transactionStatus;
            USA_NewYork_ManufacturerName = manufacturerName;
            USA_NewYork_Performance = performance;
            USA_NewYork_FluctuationPoint = fluctuationPoint;
            USA_NewYork_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void USA_NewYork_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            USA_NewYork_ContractAmoPay[n] = 0;
            USA_NewYork_RequNum[n] = rn;
            USA_NewYork_AmoPayHigh[n] = apH;
            USA_NewYork_AmoPayMid[n] = apM;
            USA_NewYork_AmoPayLow[n] = amL;
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
                        USA_NewYork_Performance += 0;
                    else if (random <= 0.7)
                        USA_NewYork_Performance += -30;
                    else
                        USA_NewYork_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        USA_NewYork_FluctuationPoint += 1;
                        if (USA_NewYork_FluctuationPoint >= 3)
                        {
                            USA_NewYork_In_de_CreaseValue += 20;
                            USA_NewYork_Performance += (50 + USA_NewYork_In_de_CreaseValue);
                            if (USA_NewYork_Performance >= 150)
                                USA_NewYork_Performance += 150;
                            USA_NewYork_FluctuationPoint = 0;
                        }
                        else
                            USA_NewYork_Performance += 50;
                    }
                    else
                        USA_NewYork_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        USA_NewYork_FluctuationPoint += 1;
                        if (USA_NewYork_FluctuationPoint >= 3)
                        {
                            USA_NewYork_In_de_CreaseValue -= 20;
                            USA_NewYork_Performance += (-50 + USA_NewYork_In_de_CreaseValue);
                            if (USA_NewYork_Performance <= -150)
                                USA_NewYork_Performance += -150;
                            USA_NewYork_FluctuationPoint = 0;
                        }
                        else
                            USA_NewYork_Performance += -50;
                    }
                    else
                        USA_NewYork_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        USA_NewYork_Performance += 200;
                    else
                        USA_NewYork_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    USA_NewYork_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    USA_NewYork_RequNum[index] = requNum - (100 * i);
                    if (USA_NewYork_RequNum[index] < 100)
                        USA_NewYork_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = USA_NewYork_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            USA_NewYork_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public USA_NewYork_Client[] USA_NewYork_Clients = new USA_NewYork_Client[20];

    // 傾儊儕僇丂僙儞僩儖僀僗僋儔僀傾儞僩 // 
    public struct USA_StLouis_Client
    {
        public int USA_StLouis_CountryNo;                      // 崙僫儞僶乕
        public int USA_StLouis_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int USA_StLouis_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string USA_StLouis_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int USA_StLouis_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int USA_StLouis_ClientType;                     // 嬈愌僞僀僾
        public int[] USA_StLouis_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int USA_StLouis_Transaction;                    // 庢堷暔
        public int USA_StLouis_TransactionStatus;              // 庢堷忬嫷
        public string USA_StLouis_ManufacturerName;            // 庢堷憡庤
        public int USA_StLouis_Performance;                    // 嬈愌
        public int[] USA_StLouis_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] USA_StLouis_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] USA_StLouis_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] USA_StLouis_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] USA_StLouis_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] USA_StLouis_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] USA_StLouis_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int USA_StLouis_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int USA_StLouis_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void USA_StLouis_Init()
        {
            USA_StLouis_Transactions = new int[6];
            USA_StLouis_DisplayingPerformance = new int[4];
            USA_StLouis_UpdatePerformance = new int[4];
            USA_StLouis_ContractAmoPay = new int[6];
            USA_StLouis_RequNum = new int[6];
            USA_StLouis_AmoPayHigh = new int[6];
            USA_StLouis_AmoPayMid = new int[6];
            USA_StLouis_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitUSA_StLouis_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            USA_StLouis_CountryNo = clientCountryNo;
            USA_StLouis_ClientAreaNo = clientAreaNo;
            USA_StLouis_ClientNo = clientNo;
            USA_StLouis_ClientName = clientName;
            USA_StLouis_ClientLv = clientLv;
            USA_StLouis_ClientType = clientType;
            USA_StLouis_Transactions[0] = t1;
            USA_StLouis_Transactions[1] = t2;
            USA_StLouis_Transactions[2] = t3;
            USA_StLouis_Transactions[3] = t4;
            USA_StLouis_Transactions[4] = t5;
            USA_StLouis_Transactions[5] = t6;
            USA_StLouis_Transaction = transaction;
            USA_StLouis_TransactionStatus = transactionStatus;
            USA_StLouis_ManufacturerName = manufacturerName;
            USA_StLouis_Performance = performance;
            USA_StLouis_FluctuationPoint = fluctuationPoint;
            USA_StLouis_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void USA_StLouis_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            USA_StLouis_ContractAmoPay[n] = 0;
            USA_StLouis_RequNum[n] = rn;
            USA_StLouis_AmoPayHigh[n] = apH;
            USA_StLouis_AmoPayMid[n] = apM;
            USA_StLouis_AmoPayLow[n] = amL;
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
                        USA_StLouis_Performance += 0;
                    else if (random <= 0.7)
                        USA_StLouis_Performance += -30;
                    else
                        USA_StLouis_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        USA_StLouis_FluctuationPoint += 1;
                        if (USA_StLouis_FluctuationPoint >= 3)
                        {
                            USA_StLouis_In_de_CreaseValue += 20;
                            USA_StLouis_Performance += (50 + USA_StLouis_In_de_CreaseValue);
                            if (USA_StLouis_Performance >= 150)
                                USA_StLouis_Performance += 150;
                            USA_StLouis_FluctuationPoint = 0;
                        }
                        else
                            USA_StLouis_Performance += 50;
                    }
                    else
                        USA_StLouis_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        USA_StLouis_FluctuationPoint += 1;
                        if (USA_StLouis_FluctuationPoint >= 3)
                        {
                            USA_StLouis_In_de_CreaseValue -= 20;
                            USA_StLouis_Performance += (-50 + USA_StLouis_In_de_CreaseValue);
                            if (USA_StLouis_Performance <= -150)
                                USA_StLouis_Performance += -150;
                            USA_StLouis_FluctuationPoint = 0;
                        }
                        else
                            USA_StLouis_Performance += -50;
                    }
                    else
                        USA_StLouis_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        USA_StLouis_Performance += 200;
                    else
                        USA_StLouis_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    USA_StLouis_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    USA_StLouis_RequNum[index] = requNum - (100 * i);
                    if (USA_StLouis_RequNum[index] < 100)
                        USA_StLouis_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = USA_StLouis_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            USA_StLouis_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public USA_StLouis_Client[] USA_StLouis_Clients = new USA_StLouis_Client[20];

    // 傾儊儕僇丂傾僩儔儞僞僋儔僀傾儞僩 // 
    public struct USA_Atlanta_Client
    {
        public int USA_Atlanta_CountryNo;                      // 崙僫儞僶乕
        public int USA_Atlanta_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int USA_Atlanta_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string USA_Atlanta_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int USA_Atlanta_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int USA_Atlanta_ClientType;                     // 嬈愌僞僀僾
        public int[] USA_Atlanta_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int USA_Atlanta_Transaction;                    // 庢堷暔
        public int USA_Atlanta_TransactionStatus;              // 庢堷忬嫷
        public string USA_Atlanta_ManufacturerName;            // 庢堷憡庤
        public int USA_Atlanta_Performance;                    // 嬈愌
        public int[] USA_Atlanta_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] USA_Atlanta_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] USA_Atlanta_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] USA_Atlanta_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] USA_Atlanta_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] USA_Atlanta_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] USA_Atlanta_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int USA_Atlanta_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int USA_Atlanta_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void USA_Atlanta_Init()
        {
            USA_Atlanta_Transactions = new int[6];
            USA_Atlanta_DisplayingPerformance = new int[4];
            USA_Atlanta_UpdatePerformance = new int[4];
            USA_Atlanta_ContractAmoPay = new int[6];
            USA_Atlanta_RequNum = new int[6];
            USA_Atlanta_AmoPayHigh = new int[6];
            USA_Atlanta_AmoPayMid = new int[6];
            USA_Atlanta_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitUSA_Atlanta_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            USA_Atlanta_CountryNo = clientCountryNo;
            USA_Atlanta_ClientAreaNo = clientAreaNo;
            USA_Atlanta_ClientNo = clientNo;
            USA_Atlanta_ClientName = clientName;
            USA_Atlanta_ClientLv = clientLv;
            USA_Atlanta_ClientType = clientType;
            USA_Atlanta_Transactions[0] = t1;
            USA_Atlanta_Transactions[1] = t2;
            USA_Atlanta_Transactions[2] = t3;
            USA_Atlanta_Transactions[3] = t4;
            USA_Atlanta_Transactions[4] = t5;
            USA_Atlanta_Transactions[5] = t6;
            USA_Atlanta_Transaction = transaction;
            USA_Atlanta_TransactionStatus = transactionStatus;
            USA_Atlanta_ManufacturerName = manufacturerName;
            USA_Atlanta_Performance = performance;
            USA_Atlanta_FluctuationPoint = fluctuationPoint;
            USA_Atlanta_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void USA_Atlanta_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            USA_Atlanta_ContractAmoPay[n] = 0;
            USA_Atlanta_RequNum[n] = rn;
            USA_Atlanta_AmoPayHigh[n] = apH;
            USA_Atlanta_AmoPayMid[n] = apM;
            USA_Atlanta_AmoPayLow[n] = amL;
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
                        USA_Atlanta_Performance += 0;
                    else if (random <= 0.7)
                        USA_Atlanta_Performance += -30;
                    else
                        USA_Atlanta_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        USA_Atlanta_FluctuationPoint += 1;
                        if (USA_Atlanta_FluctuationPoint >= 3)
                        {
                            USA_Atlanta_In_de_CreaseValue += 20;
                            USA_Atlanta_Performance += (50 + USA_Atlanta_In_de_CreaseValue);
                            if (USA_Atlanta_Performance >= 150)
                                USA_Atlanta_Performance += 150;
                            USA_Atlanta_FluctuationPoint = 0;
                        }
                        else
                            USA_Atlanta_Performance += 50;
                    }
                    else
                        USA_Atlanta_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        USA_Atlanta_FluctuationPoint += 1;
                        if (USA_Atlanta_FluctuationPoint >= 3)
                        {
                            USA_Atlanta_In_de_CreaseValue -= 20;
                            USA_Atlanta_Performance += (-50 + USA_Atlanta_In_de_CreaseValue);
                            if (USA_Atlanta_Performance <= -150)
                                USA_Atlanta_Performance += -150;
                            USA_Atlanta_FluctuationPoint = 0;
                        }
                        else
                            USA_Atlanta_Performance += -50;
                    }
                    else
                        USA_Atlanta_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        USA_Atlanta_Performance += 200;
                    else
                        USA_Atlanta_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    USA_Atlanta_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    USA_Atlanta_RequNum[index] = requNum - (100 * i);
                    if (USA_Atlanta_RequNum[index] < 100)
                        USA_Atlanta_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = USA_Atlanta_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            USA_Atlanta_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public USA_Atlanta_Client[] USA_Atlanta_Clients = new USA_Atlanta_Client[20];

    // 儘僔傾丂儌僗僋儚僋儔僀傾儞僩 // 
    public struct RUS_Moscow_Client
    {
        public int RUS_Moscow_CountryNo;                      // 崙僫儞僶乕
        public int RUS_Moscow_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int RUS_Moscow_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string RUS_Moscow_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int RUS_Moscow_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int RUS_Moscow_ClientType;                     // 嬈愌僞僀僾
        public int[] RUS_Moscow_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int RUS_Moscow_Transaction;                    // 庢堷暔
        public int RUS_Moscow_TransactionStatus;              // 庢堷忬嫷
        public string RUS_Moscow_ManufacturerName;            // 庢堷憡庤
        public int RUS_Moscow_Performance;                    // 嬈愌
        public int[] RUS_Moscow_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] RUS_Moscow_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] RUS_Moscow_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] RUS_Moscow_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] RUS_Moscow_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] RUS_Moscow_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] RUS_Moscow_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int RUS_Moscow_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int RUS_Moscow_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void RUS_Moscow_Init()
        {
            RUS_Moscow_Transactions = new int[6];
            RUS_Moscow_DisplayingPerformance = new int[4];
            RUS_Moscow_UpdatePerformance = new int[4];
            RUS_Moscow_ContractAmoPay = new int[6];
            RUS_Moscow_RequNum = new int[6];
            RUS_Moscow_AmoPayHigh = new int[6];
            RUS_Moscow_AmoPayMid = new int[6];
            RUS_Moscow_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitRUS_Moscow_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            RUS_Moscow_CountryNo = clientCountryNo;
            RUS_Moscow_ClientAreaNo = clientAreaNo;
            RUS_Moscow_ClientNo = clientNo;
            RUS_Moscow_ClientName = clientName;
            RUS_Moscow_ClientLv = clientLv;
            RUS_Moscow_ClientType = clientType;
            RUS_Moscow_Transactions[0] = t1;
            RUS_Moscow_Transactions[1] = t2;
            RUS_Moscow_Transactions[2] = t3;
            RUS_Moscow_Transactions[3] = t4;
            RUS_Moscow_Transactions[4] = t5;
            RUS_Moscow_Transactions[5] = t6;
            RUS_Moscow_Transaction = transaction;
            RUS_Moscow_TransactionStatus = transactionStatus;
            RUS_Moscow_ManufacturerName = manufacturerName;
            RUS_Moscow_Performance = performance;
            RUS_Moscow_FluctuationPoint = fluctuationPoint;
            RUS_Moscow_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void RUS_Moscow_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            RUS_Moscow_ContractAmoPay[n] = 0;
            RUS_Moscow_RequNum[n] = rn;
            RUS_Moscow_AmoPayHigh[n] = apH;
            RUS_Moscow_AmoPayMid[n] = apM;
            RUS_Moscow_AmoPayLow[n] = amL;
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
                        RUS_Moscow_Performance += 0;
                    else if (random <= 0.7)
                        RUS_Moscow_Performance += -30;
                    else
                        RUS_Moscow_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        RUS_Moscow_FluctuationPoint += 1;
                        if (RUS_Moscow_FluctuationPoint >= 3)
                        {
                            RUS_Moscow_In_de_CreaseValue += 20;
                            RUS_Moscow_Performance += (50 + RUS_Moscow_In_de_CreaseValue);
                            if (RUS_Moscow_Performance >= 150)
                                RUS_Moscow_Performance += 150;
                            RUS_Moscow_FluctuationPoint = 0;
                        }
                        else
                            RUS_Moscow_Performance += 50;
                    }
                    else
                        RUS_Moscow_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        RUS_Moscow_FluctuationPoint += 1;
                        if (RUS_Moscow_FluctuationPoint >= 3)
                        {
                            RUS_Moscow_In_de_CreaseValue -= 20;
                            RUS_Moscow_Performance += (-50 + RUS_Moscow_In_de_CreaseValue);
                            if (RUS_Moscow_Performance <= -150)
                                RUS_Moscow_Performance += -150;
                            RUS_Moscow_FluctuationPoint = 0;
                        }
                        else
                            RUS_Moscow_Performance += -50;
                    }
                    else
                        RUS_Moscow_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        RUS_Moscow_Performance += 200;
                    else
                        RUS_Moscow_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    RUS_Moscow_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    RUS_Moscow_RequNum[index] = requNum - (100 * i);
                    if (RUS_Moscow_RequNum[index] < 100)
                        RUS_Moscow_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = RUS_Moscow_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            RUS_Moscow_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public RUS_Moscow_Client[] RUS_Moscow_Clients = new RUS_Moscow_Client[20];

    // 儘僔傾丂僂僼傽僋儔僀傾儞僩 // 
    public struct RUS_Ufa_Client
    {
        public int RUS_Ufa_CountryNo;                      // 崙僫儞僶乕
        public int RUS_Ufa_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int RUS_Ufa_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string RUS_Ufa_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int RUS_Ufa_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int RUS_Ufa_ClientType;                     // 嬈愌僞僀僾
        public int[] RUS_Ufa_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int RUS_Ufa_Transaction;                    // 庢堷暔
        public int RUS_Ufa_TransactionStatus;              // 庢堷忬嫷
        public string RUS_Ufa_ManufacturerName;            // 庢堷憡庤
        public int RUS_Ufa_Performance;                    // 嬈愌
        public int[] RUS_Ufa_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] RUS_Ufa_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] RUS_Ufa_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] RUS_Ufa_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] RUS_Ufa_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] RUS_Ufa_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] RUS_Ufa_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int RUS_Ufa_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int RUS_Ufa_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void RUS_Ufa_Init()
        {
            RUS_Ufa_Transactions = new int[6];
            RUS_Ufa_DisplayingPerformance = new int[4];
            RUS_Ufa_UpdatePerformance = new int[4];
            RUS_Ufa_ContractAmoPay = new int[6];
            RUS_Ufa_RequNum = new int[6];
            RUS_Ufa_AmoPayHigh = new int[6];
            RUS_Ufa_AmoPayMid = new int[6];
            RUS_Ufa_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitRUS_Ufa_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            RUS_Ufa_CountryNo = clientCountryNo;
            RUS_Ufa_ClientAreaNo = clientAreaNo;
            RUS_Ufa_ClientNo = clientNo;
            RUS_Ufa_ClientName = clientName;
            RUS_Ufa_ClientLv = clientLv;
            RUS_Ufa_ClientType = clientType;
            RUS_Ufa_Transactions[0] = t1;
            RUS_Ufa_Transactions[1] = t2;
            RUS_Ufa_Transactions[2] = t3;
            RUS_Ufa_Transactions[3] = t4;
            RUS_Ufa_Transactions[4] = t5;
            RUS_Ufa_Transactions[5] = t6;
            RUS_Ufa_Transaction = transaction;
            RUS_Ufa_TransactionStatus = transactionStatus;
            RUS_Ufa_ManufacturerName = manufacturerName;
            RUS_Ufa_Performance = performance;
            RUS_Ufa_FluctuationPoint = fluctuationPoint;
            RUS_Ufa_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void RUS_Ufa_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            RUS_Ufa_ContractAmoPay[n] = 0;
            RUS_Ufa_RequNum[n] = rn;
            RUS_Ufa_AmoPayHigh[n] = apH;
            RUS_Ufa_AmoPayMid[n] = apM;
            RUS_Ufa_AmoPayLow[n] = amL;
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
                        RUS_Ufa_Performance += 0;
                    else if (random <= 0.7)
                        RUS_Ufa_Performance += -30;
                    else
                        RUS_Ufa_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        RUS_Ufa_FluctuationPoint += 1;
                        if (RUS_Ufa_FluctuationPoint >= 3)
                        {
                            RUS_Ufa_In_de_CreaseValue += 20;
                            RUS_Ufa_Performance += (50 + RUS_Ufa_In_de_CreaseValue);
                            if (RUS_Ufa_Performance >= 150)
                                RUS_Ufa_Performance += 150;
                            RUS_Ufa_FluctuationPoint = 0;
                        }
                        else
                            RUS_Ufa_Performance += 50;
                    }
                    else
                        RUS_Ufa_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        RUS_Ufa_FluctuationPoint += 1;
                        if (RUS_Ufa_FluctuationPoint >= 3)
                        {
                            RUS_Ufa_In_de_CreaseValue -= 20;
                            RUS_Ufa_Performance += (-50 + RUS_Ufa_In_de_CreaseValue);
                            if (RUS_Ufa_Performance <= -150)
                                RUS_Ufa_Performance += -150;
                            RUS_Ufa_FluctuationPoint = 0;
                        }
                        else
                            RUS_Ufa_Performance += -50;
                    }
                    else
                        RUS_Ufa_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        RUS_Ufa_Performance += 200;
                    else
                        RUS_Ufa_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    RUS_Ufa_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    RUS_Ufa_RequNum[index] = requNum - (100 * i);
                    if (RUS_Ufa_RequNum[index] < 100)
                        RUS_Ufa_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = RUS_Ufa_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            RUS_Ufa_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public RUS_Ufa_Client[] RUS_Ufa_Clients = new RUS_Ufa_Client[20];

    // 僆乕僗僩儔儕傾丂僉儍儞儀儔僋儔僀傾儞僩 // 
    public struct AUS_Canberra_Client
    {
        public int AUS_Canberra_CountryNo;                      // 崙僫儞僶乕
        public int AUS_Canberra_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int AUS_Canberra_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string AUS_Canberra_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int AUS_Canberra_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int AUS_Canberra_ClientType;                     // 嬈愌僞僀僾
        public int[] AUS_Canberra_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int AUS_Canberra_Transaction;                    // 庢堷暔
        public int AUS_Canberra_TransactionStatus;              // 庢堷忬嫷
        public string AUS_Canberra_ManufacturerName;            // 庢堷憡庤
        public int AUS_Canberra_Performance;                    // 嬈愌
        public int[] AUS_Canberra_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] AUS_Canberra_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] AUS_Canberra_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] AUS_Canberra_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] AUS_Canberra_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] AUS_Canberra_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] AUS_Canberra_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int AUS_Canberra_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int AUS_Canberra_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void AUS_Canberra_Init()
        {
            AUS_Canberra_Transactions = new int[6];
            AUS_Canberra_DisplayingPerformance = new int[4];
            AUS_Canberra_UpdatePerformance = new int[4];
            AUS_Canberra_ContractAmoPay = new int[6];
            AUS_Canberra_RequNum = new int[6];
            AUS_Canberra_AmoPayHigh = new int[6];
            AUS_Canberra_AmoPayMid = new int[6];
            AUS_Canberra_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitAUS_Canberra_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            AUS_Canberra_CountryNo = clientCountryNo;
            AUS_Canberra_ClientAreaNo = clientAreaNo;
            AUS_Canberra_ClientNo = clientNo;
            AUS_Canberra_ClientName = clientName;
            AUS_Canberra_ClientLv = clientLv;
            AUS_Canberra_ClientType = clientType;
            AUS_Canberra_Transactions[0] = t1;
            AUS_Canberra_Transactions[1] = t2;
            AUS_Canberra_Transactions[2] = t3;
            AUS_Canberra_Transactions[3] = t4;
            AUS_Canberra_Transactions[4] = t5;
            AUS_Canberra_Transactions[5] = t6;
            AUS_Canberra_Transaction = transaction;
            AUS_Canberra_TransactionStatus = transactionStatus;
            AUS_Canberra_ManufacturerName = manufacturerName;
            AUS_Canberra_Performance = performance;
            AUS_Canberra_FluctuationPoint = fluctuationPoint;
            AUS_Canberra_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void AUS_Canberra_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            AUS_Canberra_ContractAmoPay[n] = 0;
            AUS_Canberra_RequNum[n] = rn;
            AUS_Canberra_AmoPayHigh[n] = apH;
            AUS_Canberra_AmoPayMid[n] = apM;
            AUS_Canberra_AmoPayLow[n] = amL;
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
                        AUS_Canberra_Performance += 0;
                    else if (random <= 0.7)
                        AUS_Canberra_Performance += -30;
                    else
                        AUS_Canberra_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        AUS_Canberra_FluctuationPoint += 1;
                        if (AUS_Canberra_FluctuationPoint >= 3)
                        {
                            AUS_Canberra_In_de_CreaseValue += 20;
                            AUS_Canberra_Performance += (50 + AUS_Canberra_In_de_CreaseValue);
                            if (AUS_Canberra_Performance >= 150)
                                AUS_Canberra_Performance += 150;
                            AUS_Canberra_FluctuationPoint = 0;
                        }
                        else
                            AUS_Canberra_Performance += 50;
                    }
                    else
                        AUS_Canberra_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        AUS_Canberra_FluctuationPoint += 1;
                        if (AUS_Canberra_FluctuationPoint >= 3)
                        {
                            AUS_Canberra_In_de_CreaseValue -= 20;
                            AUS_Canberra_Performance += (-50 + AUS_Canberra_In_de_CreaseValue);
                            if (AUS_Canberra_Performance <= -150)
                                AUS_Canberra_Performance += -150;
                            AUS_Canberra_FluctuationPoint = 0;
                        }
                        else
                            AUS_Canberra_Performance += -50;
                    }
                    else
                        AUS_Canberra_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        AUS_Canberra_Performance += 200;
                    else
                        AUS_Canberra_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    AUS_Canberra_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    AUS_Canberra_RequNum[index] = requNum - (100 * i);
                    if (AUS_Canberra_RequNum[index] < 100)
                        AUS_Canberra_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = AUS_Canberra_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            AUS_Canberra_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public AUS_Canberra_Client[] AUS_Canberra_Clients = new AUS_Canberra_Client[20];

    // 僆乕僗僩儔儕傾丂僷乕僗僋儔僀傾儞僩 // 
    public struct AUS_Perth_Client
    {
        public int AUS_Perth_CountryNo;                      // 崙僫儞僶乕
        public int AUS_Perth_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int AUS_Perth_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string AUS_Perth_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int AUS_Perth_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int AUS_Perth_ClientType;                     // 嬈愌僞僀僾
        public int[] AUS_Perth_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int AUS_Perth_Transaction;                    // 庢堷暔
        public int AUS_Perth_TransactionStatus;              // 庢堷忬嫷
        public string AUS_Perth_ManufacturerName;            // 庢堷憡庤
        public int AUS_Perth_Performance;                    // 嬈愌
        public int[] AUS_Perth_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] AUS_Perth_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] AUS_Perth_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] AUS_Perth_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] AUS_Perth_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] AUS_Perth_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] AUS_Perth_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int AUS_Perth_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int AUS_Perth_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void AUS_Perth_Init()
        {
            AUS_Perth_Transactions = new int[6];
            AUS_Perth_DisplayingPerformance = new int[4];
            AUS_Perth_UpdatePerformance = new int[4];
            AUS_Perth_ContractAmoPay = new int[6];
            AUS_Perth_RequNum = new int[6];
            AUS_Perth_AmoPayHigh = new int[6];
            AUS_Perth_AmoPayMid = new int[6];
            AUS_Perth_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitAUS_Perth_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            AUS_Perth_CountryNo = clientCountryNo;
            AUS_Perth_ClientAreaNo = clientAreaNo;
            AUS_Perth_ClientNo = clientNo;
            AUS_Perth_ClientName = clientName;
            AUS_Perth_ClientLv = clientLv;
            AUS_Perth_ClientType = clientType;
            AUS_Perth_Transactions[0] = t1;
            AUS_Perth_Transactions[1] = t2;
            AUS_Perth_Transactions[2] = t3;
            AUS_Perth_Transactions[3] = t4;
            AUS_Perth_Transactions[4] = t5;
            AUS_Perth_Transactions[5] = t6;
            AUS_Perth_Transaction = transaction;
            AUS_Perth_TransactionStatus = transactionStatus;
            AUS_Perth_ManufacturerName = manufacturerName;
            AUS_Perth_Performance = performance;
            AUS_Perth_FluctuationPoint = fluctuationPoint;
            AUS_Perth_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void AUS_Perth_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            AUS_Perth_ContractAmoPay[n] = 0;
            AUS_Perth_RequNum[n] = rn;
            AUS_Perth_AmoPayHigh[n] = apH;
            AUS_Perth_AmoPayMid[n] = apM;
            AUS_Perth_AmoPayLow[n] = amL;
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
                        AUS_Perth_Performance += 0;
                    else if (random <= 0.7)
                        AUS_Perth_Performance += -30;
                    else
                        AUS_Perth_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        AUS_Perth_FluctuationPoint += 1;
                        if (AUS_Perth_FluctuationPoint >= 3)
                        {
                            AUS_Perth_In_de_CreaseValue += 20;
                            AUS_Perth_Performance += (50 + AUS_Perth_In_de_CreaseValue);
                            if (AUS_Perth_Performance >= 150)
                                AUS_Perth_Performance += 150;
                            AUS_Perth_FluctuationPoint = 0;
                        }
                        else
                            AUS_Perth_Performance += 50;
                    }
                    else
                        AUS_Perth_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        AUS_Perth_FluctuationPoint += 1;
                        if (AUS_Perth_FluctuationPoint >= 3)
                        {
                            AUS_Perth_In_de_CreaseValue -= 20;
                            AUS_Perth_Performance += (-50 + AUS_Perth_In_de_CreaseValue);
                            if (AUS_Perth_Performance <= -150)
                                AUS_Perth_Performance += -150;
                            AUS_Perth_FluctuationPoint = 0;
                        }
                        else
                            AUS_Perth_Performance += -50;
                    }
                    else
                        AUS_Perth_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        AUS_Perth_Performance += 200;
                    else
                        AUS_Perth_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    AUS_Perth_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    AUS_Perth_RequNum[index] = requNum - (100 * i);
                    if (AUS_Perth_RequNum[index] < 100)
                        AUS_Perth_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = AUS_Perth_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            AUS_Perth_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public AUS_Perth_Client[] AUS_Perth_Clients = new AUS_Perth_Client[20];

    // 僆乕僗僩儔儕傾丂儊儖儃儖儞僋儔僀傾儞僩 // 
    public struct AUS_Melbourne_Client
    {
        public int AUS_Melbourne_CountryNo;                      // 崙僫儞僶乕
        public int AUS_Melbourne_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int AUS_Melbourne_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string AUS_Melbourne_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int AUS_Melbourne_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int AUS_Melbourne_ClientType;                     // 嬈愌僞僀僾
        public int[] AUS_Melbourne_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int AUS_Melbourne_Transaction;                    // 庢堷暔
        public int AUS_Melbourne_TransactionStatus;              // 庢堷忬嫷
        public string AUS_Melbourne_ManufacturerName;            // 庢堷憡庤
        public int AUS_Melbourne_Performance;                    // 嬈愌
        public int[] AUS_Melbourne_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] AUS_Melbourne_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] AUS_Melbourne_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] AUS_Melbourne_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] AUS_Melbourne_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] AUS_Melbourne_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] AUS_Melbourne_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int AUS_Melbourne_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int AUS_Melbourne_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void AUS_Melbourne_Init()
        {
            AUS_Melbourne_Transactions = new int[6];
            AUS_Melbourne_DisplayingPerformance = new int[4];
            AUS_Melbourne_UpdatePerformance = new int[4];
            AUS_Melbourne_ContractAmoPay = new int[6];
            AUS_Melbourne_RequNum = new int[6];
            AUS_Melbourne_AmoPayHigh = new int[6];
            AUS_Melbourne_AmoPayMid = new int[6];
            AUS_Melbourne_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitAUS_Melbourne_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            AUS_Melbourne_CountryNo = clientCountryNo;
            AUS_Melbourne_ClientAreaNo = clientAreaNo;
            AUS_Melbourne_ClientNo = clientNo;
            AUS_Melbourne_ClientName = clientName;
            AUS_Melbourne_ClientLv = clientLv;
            AUS_Melbourne_ClientType = clientType;
            AUS_Melbourne_Transactions[0] = t1;
            AUS_Melbourne_Transactions[1] = t2;
            AUS_Melbourne_Transactions[2] = t3;
            AUS_Melbourne_Transactions[3] = t4;
            AUS_Melbourne_Transactions[4] = t5;
            AUS_Melbourne_Transactions[5] = t6;
            AUS_Melbourne_Transaction = transaction;
            AUS_Melbourne_TransactionStatus = transactionStatus;
            AUS_Melbourne_ManufacturerName = manufacturerName;
            AUS_Melbourne_Performance = performance;
            AUS_Melbourne_FluctuationPoint = fluctuationPoint;
            AUS_Melbourne_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void AUS_Melbourne_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            AUS_Melbourne_ContractAmoPay[n] = 0;
            AUS_Melbourne_RequNum[n] = rn;
            AUS_Melbourne_AmoPayHigh[n] = apH;
            AUS_Melbourne_AmoPayMid[n] = apM;
            AUS_Melbourne_AmoPayLow[n] = amL;
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
                        AUS_Melbourne_Performance += 0;
                    else if (random <= 0.7)
                        AUS_Melbourne_Performance += -30;
                    else
                        AUS_Melbourne_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        AUS_Melbourne_FluctuationPoint += 1;
                        if (AUS_Melbourne_FluctuationPoint >= 3)
                        {
                            AUS_Melbourne_In_de_CreaseValue += 20;
                            AUS_Melbourne_Performance += (50 + AUS_Melbourne_In_de_CreaseValue);
                            if (AUS_Melbourne_Performance >= 150)
                                AUS_Melbourne_Performance += 150;
                            AUS_Melbourne_FluctuationPoint = 0;
                        }
                        else
                            AUS_Melbourne_Performance += 50;
                    }
                    else
                        AUS_Melbourne_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        AUS_Melbourne_FluctuationPoint += 1;
                        if (AUS_Melbourne_FluctuationPoint >= 3)
                        {
                            AUS_Melbourne_In_de_CreaseValue -= 20;
                            AUS_Melbourne_Performance += (-50 + AUS_Melbourne_In_de_CreaseValue);
                            if (AUS_Melbourne_Performance <= -150)
                                AUS_Melbourne_Performance += -150;
                            AUS_Melbourne_FluctuationPoint = 0;
                        }
                        else
                            AUS_Melbourne_Performance += -50;
                    }
                    else
                        AUS_Melbourne_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        AUS_Melbourne_Performance += 200;
                    else
                        AUS_Melbourne_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    AUS_Melbourne_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    AUS_Melbourne_RequNum[index] = requNum - (100 * i);
                    if (AUS_Melbourne_RequNum[index] < 100)
                        AUS_Melbourne_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = AUS_Melbourne_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            AUS_Melbourne_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public AUS_Melbourne_Client[] AUS_Melbourne_Clients = new AUS_Melbourne_Client[20];

    // 撿傾僼儕僇丂僾儗僩儕傾僋儔僀傾儞僩 // 
    public struct ZAF_Pretoria_Client
    {
        public int ZAF_Pretoria_CountryNo;                      // 崙僫儞僶乕
        public int ZAF_Pretoria_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int ZAF_Pretoria_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string ZAF_Pretoria_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int ZAF_Pretoria_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int ZAF_Pretoria_ClientType;                     // 嬈愌僞僀僾
        public int[] ZAF_Pretoria_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int ZAF_Pretoria_Transaction;                    // 庢堷暔
        public int ZAF_Pretoria_TransactionStatus;              // 庢堷忬嫷
        public string ZAF_Pretoria_ManufacturerName;            // 庢堷憡庤
        public int ZAF_Pretoria_Performance;                    // 嬈愌
        public int[] ZAF_Pretoria_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] ZAF_Pretoria_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] ZAF_Pretoria_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] ZAF_Pretoria_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] ZAF_Pretoria_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] ZAF_Pretoria_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] ZAF_Pretoria_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int ZAF_Pretoria_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int ZAF_Pretoria_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void ZAF_Pretoria_Init()
        {
            ZAF_Pretoria_Transactions = new int[6];
            ZAF_Pretoria_DisplayingPerformance = new int[4];
            ZAF_Pretoria_UpdatePerformance = new int[4];
            ZAF_Pretoria_ContractAmoPay = new int[6];
            ZAF_Pretoria_RequNum = new int[6];
            ZAF_Pretoria_AmoPayHigh = new int[6];
            ZAF_Pretoria_AmoPayMid = new int[6];
            ZAF_Pretoria_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitZAF_Pretoria_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            ZAF_Pretoria_CountryNo = clientCountryNo;
            ZAF_Pretoria_ClientAreaNo = clientAreaNo;
            ZAF_Pretoria_ClientNo = clientNo;
            ZAF_Pretoria_ClientName = clientName;
            ZAF_Pretoria_ClientLv = clientLv;
            ZAF_Pretoria_ClientType = clientType;
            ZAF_Pretoria_Transactions[0] = t1;
            ZAF_Pretoria_Transactions[1] = t2;
            ZAF_Pretoria_Transactions[2] = t3;
            ZAF_Pretoria_Transactions[3] = t4;
            ZAF_Pretoria_Transactions[4] = t5;
            ZAF_Pretoria_Transactions[5] = t6;
            ZAF_Pretoria_Transaction = transaction;
            ZAF_Pretoria_TransactionStatus = transactionStatus;
            ZAF_Pretoria_ManufacturerName = manufacturerName;
            ZAF_Pretoria_Performance = performance;
            ZAF_Pretoria_FluctuationPoint = fluctuationPoint;
            ZAF_Pretoria_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void ZAF_Pretoria_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            ZAF_Pretoria_ContractAmoPay[n] = 0;
            ZAF_Pretoria_RequNum[n] = rn;
            ZAF_Pretoria_AmoPayHigh[n] = apH;
            ZAF_Pretoria_AmoPayMid[n] = apM;
            ZAF_Pretoria_AmoPayLow[n] = amL;
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
                        ZAF_Pretoria_Performance += 0;
                    else if (random <= 0.7)
                        ZAF_Pretoria_Performance += -30;
                    else
                        ZAF_Pretoria_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        ZAF_Pretoria_FluctuationPoint += 1;
                        if (ZAF_Pretoria_FluctuationPoint >= 3)
                        {
                            ZAF_Pretoria_In_de_CreaseValue += 20;
                            ZAF_Pretoria_Performance += (50 + ZAF_Pretoria_In_de_CreaseValue);
                            if (ZAF_Pretoria_Performance >= 150)
                                ZAF_Pretoria_Performance += 150;
                            ZAF_Pretoria_FluctuationPoint = 0;
                        }
                        else
                            ZAF_Pretoria_Performance += 50;
                    }
                    else
                        ZAF_Pretoria_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        ZAF_Pretoria_FluctuationPoint += 1;
                        if (ZAF_Pretoria_FluctuationPoint >= 3)
                        {
                            ZAF_Pretoria_In_de_CreaseValue -= 20;
                            ZAF_Pretoria_Performance += (-50 + ZAF_Pretoria_In_de_CreaseValue);
                            if (ZAF_Pretoria_Performance <= -150)
                                ZAF_Pretoria_Performance += -150;
                            ZAF_Pretoria_FluctuationPoint = 0;
                        }
                        else
                            ZAF_Pretoria_Performance += -50;
                    }
                    else
                        ZAF_Pretoria_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        ZAF_Pretoria_Performance += 200;
                    else
                        ZAF_Pretoria_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    ZAF_Pretoria_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    ZAF_Pretoria_RequNum[index] = requNum - (100 * i);
                    if (ZAF_Pretoria_RequNum[index] < 100)
                        ZAF_Pretoria_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = ZAF_Pretoria_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            ZAF_Pretoria_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public ZAF_Pretoria_Client[] ZAF_Pretoria_Clients = new ZAF_Pretoria_Client[20];

    // 撿傾僼儕僇丂僽儖乕儉僼僅儞僥僀儞僋儔僀傾儞僩 // 
    public struct ZAF_Bloemfontein_Client
    {
        public int ZAF_Bloemfontein_CountryNo;                      // 崙僫儞僶乕
        public int ZAF_Bloemfontein_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int ZAF_Bloemfontein_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string ZAF_Bloemfontein_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int ZAF_Bloemfontein_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int ZAF_Bloemfontein_ClientType;                     // 嬈愌僞僀僾
        public int[] ZAF_Bloemfontein_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int ZAF_Bloemfontein_Transaction;                    // 庢堷暔
        public int ZAF_Bloemfontein_TransactionStatus;              // 庢堷忬嫷
        public string ZAF_Bloemfontein_ManufacturerName;            // 庢堷憡庤
        public int ZAF_Bloemfontein_Performance;                    // 嬈愌
        public int[] ZAF_Bloemfontein_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] ZAF_Bloemfontein_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] ZAF_Bloemfontein_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] ZAF_Bloemfontein_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] ZAF_Bloemfontein_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] ZAF_Bloemfontein_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] ZAF_Bloemfontein_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int ZAF_Bloemfontein_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int ZAF_Bloemfontein_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void ZAF_Bloemfontein_Init()
        {
            ZAF_Bloemfontein_Transactions = new int[6];
            ZAF_Bloemfontein_DisplayingPerformance = new int[4];
            ZAF_Bloemfontein_UpdatePerformance = new int[4];
            ZAF_Bloemfontein_ContractAmoPay = new int[6];
            ZAF_Bloemfontein_RequNum = new int[6];
            ZAF_Bloemfontein_AmoPayHigh = new int[6];
            ZAF_Bloemfontein_AmoPayMid = new int[6];
            ZAF_Bloemfontein_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitZAF_Bloemfontein_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            ZAF_Bloemfontein_CountryNo = clientCountryNo;
            ZAF_Bloemfontein_ClientAreaNo = clientAreaNo;
            ZAF_Bloemfontein_ClientNo = clientNo;
            ZAF_Bloemfontein_ClientName = clientName;
            ZAF_Bloemfontein_ClientLv = clientLv;
            ZAF_Bloemfontein_ClientType = clientType;
            ZAF_Bloemfontein_Transactions[0] = t1;
            ZAF_Bloemfontein_Transactions[1] = t2;
            ZAF_Bloemfontein_Transactions[2] = t3;
            ZAF_Bloemfontein_Transactions[3] = t4;
            ZAF_Bloemfontein_Transactions[4] = t5;
            ZAF_Bloemfontein_Transactions[5] = t6;
            ZAF_Bloemfontein_Transaction = transaction;
            ZAF_Bloemfontein_TransactionStatus = transactionStatus;
            ZAF_Bloemfontein_ManufacturerName = manufacturerName;
            ZAF_Bloemfontein_Performance = performance;
            ZAF_Bloemfontein_FluctuationPoint = fluctuationPoint;
            ZAF_Bloemfontein_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void ZAF_Bloemfontein_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            ZAF_Bloemfontein_ContractAmoPay[n] = 0;
            ZAF_Bloemfontein_RequNum[n] = rn;
            ZAF_Bloemfontein_AmoPayHigh[n] = apH;
            ZAF_Bloemfontein_AmoPayMid[n] = apM;
            ZAF_Bloemfontein_AmoPayLow[n] = amL;
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
                        ZAF_Bloemfontein_Performance += 0;
                    else if (random <= 0.7)
                        ZAF_Bloemfontein_Performance += -30;
                    else
                        ZAF_Bloemfontein_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        ZAF_Bloemfontein_FluctuationPoint += 1;
                        if (ZAF_Bloemfontein_FluctuationPoint >= 3)
                        {
                            ZAF_Bloemfontein_In_de_CreaseValue += 20;
                            ZAF_Bloemfontein_Performance += (50 + ZAF_Bloemfontein_In_de_CreaseValue);
                            if (ZAF_Bloemfontein_Performance >= 150)
                                ZAF_Bloemfontein_Performance += 150;
                            ZAF_Bloemfontein_FluctuationPoint = 0;
                        }
                        else
                            ZAF_Bloemfontein_Performance += 50;
                    }
                    else
                        ZAF_Bloemfontein_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        ZAF_Bloemfontein_FluctuationPoint += 1;
                        if (ZAF_Bloemfontein_FluctuationPoint >= 3)
                        {
                            ZAF_Bloemfontein_In_de_CreaseValue -= 20;
                            ZAF_Bloemfontein_Performance += (-50 + ZAF_Bloemfontein_In_de_CreaseValue);
                            if (ZAF_Bloemfontein_Performance <= -150)
                                ZAF_Bloemfontein_Performance += -150;
                            ZAF_Bloemfontein_FluctuationPoint = 0;
                        }
                        else
                            ZAF_Bloemfontein_Performance += -50;
                    }
                    else
                        ZAF_Bloemfontein_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        ZAF_Bloemfontein_Performance += 200;
                    else
                        ZAF_Bloemfontein_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    ZAF_Bloemfontein_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    ZAF_Bloemfontein_RequNum[index] = requNum - (100 * i);
                    if (ZAF_Bloemfontein_RequNum[index] < 100)
                        ZAF_Bloemfontein_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = ZAF_Bloemfontein_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            ZAF_Bloemfontein_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public ZAF_Bloemfontein_Client[] ZAF_Bloemfontein_Clients = new ZAF_Bloemfontein_Client[20];

    // 撿傾僼儕僇丂働乕僾僞僂儞僋儔僀傾儞僩 // 
    public struct ZAF_CapeTown_Client
    {
        public int ZAF_CapeTown_CountryNo;                      // 崙僫儞僶乕
        public int ZAF_CapeTown_ClientAreaNo;                   // 抧堟僫儞僶乕
        public int ZAF_CapeTown_ClientNo;                       // 僋儔僀傾儞僩僫儞僶乕
        public string ZAF_CapeTown_ClientName;                  // 僋儔僀傾儞僩僱乕儉
        public int ZAF_CapeTown_ClientLv;                       // 僋儔僀傾儞僩儗儀儖
        public int ZAF_CapeTown_ClientType;                     // 嬈愌僞僀僾
        public int[] ZAF_CapeTown_Transactions;                 // 庢堷暔乮暋悢丂俵俙倃俇屄 乯

        public int ZAF_CapeTown_Transaction;                    // 庢堷暔
        public int ZAF_CapeTown_TransactionStatus;              // 庢堷忬嫷
        public string ZAF_CapeTown_ManufacturerName;            // 庢堷憡庤
        public int ZAF_CapeTown_Performance;                    // 嬈愌
        public int[] ZAF_CapeTown_DisplayingPerformance;        // 昞帵拞嬈愌
        public int[] ZAF_CapeTown_UpdatePerformance;            // 嵟怴偺嬈愌
        public int[] ZAF_CapeTown_ContractAmoPay;               // 宊栺巟暐妟丂弶婜侽仺宊栺帪偵寛傑偭偨妟傪偄傟傞  乮庢堷暔暘乯     

        public int[] ZAF_CapeTown_RequNum;                      // 庢堷暔梫媮悢丠
        public int[] ZAF_CapeTown_AmoPayHigh;                   // 庢堷暔巟暐妟丠High        
        public int[] ZAF_CapeTown_AmoPayMid;                    // 庢堷暔巟暐妟丠Mid
        public int[] ZAF_CapeTown_AmoPayLow;  丂 丂             // 庢堷暔巟暐妟丠Low

        public int ZAF_CapeTown_FluctuationPoint;               // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞曄摦検偑憹尭偡傞
        public int ZAF_CapeTown_In_de_CreaseValue;              // 怟偁偑傝or怟壓偑傝僞僀僾偺帪偵偺傒巊梡丂俁夞偵侾夞憹尭偟偨抣傪曐帩


        // 攝楍弶婜壔
        public void ZAF_CapeTown_Init()
        {
            ZAF_CapeTown_Transactions = new int[6];
            ZAF_CapeTown_DisplayingPerformance = new int[4];
            ZAF_CapeTown_UpdatePerformance = new int[4];
            ZAF_CapeTown_ContractAmoPay = new int[6];
            ZAF_CapeTown_RequNum = new int[6];
            ZAF_CapeTown_AmoPayHigh = new int[6];
            ZAF_CapeTown_AmoPayMid = new int[6];
            ZAF_CapeTown_AmoPayLow = new int[6];

        }

        // 僋儔僀傾儞僩婎慴弶婜壔乮崙丒抧堟丒泡兽皝E柤慜丒儗儀儖丒僞僀僾丒庢堷暔1񑓛񑺵�6丒庢堷暔丠丒庢堷忬嫷丒庢堷憡庤丒嬈愌丒曄摦抣丒曄摦抣曐帩丒梫慺斣崋乯
        public void InitZAF_CapeTown_Clients(int clientCountryNo, int clientAreaNo, int clientNo, string clientName,
                               int clientLv, int clientType, int t1, int t2, int t3, int t4, int t5, int t6,
                               int transaction, int transactionStatus, string manufacturerName, int performance, int fluctuationPoint, int in_de_CreaseValue, int index)
        {
            ZAF_CapeTown_CountryNo = clientCountryNo;
            ZAF_CapeTown_ClientAreaNo = clientAreaNo;
            ZAF_CapeTown_ClientNo = clientNo;
            ZAF_CapeTown_ClientName = clientName;
            ZAF_CapeTown_ClientLv = clientLv;
            ZAF_CapeTown_ClientType = clientType;
            ZAF_CapeTown_Transactions[0] = t1;
            ZAF_CapeTown_Transactions[1] = t2;
            ZAF_CapeTown_Transactions[2] = t3;
            ZAF_CapeTown_Transactions[3] = t4;
            ZAF_CapeTown_Transactions[4] = t5;
            ZAF_CapeTown_Transactions[5] = t6;
            ZAF_CapeTown_Transaction = transaction;
            ZAF_CapeTown_TransactionStatus = transactionStatus;
            ZAF_CapeTown_ManufacturerName = manufacturerName;
            ZAF_CapeTown_Performance = performance;
            ZAF_CapeTown_FluctuationPoint = fluctuationPoint;
            ZAF_CapeTown_In_de_CreaseValue = in_de_CreaseValue;
        }
        // 巟暐妟弶婜壔
        public void ZAF_CapeTown_AmoPayInit(int rn, int apH, int apM, int amL, int n)
        {
            ZAF_CapeTown_ContractAmoPay[n] = 0;
            ZAF_CapeTown_RequNum[n] = rn;
            ZAF_CapeTown_AmoPayHigh[n] = apH;
            ZAF_CapeTown_AmoPayMid[n] = apM;
            ZAF_CapeTown_AmoPayLow[n] = amL;
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
                        ZAF_CapeTown_Performance += 0;
                    else if (random <= 0.7)
                        ZAF_CapeTown_Performance += -30;
                    else
                        ZAF_CapeTown_Performance += +30;
                    break;
                // 怟忋偑傝僞僀僾
                case 1:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        ZAF_CapeTown_FluctuationPoint += 1;
                        if (ZAF_CapeTown_FluctuationPoint >= 3)
                        {
                            ZAF_CapeTown_In_de_CreaseValue += 20;
                            ZAF_CapeTown_Performance += (50 + ZAF_CapeTown_In_de_CreaseValue);
                            if (ZAF_CapeTown_Performance >= 150)
                                ZAF_CapeTown_Performance += 150;
                            ZAF_CapeTown_FluctuationPoint = 0;
                        }
                        else
                            ZAF_CapeTown_Performance += 50;
                    }
                    else
                        ZAF_CapeTown_Performance += -50;
                    break;
                // 怟壓偑傝僞僀僾
                case 2:
                    random = Random.value;
                    if (random <= 0.7)
                    {
                        ZAF_CapeTown_FluctuationPoint += 1;
                        if (ZAF_CapeTown_FluctuationPoint >= 3)
                        {
                            ZAF_CapeTown_In_de_CreaseValue -= 20;
                            ZAF_CapeTown_Performance += (-50 + ZAF_CapeTown_In_de_CreaseValue);
                            if (ZAF_CapeTown_Performance <= -150)
                                ZAF_CapeTown_Performance += -150;
                            ZAF_CapeTown_FluctuationPoint = 0;
                        }
                        else
                            ZAF_CapeTown_Performance += -50;
                    }
                    else
                        ZAF_CapeTown_Performance += 50;
                    break;
                // 僺乕僉乕僞僀僾
                case 3:
                    if (random <= 0.5)
                        ZAF_CapeTown_Performance += 200;
                    else
                        ZAF_CapeTown_Performance += -200;
                    break;
            }

        }

        // 梫媮悢/巟暐妟丂憹尭僞僀儈儞僌
        public void Requ_Pay_In_de_crease(int requNum, int amoPay, int performance, int index)
        {
            // 梫媮悢偑乕侾側傜曉偡
            if (requNum == -1)
                return;

            // 嬈愌偑侾侽侽枹枮側傜曉偡
            if (performance < 100)
                return;

            bool IsExit = false;

            for (int i = 1; i <= 20; i++)
            {
                if (IsExit == true)
                    break;
                // 100埲忋200枹枮
                if (performance >= (100 * i) && performance < (100 * (i + 1)))
                {
                    ZAF_CapeTown_RequNum[index] = requNum + (100 * i);
                    IsExit = true;
                }
                else if (performance <= (-100 * i) && performance > (-100 * (i + 1)))
                {
                    ZAF_CapeTown_RequNum[index] = requNum - (100 * i);
                    if (ZAF_CapeTown_RequNum[index] < 100)
                        ZAF_CapeTown_RequNum[index] = 100;

                    IsExit = true;
                }
            }

            float value = 0.0f;     // 曄摦屻梫媮悢 / 尦梫媮悢
            float requN = requNum; // 尦梫媮悢
            float UpdaterequN = ZAF_CapeTown_RequNum[index]; // 曄摦屻偺梫媮悢
            float AmoP = amoPay;        // 尦巟暐妟
            float UpdateAmoP = 0.0f;    // 曄摦屻偺巟暐妟

            value = UpdaterequN / requN;
            UpdateAmoP = AmoP * value;

            ZAF_CapeTown_ContractAmoPay[index] = (int)UpdateAmoP;

        }
    };
    public ZAF_CapeTown_Client[] ZAF_CapeTown_Clients = new ZAF_CapeTown_Client[20];

}
