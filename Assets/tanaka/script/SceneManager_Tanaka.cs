using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//�V�[���}�l�[�W���[
public class SceneManager_Tanaka : MonoBehaviour
{
    public Area_Tanaka area_t;

    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(area_t.area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Genchi()//���n��ʔ�ԁi�e�X�g�^�p�j
    {
        //�^�[��+�P
        //transform.tag�Ń^�O�擾�[�^�O�ɑΉ�����ꏊ�ɔ�ԁH
        //�G���A�ɔԍ��ۑ�
        SceneManager.LoadScene("Genchi");
    }

    public void OnClick_Homepage()//�z�[���y�[�W�ɑJ��
    {
        SceneManager.LoadScene("homepage");
    }

    public void OnClick_Flymo()//fly.m.o����o��i�����錻�n�ɖ߂�H�j�e�X�g�^�p
    {
        SceneManager.LoadScene("test");
    }
    public void OnClick_Sekai()//���E��ʂւ̑J��
    {
        SceneManager.LoadScene("SekaiGamen");
    }
}
