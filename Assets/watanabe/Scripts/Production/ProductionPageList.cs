using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductionPageList : MonoBehaviour
{
    [SerializeField] DataBase database;
    [SerializeField] List_ClientInformation clientdata;

    [SerializeField] private GameObject PageUI;
    [SerializeField] private GameObject MarkUI;
    [SerializeField] private ProductionPageButton[] ProPageButton;

    [SerializeField] private List<GameObject> ListPage = new List<GameObject>();
    [SerializeField] private List<GameObject> Productions = new List<GameObject>();
    [SerializeField] private List<Production> Pro_scr = new List<Production>();

    public bool isSearch;
    public bool isSend; // ��񑗐M�̊m�F

    public int debug; // �󂯎�����f�[�^���m�F����ׂ̉��ϐ�



    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        clientdata = Resources.Load("List_ClientInformation") as List_ClientInformation;

        int[] ProductsData = { clientdata.sheets[0].list[database.MiniClieNo].int_Transaction_1,
                               clientdata.sheets[0].list[database.MiniClieNo].int_Transaction_2,
                               clientdata.sheets[0].list[database.MiniClieNo].int_Transaction_3,
                               clientdata.sheets[0].list[database.MiniClieNo].int_Transaction_4,
                               clientdata.sheets[0].list[database.MiniClieNo].int_Transaction_5,
                               clientdata.sheets[0].list[database.MiniClieNo].int_Transaction_6,};
        

        isSearch = true;
        isSend = false;

        //PageCreate(PageUI); // �ꖇ�ڂ̃y�[�W�𐶐�
        Debug.Log("�Đ����m�F");
        // ���Y�Ґ���
        for (int i = 0; i < 3; i++) // �n����A�����A���O�̎O��ޕ�
        {
            switch (i)
            {
                case 0: // �����n��
                    for (int j = 0; j < database.manufacturers.Length; j++) // ���Y�ҕ�for����
                    {
                        if (clientdata.sheets[0].list[database.MiniClieNo].int_CountryNo == database.manufacturers[j].ManufacturerCountryNo) // ���͓�����
                        {
                            if (clientdata.sheets[0].list[database.MiniClieNo].int_AreaNo == database.manufacturers[j].ManufacturerAreaNo)   // �n��͓�����
                            {
                                for (int k = 0; k < ProductsData.Length; k++)                    // �N���C�A���g�̎�����̉񐔉�
                                {
                                    if (ProductsData[k] == database.manufacturers[j].Products)  // ������Ɨv�����͓�����
                                    {
                                        // Productions[i]�ɖ��O��z�u�A�ꍇ�ɂ���Ă͐��Y�҂��w�肷�鐔�����z�u
                                        int PageNo = 0;
                                        bool PageSearch = false;
                                        for (int n = 0; n < ListPage.Count; n++) // �ǉ�����y�[�W�I��
                                        {
                                            ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                            if (!page_scr.isAllUse) // �g���ĂȂ��t���[��������y�[�W����
                                            {
                                                PageNo = n;
                                                PageSearch = true;
                                            }
                                        }

                                        if (PageSearch) // �g����y�[�W�����������ꍇ
                                        {
                                            ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                            page_scr.ProductionCreate(j);
                                            break;
                                        }
                                        else
                                        {
                                            PageCreate(PageUI); // �y�[�W���쐬
                                            for (int n = 0; n < ListPage.Count; n++) // �ǉ�����y�[�W�I��
                                            {
                                                ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                                if (!page_scr.isAllUse) // �g���ĂȂ��t���[��������y�[�W����
                                                {
                                                    PageNo = n;
                                                    PageSearch = true;
                                                }
                                            }
                                            if (PageSearch) // �g����y�[�W�����������ꍇ
                                            {
                                                ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                                page_scr.ProductionCreate(j);
                                                break;
                                            }
                                        }
                                    }
                                }
                                
                                Debug.Log("�������A�����n��̐��Y�Ғ��I");
                            }
                        }
                    }
                    break;

                case 1:// �������A�Ⴄ�n��
                    for (int j = 0; j < database.manufacturers.Length; j++) // ���Y�ҕ�for����
                    {
                        if (clientdata.sheets[0].list[database.MiniClieNo].int_CountryNo == database.manufacturers[j].ManufacturerCountryNo) // ���͓�����
                        {
                            if (clientdata.sheets[0].list[database.MiniClieNo].int_AreaNo != database.manufacturers[j].ManufacturerAreaNo)   // �n��͈Ⴄ��
                            {
                                for (int k = 0; k < ProductsData.Length; k++)                    // �N���C�A���g�̎�����̉񐔉�
                                {
                                    if (ProductsData[k] == database.manufacturers[j].Products)  // ������Ɨv�����͓�����
                                    {
                                        int PageNo = 0;
                                        bool PageSearch = false;
                                        for (int n = 0; n < ListPage.Count; n++) // �ǉ�����y�[�W�I��
                                        {
                                            ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                            if (!page_scr.isAllUse) // �g���ĂȂ��t���[��������y�[�W����
                                            {
                                                PageNo = n;
                                                PageSearch = true;
                                            }
                                        }

                                        if (PageSearch) // �g����y�[�W�����������ꍇ
                                        {
                                            ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                            page_scr.ProductionCreate(j);
                                            break;

                                        }
                                        else
                                        {
                                            PageCreate(PageUI); // �y�[�W���쐬
                                            for (int n = 0; n < ListPage.Count; n++) // �ǉ�����y�[�W�I��
                                            {
                                                ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                                if (!page_scr.isAllUse) // �g���ĂȂ��t���[��������y�[�W����
                                                {
                                                    PageNo = n;
                                                    PageSearch = true;
                                                }
                                            }
                                            if (PageSearch) // �g����y�[�W�����������ꍇ
                                            {
                                                ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                                page_scr.ProductionCreate(j);
                                                break;
                                            }
                                        }
                                    }
                                }
                                Debug.Log("�������A�Ⴄ�n��̐��Y�Ғ��I");
                            }
                        }
                    }
                    break;

                case 2:// ����
                    for (int j = 0; j < database.manufacturers.Length; j++)// ���Y�ҕ�for����
                    {
                        if (clientdata.sheets[0].list[database.MiniClieNo].int_CountryNo != database.manufacturers[j].ManufacturerCountryNo) // ���͈Ⴄ��
                        {
                            for (int k = 0; k < ProductsData.Length; k++)                    // �N���C�A���g�̎�����̉񐔉�
                            {
                                if (ProductsData[k] == database.manufacturers[j].Products)  // ������Ɨv�����͓�����
                                {
                                    int PageNo = 0;
                                    bool PageSearch = false;
                                    for (int n = 0; n < ListPage.Count; n++) // �ǉ�����y�[�W�I��
                                    {
                                        ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                        if (!page_scr.isAllUse) // �g���ĂȂ��t���[��������y�[�W����
                                        {
                                            PageNo = n;
                                            PageSearch = true;
                                        }
                                    }

                                    if (PageSearch) // �g����y�[�W�����������ꍇ
                                    {
                                        ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                        page_scr.MarkProductionCreate(j, MarkUI);
                                        break;
                                    }
                                    else
                                    {
                                        PageCreate(PageUI); // �y�[�W���쐬
                                        for (int n = 0; n < ListPage.Count; n++) // �ǉ�����y�[�W�I��
                                        {
                                            ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                            if (!page_scr.isAllUse) // �g���ĂȂ��t���[��������y�[�W����
                                            {
                                                PageNo = n;
                                                PageSearch = true;
                                            }
                                        }
                                        if (PageSearch) // �g����y�[�W�����������ꍇ
                                        {
                                            ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                            page_scr.MarkProductionCreate(j, MarkUI);
                                            break;
                                        }
                                    }
                                }
                            }
                            Debug.Log("�����̐��Y�҂𒊑I");
                        }
                    }
                    break;

                default:// �G���[
                    Debug.Log("���Y�҂̒��I�Ɉُ킪�����Ă��܂��B");
                    break;
            }
        }

        GameObject[] pro_obj = GameObject.FindGameObjectsWithTag("Production");

        for(int i = 0; i < pro_obj.Length; i++)
        {
            Productions.Add(pro_obj[i]);
        }


        // �{�^��������
        for (int i = 0; i < ProPageButton.Length; i++)
        {
            ProPageButton[i].GetComponent<ProductionPageButton>().Init();
        }

        // �y�[�W��A�N�e�B�u�ݒ�
        for (int i = 0; i < ListPage.Count; i++)
        {
            ListPage[i].SetActive(false);
        }

        // �v���_�N�V�����X�N���v�g�ݒ�
        for (int i = 0; i < Productions.Count; i++)
        {
            Pro_scr.Add(Productions[i].GetComponent<Production>());
        }

        // �ꖇ�ڂ̃y�[�W���A�N�e�B�u��
        ListPage[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < Productions.Count; i++)
        {
            if(!Productions[i])
            {
                Productions.RemoveAt(i);
                Pro_scr.RemoveAt(i);
            }
        }
        if (isSearch)
        {
            // �v�����̏����擾���Ă��Ȃ����
            for (int i = 0; i < Pro_scr.Count; i++)
            {
                if ((Pro_scr[i].Choice) && (Pro_scr[i]))
                {
                    Debug.Log("���Y�҂����o");
                    debug = Pro_scr[i].production;
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
                for (int i = 0; i < ProPageButton.Length; i++)
                {
                    ProPageButton[i].GetComponent<ProductionPageButton>().ThisUnActive();
                }
                // ��񑗐M����
            }
        }

    }

    private void PageCreate(GameObject page)
    {
        // Page�𐶐�����
        GameObject Page = Instantiate(page, this.transform.localPosition, this.transform.localRotation);
        // ���O��(Clone)���t���Ȃ��悤�ɂ���
        Page.name = page.name;
        // Page�����g�̎q�ɂ���
        Page.transform.SetParent(this.transform, false);

        // �y�[�W�̈ʒu���������B
        Transform myTrans = Page.transform;
        Vector3 pos = myTrans.localPosition;
        pos.x = 0.0f;
        pos.y = -25.0f;
        myTrans.localPosition = pos;

        ListPage.Add(Page);

        Debug.Log("���Y�҃y�[�W����");
    }
}
