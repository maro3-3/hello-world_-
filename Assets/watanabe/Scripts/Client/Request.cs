using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Request : MonoBehaviour// データベースから要求物を受け取り、所持する
{

    [SerializeField] private Sprite[] RequestSprite;
    [SerializeField] private GameObject RedHighLight;

    public int request;//要求物ナンバー、仮でint型
    public bool Highlight; // ハイライトする場合true
    public bool Choice;

    // Start is called before the first frame update
    void Start()
    {
        Highlight = false;
        Choice = false;

        RedHighLight = this.transform.Find("RedHighLight").gameObject;

        switch (request)
        {
            case 0:
                ChengeSprite();
                break;

            case 1:
                ChengeSprite();
                break;

            case 2:
                ChengeSprite();
                break;

            case 3:
                ChengeSprite();
                break;

            case 4:
                ChengeSprite();
                break;

            case 5:
                ChengeSprite();
                break;

            case 6:
                ChengeSprite();
                break;

            case 7:
                ChengeSprite();
                break;

            case 8:
                ChengeSprite();
                break;

            case 9:
                ChengeSprite();
                break;

            case 10:
                ChengeSprite();
                break;

            default:
                NoRequestSprite();
                Debug.Log("取引物なし");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ChengeSprite()
    {
        GameObject ChildRequest = transform.Find("RequestSprite").gameObject;
        Image ChildImage = ChildRequest.GetComponent<Image>();

        ChildImage.sprite = RequestSprite[request];
    }

    private void NoRequestSprite()
    {
        GameObject ChildRequest = transform.Find("RequestSprite").gameObject;
        Image ChildImage = ChildRequest.GetComponent<Image>();

        ChildImage.SetOpacity(0.0f);
    }

    public void OnHightLight()
    {
        GameObject Minimana = GameObject.Find("MinigameManager");
        MinigameManager Mini_scr = Minimana.GetComponent<MinigameManager>();

        Mini_scr.intHighLight = request;

        GameObject[] Productions = GameObject.FindGameObjectsWithTag("Production");

        for (int i = 0; i < Productions.Length; i++)
        {
            Production Proscript = Productions[i].GetComponent<Production>();
            GameObject ProductionHighLight = Productions[i].transform.Find("DarkHighLight").gameObject;
            if (Proscript.production == Mini_scr.intHighLight)
            {
                ProductionHighLight.SetActive(true);
            }
        }

        RedHighLight.SetActive(true);
    }

    public void OffHightLight()
    {
        GameObject[] Productions = GameObject.FindGameObjectsWithTag("Production");

        for (int i = 0; i < Productions.Length; i++)
        {
            GameObject ProductionHighLight = Productions[i].transform.Find("DarkHighLight").gameObject;
            ProductionHighLight.SetActive(false);
        }

        RedHighLight.SetActive(false);
    }
}
