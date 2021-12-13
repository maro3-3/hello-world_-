using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientList : MonoBehaviour // Productionlist���擾���āA���Y�҂ɊY������A�C�e�����n�C���C�g�\������
{
    [SerializeField] DataBase database;

    [SerializeField] private GameObject Productionlist;
    ProductionList Proscript;

    [SerializeField] private GameObject ClientNameText_obj;
    [SerializeField] private Text ClientName_Text;

    [SerializeField] private GameObject ClientLevelText_obj;
    [SerializeField] private Text ClientLevel_Text;

    public Request[] Requestlist;
    public bool isSearch;
    public bool isSend; // ��񑗐M�̊m�F

    public int debug; // �󂯎�����f�[�^���m�F����ׂ̉��ϐ�
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        ClientNameText_obj = transform.Find("ClientName").gameObject;
        ClientName_Text = ClientNameText_obj.GetComponent<Text>();

        ClientLevelText_obj = transform.Find("ClientLevel").gameObject;
        ClientLevel_Text = ClientLevelText_obj.GetComponent<Text>();

        isSearch = true;
        isSend = false;

        ClientLevel_Text.text = "Lv " + database.clients[database.MiniClieNo].ClientLv;
        ClientName_Text.text = database.clients[database.MiniClieNo].ClientName;

        RequestInit(Requestlist, database.clients[database.MiniClieNo].Transactions);
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

    void RequestInit(Request[] req, int[] trans)
    {
        for(int i = 0; i < req.Length; i++)
        {
            req[i].request = trans[i];
        }
        Debug.Log("�N���C�A���g�̗v������������");
    }
}
