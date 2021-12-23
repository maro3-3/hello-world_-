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
    public bool isSend; // 情報送信の確認

    public int debug; // 受け取ったデータを確認する為の仮変数



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

        //PageCreate(PageUI); // 一枚目のページを生成
        Debug.Log("再生成確認");
        // 生産者生成
        for (int i = 0; i < 3; i++) // 地域内、国内、国外の三種類分
        {
            switch (i)
            {
                case 0: // 同じ地域
                    for (int j = 0; j < database.manufacturers.Length; j++) // 生産者分forを回す
                    {
                        if (clientdata.sheets[0].list[database.MiniClieNo].int_CountryNo == database.manufacturers[j].ManufacturerCountryNo) // 国は同じか
                        {
                            if (clientdata.sheets[0].list[database.MiniClieNo].int_AreaNo == database.manufacturers[j].ManufacturerAreaNo)   // 地域は同じか
                            {
                                for (int k = 0; k < ProductsData.Length; k++)                    // クライアントの取引物の回数回す
                                {
                                    if (ProductsData[k] == database.manufacturers[j].Products)  // 取引物と要求物は同じか
                                    {
                                        // Productions[i]に名前を配置、場合によっては生産者を指定する数字も配置
                                        int PageNo = 0;
                                        bool PageSearch = false;
                                        for (int n = 0; n < ListPage.Count; n++) // 追加するページ選定
                                        {
                                            ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                            if (!page_scr.isAllUse) // 使ってないフレームがあるページ発見
                                            {
                                                PageNo = n;
                                                PageSearch = true;
                                            }
                                        }

                                        if (PageSearch) // 使えるページが見つかった場合
                                        {
                                            ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                            page_scr.ProductionCreate(j);
                                            break;
                                        }
                                        else
                                        {
                                            PageCreate(PageUI); // ページを作成
                                            for (int n = 0; n < ListPage.Count; n++) // 追加するページ選定
                                            {
                                                ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                                if (!page_scr.isAllUse) // 使ってないフレームがあるページ発見
                                                {
                                                    PageNo = n;
                                                    PageSearch = true;
                                                }
                                            }
                                            if (PageSearch) // 使えるページが見つかった場合
                                            {
                                                ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                                page_scr.ProductionCreate(j);
                                                break;
                                            }
                                        }
                                    }
                                }
                                
                                Debug.Log("同じ国、同じ地域の生産者抽選");
                            }
                        }
                    }
                    break;

                case 1:// 同じ国、違う地域
                    for (int j = 0; j < database.manufacturers.Length; j++) // 生産者分forを回す
                    {
                        if (clientdata.sheets[0].list[database.MiniClieNo].int_CountryNo == database.manufacturers[j].ManufacturerCountryNo) // 国は同じか
                        {
                            if (clientdata.sheets[0].list[database.MiniClieNo].int_AreaNo != database.manufacturers[j].ManufacturerAreaNo)   // 地域は違うか
                            {
                                for (int k = 0; k < ProductsData.Length; k++)                    // クライアントの取引物の回数回す
                                {
                                    if (ProductsData[k] == database.manufacturers[j].Products)  // 取引物と要求物は同じか
                                    {
                                        int PageNo = 0;
                                        bool PageSearch = false;
                                        for (int n = 0; n < ListPage.Count; n++) // 追加するページ選定
                                        {
                                            ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                            if (!page_scr.isAllUse) // 使ってないフレームがあるページ発見
                                            {
                                                PageNo = n;
                                                PageSearch = true;
                                            }
                                        }

                                        if (PageSearch) // 使えるページが見つかった場合
                                        {
                                            ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                            page_scr.ProductionCreate(j);
                                            break;

                                        }
                                        else
                                        {
                                            PageCreate(PageUI); // ページを作成
                                            for (int n = 0; n < ListPage.Count; n++) // 追加するページ選定
                                            {
                                                ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                                if (!page_scr.isAllUse) // 使ってないフレームがあるページ発見
                                                {
                                                    PageNo = n;
                                                    PageSearch = true;
                                                }
                                            }
                                            if (PageSearch) // 使えるページが見つかった場合
                                            {
                                                ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                                page_scr.ProductionCreate(j);
                                                break;
                                            }
                                        }
                                    }
                                }
                                Debug.Log("同じ国、違う地域の生産者抽選");
                            }
                        }
                    }
                    break;

                case 2:// 他国
                    for (int j = 0; j < database.manufacturers.Length; j++)// 生産者分forを回す
                    {
                        if (clientdata.sheets[0].list[database.MiniClieNo].int_CountryNo != database.manufacturers[j].ManufacturerCountryNo) // 国は違うか
                        {
                            for (int k = 0; k < ProductsData.Length; k++)                    // クライアントの取引物の回数回す
                            {
                                if (ProductsData[k] == database.manufacturers[j].Products)  // 取引物と要求物は同じか
                                {
                                    int PageNo = 0;
                                    bool PageSearch = false;
                                    for (int n = 0; n < ListPage.Count; n++) // 追加するページ選定
                                    {
                                        ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                        if (!page_scr.isAllUse) // 使ってないフレームがあるページ発見
                                        {
                                            PageNo = n;
                                            PageSearch = true;
                                        }
                                    }

                                    if (PageSearch) // 使えるページが見つかった場合
                                    {
                                        ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                        page_scr.MarkProductionCreate(j, MarkUI);
                                        break;
                                    }
                                    else
                                    {
                                        PageCreate(PageUI); // ページを作成
                                        for (int n = 0; n < ListPage.Count; n++) // 追加するページ選定
                                        {
                                            ProductionPage page_scr = ListPage[n].GetComponent<ProductionPage>();

                                            if (!page_scr.isAllUse) // 使ってないフレームがあるページ発見
                                            {
                                                PageNo = n;
                                                PageSearch = true;
                                            }
                                        }
                                        if (PageSearch) // 使えるページが見つかった場合
                                        {
                                            ProductionPage page_scr = ListPage[PageNo].GetComponent<ProductionPage>();
                                            page_scr.MarkProductionCreate(j, MarkUI);
                                            break;
                                        }
                                    }
                                }
                            }
                            Debug.Log("他国の生産者を抽選");
                        }
                    }
                    break;

                default:// エラー
                    Debug.Log("生産者の抽選に異常が生じています。");
                    break;
            }
        }

        GameObject[] pro_obj = GameObject.FindGameObjectsWithTag("Production");

        for(int i = 0; i < pro_obj.Length; i++)
        {
            Productions.Add(pro_obj[i]);
        }


        // ボタン初期化
        for (int i = 0; i < ProPageButton.Length; i++)
        {
            ProPageButton[i].GetComponent<ProductionPageButton>().Init();
        }

        // ページ非アクティブ設定
        for (int i = 0; i < ListPage.Count; i++)
        {
            ListPage[i].SetActive(false);
        }

        // プロダクションスクリプト設定
        for (int i = 0; i < Productions.Count; i++)
        {
            Pro_scr.Add(Productions[i].GetComponent<Production>());
        }

        // 一枚目のページをアクティブ化
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
            // 要求物の情報を取得していない状態
            for (int i = 0; i < Pro_scr.Count; i++)
            {
                if ((Pro_scr[i].Choice) && (Pro_scr[i]))
                {
                    Debug.Log("生産者を検出");
                    debug = Pro_scr[i].production;
                    isSearch = false;
                }
            }

        }
        else
        {
            // 要求物の情報を取得している状態
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
                // 情報送信完了
            }
        }

    }

    private void PageCreate(GameObject page)
    {
        // Pageを生成する
        GameObject Page = Instantiate(page, this.transform.localPosition, this.transform.localRotation);
        // 名前に(Clone)が付かないようにする
        Page.name = page.name;
        // Pageを自身の子にする
        Page.transform.SetParent(this.transform, false);

        // ページの位置を初期化。
        Transform myTrans = Page.transform;
        Vector3 pos = myTrans.localPosition;
        pos.x = 0.0f;
        pos.y = -25.0f;
        myTrans.localPosition = pos;

        ListPage.Add(Page);

        Debug.Log("生産者ページ生成");
    }
}
