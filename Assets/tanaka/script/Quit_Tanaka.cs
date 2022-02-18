using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit_Tanaka : MonoBehaviour
{

    [SerializeField] Area_Tanaka area_t = null;
    [SerializeField] DataBase database = null;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//esc‰Ÿ‚µ‚½‚ç
        {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif

        }
    }
}
