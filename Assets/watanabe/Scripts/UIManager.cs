using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image[] Image;
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
        Debug.Log("�e�X�g");
    }

    public void UICreate(Image ui)
    {
        // UI�𐶐�����
        UI = Instantiate(ui, this.transform.localPosition, this.transform.localRotation);
        UI.transform.SetParent(this.canvas.transform, false);
        //UI.Init();

        Debug.Log("UI����");
    }

    public void UIDestroy()
    {
        Destroy(UI.gameObject);

        Debug.Log("UI�폜");
    }
}
