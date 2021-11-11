using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image UI;
    public GameObject canvas;

    void Start()
    {
        canvas = GameObject.Find("Canvas");
    }

    void Update()
    {
    }

    public void Test()
    {
        Debug.Log("テスト");
    }

    public void UICreate(Image ui)
    {
        // UIを生成する
        UI = Instantiate(ui, this.transform.localPosition, this.transform.localRotation);
        // 名前に(Clone)が付かないようにする
        UI.name = ui.name;
        // UIをCanvasの子にする
        UI.transform.SetParent(this.canvas.transform, false);
        //UI.Init();

        Debug.Log("UI生成");
    }

    public void UIDestroy()
    {
        if (!UI)
        {
            return;
        }

        Destroy(UI.gameObject);
        Debug.Log("UI削除");
    }
}
