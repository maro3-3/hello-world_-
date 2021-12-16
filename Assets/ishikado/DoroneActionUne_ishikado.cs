using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoroneActionUne_ishikado : MonoBehaviour
{
    DataBase database = null;
    int UnemployedNum;

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
    }

    // Update is called once per frame
    void Update()
    {

    }
}