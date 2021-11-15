using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testkaneko : MonoBehaviour
{
    DataBase database = null;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
        // ScriptableObject�̎擾
        database = Resources.Load<DataBase>("DataBase");

    }
    // Update is called once per frame
    void Update()
    {
    }
}
