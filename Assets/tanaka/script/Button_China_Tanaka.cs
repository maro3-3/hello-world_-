using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_China_Tanaka : MonoBehaviour
{
    [SerializeField] private GameObject map;//�n�}�̃T�C�Y�ύX�̂��߂ɃI�u�W�F�N�g�擾

    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] GameObject button3;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("�����ꂽ");  // ���O���o��


        //�X�P�[���ύX-------------------------------------------------------------------------------
        float mapw = 5000;
        float maph = 3000;
        map.GetComponent<RectTransform>().sizeDelta = new Vector2(mapw, maph);
        //------------------------------------------------------------------------------------------

        //�|�W�V�����ύX-----------------------------------------------------------------------------
        // Vector3 pos = (855,-469,0);
        Vector3 pos;
        pos.x = 855;
        pos.y = -469;
        pos.z = 0;
        //map.transform.position = pos;
        // Debug.Log(pos.x);
        //map.localPosition = new Vector3(pos.x, pos.y, pos.z);
        //------------------------------------------------------------------------------------------


        //�{�^����\��������----------
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        //--------------------------
        //��\���ɂ���----------------------------
        this.gameObject.SetActive(false);
        //---------------------------------------
    }
}
