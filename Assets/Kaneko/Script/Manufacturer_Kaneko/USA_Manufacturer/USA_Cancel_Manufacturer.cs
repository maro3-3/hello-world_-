using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_Cancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject USA_AreaPage_Manufacturer_Panel;   // �A�����J�n�掸�Ǝ҃y�[�W

    [SerializeField] private GameObject USA_NewYork_ManuList_Panel;    // �A�����J�@�j���[���[�N���Y�҃��X�g�y�[�W
    [SerializeField] private GameObject USA_StLouis_ManuList_Panel;    // �A�����J�@�Z���g���C�X���Y�҃��X�g�y�[�W
    [SerializeField] private GameObject USA_Atlanta_ManuList_Panel;    // �A�����J�@�A�g�����^���Y�҃��X�g�y�[�W

    [SerializeField] private GameObject[] USA_NewYork_ManuPage_Panel = new GameObject[2];    // �A�����J�@�j���[���[�N���Y�҃y�[�W
    [SerializeField] private GameObject[] USA_StLouis_ManuPage_Panel = new GameObject[3];    // �A�����J�@�Z���g���C�X���Y�҃y�[�W
    [SerializeField] private GameObject[] USA_Atlanta_ManuPage_Panel = new GameObject[4];    // �A�����J�@�A�g�����^���Y�҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (USA_NewYork_ManuList_Panel.activeInHierarchy == true ||
            USA_StLouis_ManuList_Panel.activeInHierarchy == true ||
            USA_Atlanta_ManuList_Panel.activeInHierarchy == true)
            USA_ManuListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        if (USA_NewYork_ManuPage_Panel[0].activeInHierarchy == true ||
           USA_NewYork_ManuPage_Panel[1].activeInHierarchy == true)
        {
            USA_NewYork_ManuPage_Panel[0].SetActive(false);
            USA_NewYork_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            USA_NewYork_ManuList_Panel.SetActive(true);
        }
        if (USA_StLouis_ManuPage_Panel[0].activeInHierarchy == true ||
            USA_StLouis_ManuPage_Panel[1].activeInHierarchy == true ||
            USA_StLouis_ManuPage_Panel[2].activeInHierarchy == true)
        {
            USA_StLouis_ManuPage_Panel[0].SetActive(false);
            USA_StLouis_ManuPage_Panel[1].SetActive(false);
            USA_StLouis_ManuPage_Panel[2].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            USA_StLouis_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 4; i++)
        {
            if (USA_Atlanta_ManuPage_Panel[i].activeInHierarchy == true)
            {
                USA_Atlanta_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                USA_Atlanta_ManuList_Panel.SetActive(true);
            }
        }

        // 
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void USA_ManuListPage_AreaPage_ChangeActive()
    {
        USA_NewYork_ManuList_Panel.SetActive(false);
        USA_StLouis_ManuList_Panel.SetActive(false);
        USA_Atlanta_ManuList_Panel.SetActive(false);
        // Manufacturer_Panel.SetActive(true);
        USA_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // �e�n�搶�Y�҃y�[�W����e�n�搶�Y�҃��X�g�y�[�W�ֈړ�
    void USA_ManufacturerPage_ManuList_ChangeActive()
    {
        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        if (USA_NewYork_ManuPage_Panel[0].activeInHierarchy == true ||
           USA_NewYork_ManuPage_Panel[1].activeInHierarchy == true)
        {
            USA_NewYork_ManuPage_Panel[0].SetActive(false);
            USA_NewYork_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            USA_NewYork_ManuList_Panel.SetActive(true);
        }
        if (USA_StLouis_ManuPage_Panel[0].activeInHierarchy == true ||
            USA_StLouis_ManuPage_Panel[1].activeInHierarchy == true)
        {
            USA_StLouis_ManuPage_Panel[0].SetActive(false);
            USA_StLouis_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            USA_StLouis_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (USA_Atlanta_ManuPage_Panel[i].activeInHierarchy == true)
            {
                USA_Atlanta_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                USA_Atlanta_ManuList_Panel.SetActive(true);
            }
        }
    }
}
