using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ZAF_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;
     
    [SerializeField] private GameObject ZAF_AreaPage_Unemployed_Panel;        // ��A�t���J�n�掸�Ǝ҃y�[�W
                                                                              
    [SerializeField] private GameObject ZAF_Pretoria_Unemployed_Panel;        // ��A�t���J�@�v���g���A���Ǝ҃y�[�W
    [SerializeField] private GameObject ZAF_Bloemfontein_Unemployed_Panel;    // ��A�t���J�@�u���[���t�H���e�C�����Ǝ҃y�[�W
    [SerializeField] private GameObject ZAF_CapeTown_Unemployed_Panel;        // ��A�t���J�@�P�[�v�^�E�����Ǝ҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�掸�Ǝ҃y�[�W�Ł~�{�^����������n���\��
        if (ZAF_Pretoria_Unemployed_Panel.activeInHierarchy == true ||
            ZAF_Bloemfontein_Unemployed_Panel.activeInHierarchy == true ||
            ZAF_CapeTown_Unemployed_Panel.activeInHierarchy == true)
            ZAF_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // �e�n�掸�Ǝ҃y�[�W����n��y�[�W�ֈړ�
    void ZAF_UnemployedPage_AreaPage_ChangeActive()
    {
        ZAF_Pretoria_Unemployed_Panel.SetActive(false);
        ZAF_Bloemfontein_Unemployed_Panel.SetActive(false);
        ZAF_CapeTown_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        ZAF_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
