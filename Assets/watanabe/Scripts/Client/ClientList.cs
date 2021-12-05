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

    public int Client;     // �ǂ̃N���C�A���g���w�肷��z��i���o�[
    public int CountryNo;  // �����f�[�^
    public int AreaNo;     // �n�扼�f�[�^
    public int ClientNo;   // �N���C�A���g�i���o�[�f�[�^
    public int ClientLevel;// �N���C�A���g���x��
    public string ClientName;   // �N���C�A���g�l�[��

    public int debug; // �󂯎�����f�[�^���m�F����ׂ̉��ϐ�
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        Productionlist = GameObject.Find("ProductionList");
        Proscript = Productionlist.GetComponent<ProductionList>();

        ClientNameText_obj = transform.Find("ClientName").gameObject;
        ClientName_Text = ClientNameText_obj.GetComponent<Text>();

        ClientLevelText_obj = transform.Find("ClientLevel").gameObject;
        ClientLevel_Text = ClientLevelText_obj.GetComponent<Text>();

        isSearch = true;
        isSend = false;

        CountryNo = database.clients[database.MiniClieNo].ClientCountryNo;
        AreaNo = database.clients[database.MiniClieNo].ClientAreaNo;
        ClientNo = database.clients[database.MiniClieNo].ClientNo;
        ClientName = database.clients[database.MiniClieNo].ClientName;
        ClientLevel = database.clients[database.MiniClieNo].ClientLv;

        ClientLevel_Text.text = "Lv " + ClientLevel;
        ClientName_Text.text = ClientName;

        RequestInit(Requestlist, database.clients[database.MiniClieNo].Transactions);
    }

    // Update is called once per frame
    void Update()
    {
        if(Productionlist == null)
        {
            Productionlist = GameObject.Find("ProductionList");
            Proscript = Productionlist.GetComponent<ProductionList>();
        }
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
