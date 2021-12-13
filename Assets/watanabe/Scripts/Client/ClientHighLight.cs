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
    [SerializeField] private GameObject RedHighLight;

    private Request request; // ���g�̐��Y���i���o�[���擾����p

    // Start is called before the first frame update
    void Start()
    {
        //Productionlist = GameObject.Find("ProductionList");
        RedHighLight = this.transform.Find("RedHighLight").gameObject;
        //for (int i = 0; i < production.Length; i++) // ���K���C���X�y�N�^�[�Ŕz�񐔂����߂鎖
        //{
        //    // �N���C�A���g���X�g�̗v����obj�ƃX�N���v�g�Ɨv�����n�C���C�gobj���擾
        //    production[i] = Productionlist.transform.GetChild(i).gameObject;
        //    Proscript[i] = production[i].GetComponent<Production>();
        //    ProductionHighLight[i] = production[i].transform.Find("DarkHighLight").gameObject;
        //}
        //request = this.GetComponent<Request>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Productionlist == null)
        //{
        //    Productionlist = GameObject.Find("ProductionList");
        //    for (int i = 0; i < production.Length; i++) // ���K���C���X�y�N�^�[�Ŕz�񐔂����߂鎖
        //    {
        //        // �N���C�A���g���X�g�̗v����obj�ƃX�N���v�g�Ɨv�����n�C���C�gobj���擾
        //        production[i] = Productionlist.transform.GetChild(i).gameObject;
        //        Proscript[i] = production[i].GetComponent<Production>();
        //        ProductionHighLight[i] = production[i].transform.Find("DarkHighLight").gameObject;
        //    }
        //}
    }

    public void OnHightLight() // ���Y���Ɨv�����������ł���΃n�C���C�g��\��
    {
        GameObject Minimana = GameObject.Find("MinigameManager");
        MinigameManager Mini_scr = Minimana.GetComponent<MinigameManager>();

        GameObject[] Productions = GameObject.FindGameObjectsWithTag("Production");
        //Production Proscript = ProHighLights[i].transform.parent.GetComponent<Production>();

        for (int i = 0; i < Productions.Length; i++)
        {
            Debug.Log(Productions.Length);
            Production Proscript = Productions[i].GetComponent<Production>();
            GameObject ProductionHighLight = Productions[i].transform.Find("DarkHighLight").gameObject;
            if (Proscript.production == Mini_scr.intHighLight)
            {
                Debug.Log(Proscript.production);
                ProductionHighLight.SetActive(true);
            }
        }
        RedHighLight.SetActive(true);
    }

    public void OffHightLight()
    {
        //for (int i = 0; i < production.Length; i++)
        //{
        //    ProductionHighLight[i].SetActive(false);
        //}
        GameObject[] Productions = GameObject.FindGameObjectsWithTag("Production");
        //Production Proscript = ProHighLights[i].transform.parent.GetComponent<Production>();

        for (int i = 0; i < Productions.Length; i++)
        {
            GameObject ProductionHighLight = Productions[i].transform.Find("DarkHighLight").gameObject;
            ProductionHighLight.SetActive(false);
        }
        RedHighLight.SetActive(false);
    }
}
