using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button_Seni_Tanaka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick_Genchi()//���n��ʔ�ԁi�e�X�g�^�p�j
    {
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
    public void OnClick_Sekai()
    {
        SceneManager.LoadScene("SekaiGamen");
    }
}
