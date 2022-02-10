using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Cancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject RUS_AreaPage_Manufacturer_Panel;   // ���V�A�n�掸�Ǝ҃y�[�W

    [SerializeField] private GameObject RUS_Moscow_ManuList_Panel;    // ���V�A�@���X�N�����Y�҃��X�g�y�[�W
    [SerializeField] private GameObject RUS_Ufa_ManuList_Panel;    // ���V�A�@�E�t�@���Y�҃��X�g�y�[�W

    [SerializeField] private GameObject[] RUS_Moscow_ManuPage_Panel = new GameObject[2];    // ���V�A�@���X�N�����Y�҃y�[�W
    [SerializeField] private GameObject[] RUS_Ufa_ManuPage_Panel = new GameObject[4];    // ���V�A�@�E�t�@���Y�҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (RUS_Moscow_ManuList_Panel.activeInHierarchy == true ||
            RUS_Ufa_ManuList_Panel.activeInHierarchy == true)
            USA_ManuListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        if (RUS_Moscow_ManuPage_Panel[0].activeInHierarchy == true ||
           RUS_Moscow_ManuPage_Panel[1].activeInHierarchy == true)
        {
            RUS_Moscow_ManuPage_Panel[0].SetActive(false);
            RUS_Moscow_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            RUS_Moscow_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 4; i++)
        {
            if (RUS_Ufa_ManuPage_Panel[i].activeInHierarchy == true)
            {
                RUS_Ufa_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                RUS_Ufa_ManuList_Panel.SetActive(true);
            }
        }

        // 
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void USA_ManuListPage_AreaPage_ChangeActive()
    {
        RUS_Moscow_ManuList_Panel.SetActive(false);
        RUS_Ufa_ManuList_Panel.SetActive(false);
        // Manufacturer_Panel.SetActive(true);
        RUS_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // �e�n�搶�Y�҃y�[�W����e�n�搶�Y�҃��X�g�y�[�W�ֈړ�
    void USA_ManufacturerPage_ManuList_ChangeActive()
    {
        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        if (RUS_Moscow_ManuPage_Panel[0].activeInHierarchy == true ||
           RUS_Moscow_ManuPage_Panel[1].activeInHierarchy == true)
        {
            RUS_Moscow_ManuPage_Panel[0].SetActive(false);
            RUS_Moscow_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            RUS_Moscow_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 4; i++)
        {
            if (RUS_Ufa_ManuPage_Panel[i].activeInHierarchy == true)
            {
                RUS_Ufa_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                RUS_Ufa_ManuList_Panel.SetActive(true);
            }
        }
    }
}
