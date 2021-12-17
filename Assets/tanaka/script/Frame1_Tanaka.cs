using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class Frame1_Tanaka : MonoBehaviour
{
    [SerializeField] GameObject missionbutton;
    [SerializeField] GameObject frame1;
    [SerializeField] GameObject frame2;

    [SerializeField] GameObject country1;
    [SerializeField] GameObject country2;
    [SerializeField] GameObject country3;



    DataBase database = null;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        int count = 0;
        while (count < 12)
        {
            if (database.RewartState[count] == 1) break;
            count++;
        }
        if (database.RewartState[count] == 1)
        {
            if (count + 1 >= 12)//�z��O��������
            {
                return;
            }
            switch (database.RewartContent[count])
            {
                case 0://���J�����J����
                    database.RewartState[count] = 2;
                    if (country1.activeSelf==false)
                    {
                        country1.SetActive(true);
                        break;
                    }
                    if (country2.activeSelf == false)
                    {
                        country2.SetActive(true);
                        break;
                    }
                    if (country3.activeSelf == false)
                    {
                        country3.SetActive(true);
                        break;
                    }
                    break;
                case 1://�h���[�����{�P
                    database.RewartState[count] = 2;
                    database.PossessionDroneNum++;
                    break;
                case 2://�h���[���@�\�g��
                    database.RewartState[count] = 2;
                    database.ExtensionStage++;
                    break;
                case 3://�������l��
                    database.RewartState[count] = 2;
                    database.LogisticsRights++;
                    break;
            }


            EditorUtility.SetDirty(database);
            AssetDatabase.SaveAssets();

            missionbutton.SetActive(false);
            frame1.SetActive(false);
            frame2.SetActive(false);
        }
    }
}
