using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;

    [SerializeField] private GameObject USA_AreaPage_Unemployed_Panel;   // �A�����J�n�掸�Ǝ҃y�[�W
                                                                          
    [SerializeField] private GameObject USA_NewYork_Unemployed_Panel;    // �A�����J�@�j���[���[�N���Ǝ҃y�[�W
    [SerializeField] private GameObject USA_StLouis_Unemployed_Panel;    // �A�����J�@�Z���g���C�X���Ǝ҃y�[�W
    [SerializeField] private GameObject USA_Atlanta_Unemployed_Panel;    // �A�����J�@�A�g�����^���Ǝ҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�掸�Ǝ҃y�[�W�Ł~�{�^����������n���\��
        if (USA_NewYork_Unemployed_Panel.activeInHierarchy == true ||
            USA_StLouis_Unemployed_Panel.activeInHierarchy == true ||
            USA_Atlanta_Unemployed_Panel.activeInHierarchy == true)
            USA_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // �e�n�掸�Ǝ҃y�[�W����n��y�[�W�ֈړ�
    void USA_UnemployedPage_AreaPage_ChangeActive()
    {
        USA_NewYork_Unemployed_Panel.SetActive(false);
        USA_StLouis_Unemployed_Panel.SetActive(false);
        USA_Atlanta_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        USA_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
