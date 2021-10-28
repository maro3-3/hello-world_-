using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientList : MonoBehaviour // Requestlist�Ɏq��Request���i�[���A�ǂꂩ�������ꂽ�ۂɑ��̃{�^���������Ȃ��悤�ɂ���B
{
    public Request[] Requestlist;
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

            for (int i = 0; i < Requestlist.Length; i++)
            {
                if (Requestlist[i].Choice)
                {
                    Debug.Log("�v���������o");
                    debug = Requestlist[i].request;
                    isSearch = false;
                }
            }
        }
        else
        {
            // �v�����̏����擾���Ă�����

            if (!isSend)
            {
                // ��񖢑��M
                GameObject Minimana = GameObject.Find("MinigameManager");
                MinigameManager script = Minimana.GetComponent<MinigameManager>();
                script.RequestData = debug;

                isSend = true;
                script.RequestSend = isSend;
            }
            else
            {
                // ��񑗐M����
            }
        }
    }
}