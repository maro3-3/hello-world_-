using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoroneAction_ishikado : MonoBehaviour
{
    public void WindowActive()
    {
        gameObject.SetActive(true);//表示
    }

    public void WindowHide()
    {
        gameObject.SetActive(false);//非表示
    }
}
