using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameClear_Tanaka : MonoBehaviour
{
    float fadeSpeed = 0.001f;        //�����x���ς��X�s�[�h���Ǘ�
    float red, green, blue, alfa;   //�p�l���̐F�A�s�����x���Ǘ�

    public bool isFadeOut = false;  //�t�F�[�h�A�E�g�����̊J�n�A�������Ǘ�����t���O

    Image fadeImage;

    DataBase database = null;
    // Start is called before the first frame update
    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        database = Resources.Load<DataBase>("DataBase");
    }

    // Update is called once per frame
    void Update()
    {
        if (database.UnemployedNum > 0)
        {
            if(database.EmploymentNum== database.UnemployedNum)
            {
                fade();
            }
        }
    }

    void fade()
    {
        fadeImage.enabled = true;  // a)�p�l���̕\�����I���ɂ���
        alfa += fadeSpeed;         // b)�s�����x�����X�ɂ�����
        SetAlpha();               // c)�ύX���������x���p�l���ɔ��f����
        if (alfa >= 1)
        {             // d)���S�ɕs�����ɂȂ����珈���𔲂���
            isFadeOut = false;
            SceneManager.LoadScene("GameClear");
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
