using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionPageButton : MonoBehaviour
{
    [SerializeField] private List<GameObject> ProductionPages = new List<GameObject>();

   // Start is called before the first frame update
    void Start()
    {

    }

    public void Init()
    {
        GameObject[] page_obj = GameObject.FindGameObjectsWithTag("ProductionPage"); // ページを全て取得
        for (int i = 0; i < page_obj.Length; i++)
        {
            ProductionPages.Add(page_obj[i]);
        }
    }

    public void ThisUnActive()
    {
        this.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < ProductionPages.Count; i++)
        {
            if (!ProductionPages[i])
            {
                ProductionPages.RemoveAt(i);
            }
        }
    }

    public void PageChengeRight()
    {
        for(int i = 0; i < ProductionPages.Count; i++)
        {
            if(ProductionPages[i].activeSelf)
            {
                if (i == ProductionPages.Count - 1)
                {
                    break;
                }
                else
                {
                    ProductionPages[i].SetActive(false);
                    ProductionPages[i + 1].SetActive(true);
                    Debug.Log("うんちうんち");
                    break;
                }
            }
        }
    }

    public void PageChengeLeft()
    {
        for (int i = 0; i < ProductionPages.Count; i++)
        {
            if (ProductionPages[i].activeSelf)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    ProductionPages[i].SetActive(false);
                    ProductionPages[i - 1].SetActive(true);
                    Debug.Log("うんちうんち");
                    break;
                }
            }
        }
    }

}
