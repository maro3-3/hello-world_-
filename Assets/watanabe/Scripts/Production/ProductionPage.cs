using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductionPage : MonoBehaviour
{
    public List<GameObject> ChildProFrame = new List<GameObject>(); // 子のProductionFrame
    //public List<GameObject> ChildProduction = new List<GameObject>(); // 子のProduction
    [SerializeField] private Production Production_obj;
    public bool isAllUse; //全てのProductionFrameにProductionが設置されていたらtrue;

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
        Debug.Log("チェックはしてる");
        Child_transform = this.gameObject.GetComponentInChildren<Transform>();
        for (int i = 0; i < Child_transform.childCount; i++)
        {
            ProductionFrame frame_sr = ChildProFrame[i].GetComponent<ProductionFrame>();
            if (!frame_sr.isUse)
            {
                Debug.Log("未使用フレームがあります。");
            }
        }
        isAllUse = true;
        Debug.Log("全ての使用フレームに生産者がいます。");
    }

    public void ProductionCreate(int no) // 生産者番号(j)
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
        Debug.Log("フレームナンバー" + Frame_no);
        // Productionを生成する
        Production OBJ = Instantiate(Production_obj);
        // 名前に(Clone)が付かないようにする
        OBJ.name = Production_obj.name;
        // Productionを指定したproductionFrameの子にする
        OBJ.transform.SetParent(this.ChildProFrame[Frame_no].transform, false);

        OBJ.Production_Text.text = database.manufacturers[no].ManufacturerName;
        OBJ.production = database.manufacturers[no].Products;

        ChildProFrame[Frame_no].GetComponent<ProductionFrame>().Init();

        Debug.Log("生産者リストに生産者を生成");

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

    public void MarkProductionCreate(int no, GameObject mark) // 生産者番号(j)
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
        Debug.Log("フレームナンバー" + Frame_no);
        // Productionを生成する
        Production OBJ = Instantiate(Production_obj);
        // 名前に(Clone)が付かないようにする
        OBJ.name = Production_obj.name;
        // Productionを指定したproductionFrameの子にする
        OBJ.transform.SetParent(this.ChildProFrame[Frame_no].transform, false);
        OBJ.Production_Text.text = database.manufacturers[no].ManufacturerName;
        OBJ.production = database.manufacturers[no].Products;
        OBJ.thisNo = no;
        ChildProFrame[Frame_no].GetComponent<ProductionFrame>().Init();

        // 高難易度マーク生成、調整
        GameObject Mark_obj = Instantiate(mark);
        Mark_obj.name = mark.name;
        Transform myTrans = Mark_obj.transform;
        Vector3 pos = myTrans.localPosition;
        pos.x = 45.0f;
        pos.y = 0.0f;
        myTrans.localPosition = pos;
        Mark_obj.transform.SetParent(OBJ.transform, false);
        OBJ.GetComponent<Production>().MarkInit();

        Debug.Log("生産者リストに生産者を生成");

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
