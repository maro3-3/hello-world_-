using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject ZAF_AreaPage_Client_Panel;   // ��A�t���J�n��N���C�A���g�y�[�W

    [SerializeField] private GameObject ZAF_Pretoria_ClientList_Panel;    // ��A�t���J�@�v���g���A�N���C�A���g���X�g�y�[�W
    [SerializeField] private GameObject ZAF_Bloemfontein_ClientList_Panel;    // ��A�t���J�@�u���[���t�H���e�C���N���C�A���g���X�g�y�[�W
    [SerializeField] private GameObject ZAF_CapeTown_ClientList_Panel;    // ��A�t���J�@�P�[�v�^�E���N���C�A���g���X�g�y�[�W

    [SerializeField] private GameObject[] ZAF_Pretoria_ClientPage_Panel = new GameObject[3];    // ��A�t���J�@�v���g���A�N���C�A���g�y�[�W
    [SerializeField] private GameObject[] ZAF_Bloemfontein_ClientPage_Panel = new GameObject[2];    // ��A�t���J�@�u���[���t�H���e�C���N���C�A���g�y�[�W
    [SerializeField] private GameObject[] ZAF_CapeTown_ClientPage_Panel = new GameObject[3];    // ��A�t���J�@�P�[�v�^�E���N���C�A���g�y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (ZAF_Pretoria_ClientList_Panel.activeInHierarchy == true ||
            ZAF_Bloemfontein_ClientList_Panel.activeInHierarchy == true ||
            ZAF_CapeTown_ClientList_Panel.activeInHierarchy == true)
            ZAF_ClientListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        for (int i = 0; i < 3; i++)
        {
            if (ZAF_Pretoria_ClientPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_Pretoria_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                ZAF_Pretoria_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 2; i++)
        {
            if (ZAF_Bloemfontein_ClientPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_Bloemfontein_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                ZAF_Bloemfontein_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (ZAF_CapeTown_ClientPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_CapeTown_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                ZAF_CapeTown_ClientList_Panel.SetActive(true);
            }
        }

        // 
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void ZAF_ClientListPage_AreaPage_ChangeActive()
    {
        ZAF_Pretoria_ClientList_Panel.SetActive(false);
        ZAF_Bloemfontein_ClientList_Panel.SetActive(false);
        ZAF_CapeTown_ClientList_Panel.SetActive(false);
        ZAF_AreaPage_Client_Panel.SetActive(true);
    }

}
