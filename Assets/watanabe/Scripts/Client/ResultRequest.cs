using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultRequest : MonoBehaviour
{
    [SerializeField] private Sprite[] RequestSprite;

    [SerializeField] private GameObject Minimana;
    [SerializeField] private MinigameManager Miniscript;

    [SerializeField] private int request;//要求物ナンバー、仮でint型

    // Start is called before the first frame update
    void Start()
    {
        Minimana = GameObject.Find("MinigameManager");
        Miniscript = Minimana.GetComponent<MinigameManager>();

        request = Miniscript.RequestData;

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
}
