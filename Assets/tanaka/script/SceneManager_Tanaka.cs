using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//�V�[���}�l�[�W���[
public class SceneManager_Tanaka : MonoBehaviour
{
    [SerializeField] Area_Tanaka area_t = null;//�G���A�̃f�[�^
  //  [SerializeField] DataBase_Tanaka database = null;
    DataBase database = null;
    GameObject turnmanager;
    // Start is called before the first frame update
    void Start()
    {
        turnmanager = GameObject.Find("TurnManager");
        database = Resources.Load<DataBase>("DataBase");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Genchi()//���n��ʔ�ԁi�e�X�g�^�p�j
    {
        //�^�[��+�P
        // turnmanager.GetComponent<TurnManager_ishikado>().TurnUp();
        //database.TurnNum++;
        Turn();
        area_t.area++;
        //transform.tag�Ń^�O�擾�[�^�O�ɑΉ�����ꏊ�ɔ�ԁH
        //�G���A�ɔԍ��ۑ�
        SceneManager.LoadScene("Genchi");
    }

    public void Onclick_TitleToGenchi()
    {
        SceneManager.LoadScene("Genchi");
    }

    public void OnClick_Homepage()//�z�[���y�[�W�ɑJ��
    {
        SceneManager.LoadScene("homepage");
    }

    public void OnClick_Flymo()//fly.m.o����o��i�����錻�n�ɖ߂�H�j�e�X�g�^�p
    {
        
       // turnmanager.GetComponent<TurnManager_ishikado>().TurnUp();
        SceneManager.LoadScene("Genchi");
    }
    public void OnClick_Sekai()//���E��ʂւ̑J��
    {
        SceneManager.LoadScene("SekaiGamen");
    }

    public void OnClick_Minigame()//�~�j�Q�[����ʂւ̑J��
    {
        SceneManager.LoadScene("minigame");
    }

    void Turn()
    {
        database.TurnNum++;
    }
}
