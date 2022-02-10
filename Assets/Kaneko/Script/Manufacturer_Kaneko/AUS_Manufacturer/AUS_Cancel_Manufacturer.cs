using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Cancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject AUS_AreaPage_Manufacturer_Panel;   // �A�����J�n�掸�Ǝ҃y�[�W

    [SerializeField] private GameObject AUS_Canberra_ManuList_Panel;    // �A�����J�@�j���[���[�N���Y�҃��X�g�y�[�W
    [SerializeField] private GameObject AUS_Perth_ManuList_Panel;    // �A�����J�@�Z���g���C�X���Y�҃��X�g�y�[�W
    [SerializeField] private GameObject AUS_Melbourne_ManuList_Panel;    // �A�����J�@�A�g�����^���Y�҃��X�g�y�[�W

    [SerializeField] private GameObject[] AUS_Canberra_ManuPage_Panel = new GameObject[4];    // �A�����J�@�j���[���[�N���Y�҃y�[�W
    [SerializeField] private GameObject[] AUS_Perth_ManuPage_Panel = new GameObject[3];    // �A�����J�@�Z���g���C�X���Y�҃y�[�W
    [SerializeField] private GameObject[] AUS_Melbourne_ManuPage_Panel = new GameObject[3];    // �A�����J�@�A�g�����^���Y�҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (AUS_Canberra_ManuList_Panel.activeInHierarchy == true ||
            AUS_Perth_ManuList_Panel.activeInHierarchy == true ||
            AUS_Melbourne_ManuList_Panel.activeInHierarchy == true)
            USA_ManuListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        for (int i = 0; i < 4; i++)
        {
            if (AUS_Canberra_ManuPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Canberra_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                AUS_Canberra_ManuList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Perth_ManuPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Perth_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                AUS_Perth_ManuList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Melbourne_ManuPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Melbourne_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                AUS_Melbourne_ManuList_Panel.SetActive(true);
            }
        }
        // 
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void USA_ManuListPage_AreaPage_ChangeActive()
    {
        AUS_Canberra_ManuList_Panel.SetActive(false);
        AUS_Perth_ManuList_Panel.SetActive(false);
        AUS_Melbourne_ManuList_Panel.SetActive(false);
        // Manufacturer_Panel.SetActive(true);
        AUS_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // �e�n�搶�Y�҃y�[�W����e�n�搶�Y�҃��X�g�y�[�W�ֈړ�
    void USA_ManufacturerPage_ManuList_ChangeActive()
    {
        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        if (AUS_Canberra_ManuPage_Panel[0].activeInHierarchy == true ||
           AUS_Canberra_ManuPage_Panel[1].activeInHierarchy == true)
        {
            AUS_Canberra_ManuPage_Panel[0].SetActive(false);
            AUS_Canberra_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            AUS_Canberra_ManuList_Panel.SetActive(true);
        }
        if (AUS_Perth_ManuPage_Panel[0].activeInHierarchy == true ||
            AUS_Perth_ManuPage_Panel[1].activeInHierarchy == true)
        {
            AUS_Perth_ManuPage_Panel[0].SetActive(false);
            AUS_Perth_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            AUS_Perth_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (AUS_Melbourne_ManuPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Melbourne_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                AUS_Melbourne_ManuList_Panel.SetActive(true);
            }
        }
    }
}
