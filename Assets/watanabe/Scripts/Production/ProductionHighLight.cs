using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ���Y�҃��X�g���N���C�A���g���X�g�ŏ����ɂ��Ă͂܂���̂��n�C���C�g������
public class ProductionHighLight : MonoBehaviour
{
    private GameObject Clientlist;
    [SerializeField] private GameObject[] request;
    [SerializeField] private Request[] Reqscript;
    [SerializeField] private GameObject[] RequestHighLight;
    private GameObject RedHighLight;

    private Production production; // ���g�̐��Y���i���o�[���擾����p

    // Start is called before the first frame update
    void Start()
    {
        Clientlist = GameObject.Find("ClientList");

        for (int i = 0; i < request.Length ;i++) // ���K���C���X�y�N�^�[�Ŕz�񐔂����߂鎖
        {
            // �N���C�A���g���X�g�̗v����obj�ƃX�N���v�g�Ɨv�����n�C���C�gobj���擾
            request[i] = Clientlist.transform.GetChild(i).gameObject;
            Reqscript[i] = request[i].GetComponent<Request>();
            RequestHighLight[i] = request[i].transform.Find("BlueHighLight").gameObject;
        }

        RedHighLight = this.transform.Find("RedHighLight").gameObject;

        production = this.GetComponent<Production>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnHightLight() // ���Y���Ɨv�����������ł���΃n�C���C�g��\��
    {
        for (int i = 0; i < request.Length; i++)
        {
            if(Reqscript[i].request == production.production)
            {
                if (Clientlist)
                {
                    RequestHighLight[i].SetActive(true);
                }
            }
        }
        RedHighLight.SetActive(true);
    }

    public void OffHightLight()
    {
        for (int i = 0; i < request.Length; i++)
        {
            if (Clientlist)
            {
                RequestHighLight[i].SetActive(false);
            }
        }
        RedHighLight.SetActive(false);
    }
}
