using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductionList : MonoBehaviour
{
    [SerializeField] DataBase database;

    [SerializeField] private GameObject Clientlist;
    [SerializeField] private ClientList Cliscript;

    public Production[] Productions;
    public bool isSearch;
    public bool isSend; // ��񑗐M�̊m�F

    public int debug; // �󂯎�����f�[�^���m�F����ׂ̉��ϐ�

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");

        isSearch = true;
        isSend = false;

        Clientlist = GameObject.Find("ClientList");
        Cliscript = Clientlist.GetComponent<ClientList>();

        for (int i = 0; i < Productions.Length; i++)
        {

            switch (i)
            {
                case 0: // �����n��
                    for(int j = 0; j < database.manufacturers.Length; j++) // ���Y�ҕ�for����
                    {
                        if (database.clients[database.MiniClieNo].ClientCountryNo == database.manufacturers[j].ManufacturerCountryNo) // ���͓�����
                        {
                            if (database.clients[database.MiniClieNo].ClientAreaNo == database.manufacturers[j].ManufacturerAreaNo)   // �n��͓�����
                            {
                               //for(int n = 0; n < database.clients[database.MiniClieNo].Transactions.Length; n++)                    // �N���C�A���g�̎�����̉񐔉�
                               //{
                               //     if (database.clients[database.MiniClieNo].Transactions[n] == database.manufacturers[j].Products)  // ������Ɨv�����͓�����
                               //     {
                               //         // Productions[i]�ɖ��O��z�u�A�ꍇ�ɂ���Ă͐��Y�҂��w�肷�鐔�����z�u
                               //     }
                               //}

                                Productions[i].Production_Text.text = database.manufacturers[j].ManufacturerName;
                                Productions[i].production = database.manufacturers[j].Products;
                                j = database.manufacturers.Length; // for���I��
                                Debug.Log("�������A�����n��̐��Y�Ғ��I");
                            }
                        }
                    }
                    break;

                case 1:// �������A�Ⴄ�n��
                    for (int j = 0; j < database.manufacturers.Length; j++) // ���Y�ҕ�for����
                    {
                        if (database.clients[database.MiniClieNo].ClientCountryNo == database.manufacturers[j].ManufacturerCountryNo) // ���͓�����
                        {
                            if (database.clients[database.MiniClieNo].ClientAreaNo != database.manufacturers[j].ManufacturerAreaNo)   // �n��͈Ⴄ��
                            {
                                //for (int n = 0; n < database.clients[database.MiniClieNo].Transactions.Length; n++)                    // �N���C�A���g�̎�����̉񐔉�
                                //{
                                //    if (database.clients[database.MiniClieNo].Transactions[n] == database.manufacturers[j].Products)  // ������Ɨv�����͓�����
                                //    {
                                //        // Productions[i]�ɖ��O��z�u�A�ꍇ�ɂ���Ă͐��Y�҂��w�肷�鐔�����z�u
                                //    }
                                //}
                                Productions[i].Production_Text.text = database.manufacturers[j].ManufacturerName;
                                Productions[i].production = database.manufacturers[j].Products;
                                j = database.manufacturers.Length; // for���I��
                                Debug.Log("�������A�Ⴄ�n��̐��Y�Ғ��I");
                            }
                        }
                    }
                    break;

                case 2:// ����
                    for (int j = 0; j < database.manufacturers.Length; j++)// ���Y�ҕ�for����
                    {
                        if (database.clients[database.MiniClieNo].ClientCountryNo != database.manufacturers[j].ManufacturerCountryNo) // ���͈Ⴄ��
                        {
                            Productions[i].Production_Text.text = database.manufacturers[j].ManufacturerName;
                            Productions[i].production = database.manufacturers[j].Products;
                            j = database.manufacturers.Length; // for���I��
                            Debug.Log("�����̐��Y�҂𒊑I");
                        }
                    }
                    break;

                default:// �G���[
                    Debug.Log("���Y�҂̒��I�Ɉُ킪�����Ă��܂��B");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isSearch)
        {
            // �v�����̏����擾���Ă��Ȃ����

            for (int i = 0; i < Productions.Length; i++)
            {
                if ((Productions[i].Choice)&&(Productions[i]))
                {
                    Debug.Log("���Y�҂����o");
                    debug = Productions[i].production;
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
                script.ProductionData = debug;
                
                isSend = true;
                script.ProductionSend = isSend;
            }
            else
            {
                // ��񑗐M����
            }
        }
    }
}
