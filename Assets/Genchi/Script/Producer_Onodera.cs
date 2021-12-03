using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Producer_Onodera : MonoBehaviour
{
    [SerializeField] GameObject Producer;
    public int ProdCountry = 0;//���Y�҂̍� 1�A�����J�@   2�����@3���V�A�@4�I�[�X�g�����A�@5��A�t���J
    public int ProdArea = 0;//���Y�҂̒n��@1�j���[���[�N�@�k���@���X�N�� �L�����y���@     �v���g���A
                            //                    2�Z���g���C�X�@��C�@�E�t�@�@ �p�[�X�@         �u���[���t�H���e�C��
                            //                    3�A�g�����^�@�@�l��@�@�@�@�@ �����{�����@�@�@ �P�[�v�^�E��
    public int ProdNum = 0;
    //DataBase database = new DataBase();
    //DataBase.Client[] clients;
    int Arealv;

    void Start()
    {

        Arealv = Areamanager_Onodera.GetArealv(ProdCountry, ProdArea);
    }

    void Update()
    {
        if (ProdNum > Arealv)
        {
            Arealv = Areamanager_Onodera.GetArealv(ProdCountry, ProdArea);
            Producer.SetActive(false);
        }
        else
        {
            Producer.SetActive(true);
        }
    }
}
