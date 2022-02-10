using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Cancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject ZAF_AreaPage_Manufacturer_Panel;   // ��A�t���J�n�掸�Ǝ҃y�[�W

    [SerializeField] private GameObject ZAF_Pretoria_ManuList_Panel;    // ��A�t���J�@�v���g���A���Y�҃��X�g�y�[�W
    [SerializeField] private GameObject ZAF_Bloemfontein_ManuList_Panel;    // ��A�t���J�@�u���[���t�H���e�C�����Y�҃��X�g�y�[�W
    [SerializeField] private GameObject ZAF_CapeTown_ManuList_Panel;    // ��A�t���J�@�P�[�v�^�E�����Y�҃��X�g�y�[�W

    [SerializeField] private GameObject[] ZAF_Pretoria_ManuPage_Panel = new GameObject[3];    // ��A�t���J�@�v���g���A���Y�҃y�[�W
    [SerializeField] private GameObject[] ZAF_Bloemfontein_ManuPage_Panel = new GameObject[4];    // ��A�t���J�@�u���[���t�H���e�C�����Y�҃y�[�W
    [SerializeField] private GameObject[] ZAF_CapeTown_ManuPage_Panel = new GameObject[5];    // ��A�t���J�@�P�[�v�^�E�����Y�҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (ZAF_Pretoria_ManuList_Panel.activeInHierarchy == true ||
            ZAF_Bloemfontein_ManuList_Panel.activeInHierarchy == true ||
            ZAF_CapeTown_ManuList_Panel.activeInHierarchy == true)
            ZAF_ManuListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        for (int i = 0; i < 3; i++)
        {
            if (ZAF_Pretoria_ManuPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_Pretoria_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                ZAF_Pretoria_ManuList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (ZAF_Bloemfontein_ManuPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_Bloemfontein_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                ZAF_Bloemfontein_ManuList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (ZAF_CapeTown_ManuPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_CapeTown_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                ZAF_CapeTown_ManuList_Panel.SetActive(true);
            }
        }

        // 
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void ZAF_ManuListPage_AreaPage_ChangeActive()
    {
        ZAF_Pretoria_ManuList_Panel.SetActive(false);
        ZAF_Bloemfontein_ManuList_Panel.SetActive(false);
        ZAF_CapeTown_ManuList_Panel.SetActive(false);
        // Manufacturer_Panel.SetActive(true);
        ZAF_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // �e�n�搶�Y�҃y�[�W����e�n�搶�Y�҃��X�g�y�[�W�ֈړ�
    void ZAF_ManufacturerPage_ManuList_ChangeActive()
    {
        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        if (ZAF_Pretoria_ManuPage_Panel[0].activeInHierarchy == true ||
           ZAF_Pretoria_ManuPage_Panel[1].activeInHierarchy == true)
        {
            ZAF_Pretoria_ManuPage_Panel[0].SetActive(false);
            ZAF_Pretoria_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            ZAF_Pretoria_ManuList_Panel.SetActive(true);
        }
        if (ZAF_Bloemfontein_ManuPage_Panel[0].activeInHierarchy == true ||
            ZAF_Bloemfontein_ManuPage_Panel[1].activeInHierarchy == true)
        {
            ZAF_Bloemfontein_ManuPage_Panel[0].SetActive(false);
            ZAF_Bloemfontein_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            ZAF_Bloemfontein_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (ZAF_CapeTown_ManuPage_Panel[i].activeInHierarchy == true)
            {
                ZAF_CapeTown_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                ZAF_CapeTown_ManuList_Panel.SetActive(true);
            }
        }
    }
}
