using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Chancel_Manufacturer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Manufacturer_Panel;

    [SerializeField] private GameObject CHN_AreaPage_Manufacturer_Panel;   // �����n�掸�Ǝ҃y�[�W

    [SerializeField] private GameObject CHN_Beijing_ManuList_Panel;    // �����k�����Y�҃��X�g�y�[�W
    [SerializeField] private GameObject CHN_Shanghai_ManuList_Panel;   // ������C���Y�҃��X�g�y�[�W
    [SerializeField] private GameObject CHN_Sichuan_ManuList_Panel;    // �����l�쐶�Y�҃��X�g�y�[�W

    [SerializeField] private GameObject[] CHN_Beijing_ManuPage_Panel = new GameObject[2];    // �����k�����Y�҃y�[�W
    [SerializeField] private GameObject[] CHN_Shanghai_ManuPage_Panel = new GameObject[2];   // ������C���Y�҃y�[�W
    [SerializeField] private GameObject[] CHN_Sichuan_ManuPage_Panel = new GameObject[5];    // �����l�쐶�Y�҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (CHN_Beijing_ManuList_Panel.activeInHierarchy == true ||
            CHN_Shanghai_ManuList_Panel.activeInHierarchy == true ||
            CHN_Sichuan_ManuList_Panel.activeInHierarchy == true)
            CHN_ManuListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        if (CHN_Beijing_ManuPage_Panel[0].activeInHierarchy == true ||
           CHN_Beijing_ManuPage_Panel[1].activeInHierarchy == true)
        {
            CHN_Beijing_ManuPage_Panel[0].SetActive(false);
            CHN_Beijing_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            CHN_Beijing_ManuList_Panel.SetActive(true);
        }
        if (CHN_Shanghai_ManuPage_Panel[0].activeInHierarchy == true ||
            CHN_Shanghai_ManuPage_Panel[1].activeInHierarchy == true)
        {
            CHN_Shanghai_ManuPage_Panel[0].SetActive(false);
            CHN_Shanghai_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            CHN_Shanghai_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (CHN_Sichuan_ManuPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Sichuan_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                CHN_Sichuan_ManuList_Panel.SetActive(true);
            }
        }

        // 
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void CHN_ManuListPage_AreaPage_ChangeActive()
    {
        CHN_Beijing_ManuList_Panel.SetActive(false);
        CHN_Shanghai_ManuList_Panel.SetActive(false);
        CHN_Sichuan_ManuList_Panel.SetActive(false);
       // Manufacturer_Panel.SetActive(true);
        CHN_AreaPage_Manufacturer_Panel.SetActive(true);
    }

    // �e�n�搶�Y�҃y�[�W����e�n�搶�Y�҃��X�g�y�[�W�ֈړ�
    void CHN_ManufacturerPage_ManuList_ChangeActive()
    {
        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        if (CHN_Beijing_ManuPage_Panel[0].activeInHierarchy == true ||
           CHN_Beijing_ManuPage_Panel[1].activeInHierarchy == true)
        {
            CHN_Beijing_ManuPage_Panel[0].SetActive(false);
            CHN_Beijing_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            CHN_Beijing_ManuList_Panel.SetActive(true);
        }
        if (CHN_Shanghai_ManuPage_Panel[0].activeInHierarchy == true ||
            CHN_Shanghai_ManuPage_Panel[1].activeInHierarchy == true)
        {
            CHN_Shanghai_ManuPage_Panel[0].SetActive(false);
            CHN_Shanghai_ManuPage_Panel[1].SetActive(false);
            BG_Panel.SetActive(true);
            Manufacturer_Panel.SetActive(true);
            CHN_Shanghai_ManuList_Panel.SetActive(true);
        }
        for (int i = 0; i < 5; i++)
        {
            if (CHN_Sichuan_ManuPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Sichuan_ManuPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Manufacturer_Panel.SetActive(true);
                CHN_Sichuan_ManuList_Panel.SetActive(true);
            }
        }
    }
}
