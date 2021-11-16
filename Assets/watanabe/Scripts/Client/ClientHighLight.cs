using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// �N���C�A���g���X�g�����Y�҃��X�g�ŏ����ɂ��Ă͂܂���̂��n�C���C�g������
public class ClientHighLight : MonoBehaviour
{
    private GameObject Productionlist;
    [SerializeField] private GameObject[] production;
    [SerializeField] private Production[] Proscript;
    [SerializeField] private GameObject[] ProductionHighLight;
    private GameObject RedHighLight;

    private Request request; // ���g�̐��Y���i���o�[���擾����p

    // Start is called before the first frame update
    void Start()
    {
        Productionlist = GameObject.Find("ProductionList");

        for (int i = 0; i < production.Length; i++) // ���K���C���X�y�N�^�[�Ŕz�񐔂����߂鎖
        {
            // �N���C�A���g���X�g�̗v����obj�ƃX�N���v�g�Ɨv�����n�C���C�gobj���擾
            production[i] = Productionlist.transform.GetChild(i).gameObject;
            Proscript[i] = production[i].GetComponent<Production>();
            ProductionHighLight[i] = production[i].transform.Find("DarkHighLight").gameObject;
        }

        RedHighLight = this.transform.Find("RedHighLight").gameObject;

        request = this.GetComponent<Request>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnHightLight() // ���Y���Ɨv�����������ł���΃n�C���C�g��\��
    {
        for (int i = 0; i < production.Length; i++)
        {
            if (Proscript[i].production == request.request)
            {
                ProductionHighLight[i].SetActive(true);
            }
        }
        RedHighLight.SetActive(true);

    }

    public void OffHightLight()
    {
        for (int i = 0; i < production.Length; i++)
        {
            ProductionHighLight[i].SetActive(false);
        }
        RedHighLight.SetActive(false);
    }
}
