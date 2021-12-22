using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;

    [SerializeField] private GameObject RUS_AreaPage_Unemployed_Panel;  // ���V�A�n�掸�Ǝ҃y�[�W

    [SerializeField] private GameObject RUS_Moscow_Unemployed_Panel;    // ���V�A�@���X�N�����Ǝ҃y�[�W
    [SerializeField] private GameObject RUS_Ufa_Unemployed_Panel;       // ���V�A�@�E�t�@���Ǝ҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�掸�Ǝ҃y�[�W�Ł~�{�^����������n���\��
        if (RUS_Moscow_Unemployed_Panel.activeInHierarchy == true ||
            RUS_Ufa_Unemployed_Panel.activeInHierarchy == true)
            RUS_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // �e�n�掸�Ǝ҃y�[�W����n��y�[�W�ֈړ�
    void RUS_UnemployedPage_AreaPage_ChangeActive()
    {
        RUS_Moscow_Unemployed_Panel.SetActive(false);
        RUS_Ufa_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        RUS_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
