using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//目標雇用数用管理スクリプト
public class Mission_Manager_Tanaka : MonoBehaviour
{
    [SerializeField] GameObject missionButton;

    DataBase database = null;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        Misiion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Misiion()
    {
        if (database.RewartState[11] == 2)
        {
            return;
        }
        int count = 0;
        while (count <= 12)
        {
            if (database.RewartState[count] == 1) break;
            count++;
        }

        if (database.EmploymentNum >= database.EmploymentTarget[count])//雇用数が目標雇用数より大きければ
        {
            missionButton.SetActive(true);//ミッション報酬受け取りボタンを表示
        }
    }

    
}
