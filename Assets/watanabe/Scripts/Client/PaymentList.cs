using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaymentList : MonoBehaviour
{
    public Amount[] Amountlist;
    public bool isSearch;
    public bool isSend; // ��񑗐M�̊m�F

    public int debug; // �󂯎�����f�[�^���m�F����ׂ̉��ϐ�
    // Start is called before the first frame update
    void Start()
    {
        isSearch = true;
        isSend = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSearch)
        {
            // �v�����̏����擾���Ă��Ȃ����

            for (int i = 0; i < Amountlist.Length; i++)
            {
                if (Amountlist[i].Choice)
                {
                    Debug.Log("����z�����o");
                    debug = Amountlist[i].amount;
                    isSearch = false;
                }
            }
        }
        else
        {
            // �v�����̏����擾���Ă�����

            if (!isSend)
            {
                GameObject Minimana = GameObject.Find("MinigameManager");
                MinigameManager script = Minimana.GetComponent<MinigameManager>();
                script.AmountData = debug;

                isSend = true;
                script.AmountSend = isSend;
            }
            else
            {
                // ��񑗐M����
            }
        }
    }
}
