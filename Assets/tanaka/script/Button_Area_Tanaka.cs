using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button_Area_Tanaka : MonoBehaviour
{
    [SerializeField] private RectTransform map;//�n�}�̃T�C�Y�ύX�̂��߂ɃI�u�W�F�N�g�擾

    //�\������n��
    [SerializeField] GameObject area1;  
    [SerializeField] GameObject area2;
    [SerializeField] GameObject area3;

    //���{�^�������p
    [SerializeField] GameObject country1;
    [SerializeField] GameObject country2;
    [SerializeField] GameObject country3;
    [SerializeField] GameObject country4;
    [SerializeField] GameObject country5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(int area)
    {
        //�X�P�[���ύX-----------------------------
        float mapw = 5000;
        float maph = 3000;
        map.sizeDelta = new Vector2(mapw, maph);
        //----------------------------------------

        //�|�W�V�����ύX-------------
        Vector3 pos;
        pos.x = 900;
        pos.y = -545;
        pos.z = 0;
        switch (area)
        {
            case 0:
                pos.x = 900;
                pos.y = -545;
                pos.z = 0;
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                break;
        }

        map.localPosition = pos;
        //-------------------------


        //�{�^����\��������----------
        area1.SetActive(true);
        area2.SetActive(true);
        area3.SetActive(true);
        //--------------------------
        //��\���ɂ���---------------
        country1.SetActive(false);
        country2.SetActive(false);
        country3.SetActive(false);
        country4.SetActive(false);
        country5.SetActive(false);
        //--------------------------
    }
}
