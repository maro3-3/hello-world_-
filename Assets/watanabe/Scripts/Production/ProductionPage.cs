using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductionPage : MonoBehaviour
{
    public List<GameObject> ChildProFrame = new List<GameObject>(); // �q��ProductionFrame
    //public List<GameObject> ChildProduction = new List<GameObject>(); // �q��Production
    [SerializeField] private Production Production_obj;
    public bool isAllUse; //�S�Ă�ProductionFrame��Production���ݒu����Ă�����true;

    //[SerializeField] private GameObject[] Child_obj;
    [SerializeField] private Transform Child_transform;

    public int debug;

    void Awake()
    {
        Child_transform = this.gameObject.GetComponentInChildren<Transform>();
        for (int i = 0; i < Child_transform.childCount; i++)
        {
            GameObject obj = transform.GetChild(i).gameObject;
            ChildProFrame.Add(obj);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isAllUse = false;
        Child_transform = this.gameObject.GetComponentInChildren<Transform>();
        debug = Child_transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PageCheck()
    {
        Debug.Log("�`�F�b�N�͂��Ă�");
        Child_transform = this.gameObject.GetComponentInChildren<Transform>();
        for (int i = 0; i < Child_transform.childCount; i++)
        {
            ProductionFrame frame_sr = ChildProFrame[i].GetComponent<ProductionFrame>();
            if (!frame_sr.isUse)
            {
                Debug.Log("���g�p�t���[��������܂��B");
            }
        }
        isAllUse = true;
        Debug.Log("�S�Ă̎g�p�t���[���ɐ��Y�҂����܂��B");
    }

    public void ProductionCreate(int no) // ���Y�Ҕԍ�(j)
    {
        int Frame_no = 0;
        ProductionFrame frame_scr;
        for (int i = 0; i < Child_transform.childCount; i++)
        {
            frame_scr = ChildProFrame[i].GetComponent<ProductionFrame>();
            //Transform frame_trans = ChildProFrame[i].GetComponent<Transform>();
            if (!frame_scr.isUse)
            {
                Frame_no = i;
                frame_scr.isUse = true;
                break;
            }
        }

        DataBase database = Resources.Load<DataBase>("DataBase");
        Debug.Log("�t���[���i���o�[" + Frame_no);
        // Production�𐶐�����
        Production OBJ = Instantiate(Production_obj);
        // ���O��(Clone)���t���Ȃ��悤�ɂ���
        OBJ.name = Production_obj.name;
        // Production���w�肵��productionFrame�̎q�ɂ���
        OBJ.transform.SetParent(this.ChildProFrame[Frame_no].transform, false);

        OBJ.Production_Text.text = database.manufacturers[no].ManufacturerName;
        OBJ.production = database.manufacturers[no].Products;

        ChildProFrame[Frame_no].GetComponent<ProductionFrame>().Init();

        Debug.Log("���Y�҃��X�g�ɐ��Y�҂𐶐�");

        for (int i = 0; i < Child_transform.childCount; i++)
        {
            frame_scr = ChildProFrame[i].GetComponent<ProductionFrame>();
            if(!frame_scr.isUse)
            {
                return;
            }
        }
        isAllUse = true;
    }

    public void MarkProductionCreate(int no, GameObject mark) // ���Y�Ҕԍ�(j)
    {
        int Frame_no = 0;
        ProductionFrame frame_scr;
        for (int i = 0; i < Child_transform.childCount; i++)
        {
            frame_scr = ChildProFrame[i].GetComponent<ProductionFrame>();
            //Transform frame_trans = ChildProFrame[i].GetComponent<Transform>();
            if (!frame_scr.isUse)
            {
                Frame_no = i;
                frame_scr.isUse = true;
                break;
            }
        }

        DataBase database = Resources.Load<DataBase>("DataBase");
        Debug.Log("�t���[���i���o�[" + Frame_no);
        // Production�𐶐�����
        Production OBJ = Instantiate(Production_obj);
        // ���O��(Clone)���t���Ȃ��悤�ɂ���
        OBJ.name = Production_obj.name;
        // Production���w�肵��productionFrame�̎q�ɂ���
        OBJ.transform.SetParent(this.ChildProFrame[Frame_no].transform, false);
        OBJ.Production_Text.text = database.manufacturers[no].ManufacturerName;
        OBJ.production = database.manufacturers[no].Products;
        OBJ.thisNo = no;
        ChildProFrame[Frame_no].GetComponent<ProductionFrame>().Init();

        // ����Փx�}�[�N�����A����
        GameObject Mark_obj = Instantiate(mark);
        Mark_obj.name = mark.name;
        Transform myTrans = Mark_obj.transform;
        Vector3 pos = myTrans.localPosition;
        pos.x = 45.0f;
        pos.y = 0.0f;
        myTrans.localPosition = pos;
        Mark_obj.transform.SetParent(OBJ.transform, false);
        OBJ.GetComponent<Production>().MarkInit();

        Debug.Log("���Y�҃��X�g�ɐ��Y�҂𐶐�");

        for (int i = 0; i < Child_transform.childCount; i++)
        {
            frame_scr = ChildProFrame[i].GetComponent<ProductionFrame>();
            if (!frame_scr.isUse)
            {
                return;
            }
        }
        isAllUse = true;
    }
}
