using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//�ڕW�ٗp���p�Ǘ��X�N���v�g
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

        if (database.EmploymentNum >= database.EmploymentTarget[count])//�ٗp�����ڕW�ٗp�����傫�����
        {
            missionButton.SetActive(true);//�~�b�V������V�󂯎��{�^����\��
        }
    }

    
}
