using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Client_Onodera : MonoBehaviour

{
    // Start is called before the first frame update
    // public string teststring;
    //public Button button;
    [SerializeField] GameObject Client;
    public int ClieCountry = 0;//�N���C�A���g�̍� 1�A�����J�@   2�����@3���V�A�@4�I�[�X�g�����A�@5��A�t���J
    public int ClieArea = 0;//�N���C�A���g�̒n��@1�j���[���[�N�@�k���@���X�N�� �L�����y���@     �v���g���A
                            //                    2�Z���g���C�X�@��C�@�E�t�@�@ �p�[�X�@         �u���[���t�H���e�C��
                            //                    3�A�g�����^�@�@�l��@�@�@�@�@ �����{�����@�@�@ �P�[�v�^�E��
    public int ClieNum = 0;
    //DataBase database = new DataBase();
    //DataBase.Client[] clients;
    int Arealv;

    void Start()
    {
        
        Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
    }

    void Update()
    {
       if( ClieNum>Arealv)
        {
            Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
            Client.SetActive(false);
        }
        else
        {
            Client.SetActive(true);
        }
    }

}
