using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;

    [SerializeField] private GameObject AUS_AreaPage_Unemployed_Panel;     // �I�[�X�g�����A�n�掸�Ǝ҃y�[�W
                                                                            
    [SerializeField] private GameObject AUS_Canberra_Unemployed_Panel;     // �I�[�X�g�����A�@�L�����x�����Ǝ҃y�[�W
    [SerializeField] private GameObject AUS_Perth_Unemployed_Panel;        // �I�[�X�g�����A�@�p�[�X���Ǝ҃y�[�W
    [SerializeField] private GameObject AUS_Melbourne_Unemployed_Panel;    // �I�[�X�g�����A�@�����{�������Ǝ҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�掸�Ǝ҃y�[�W�Ł~�{�^����������n���\��
        if (AUS_Canberra_Unemployed_Panel.activeInHierarchy == true ||
            AUS_Perth_Unemployed_Panel.activeInHierarchy == true ||
            AUS_Melbourne_Unemployed_Panel.activeInHierarchy == true)
            AUS_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // �e�n�掸�Ǝ҃y�[�W����n��y�[�W�ֈړ�
    void AUS_UnemployedPage_AreaPage_ChangeActive()
    {
        AUS_Canberra_Unemployed_Panel.SetActive(false);
        AUS_Perth_Unemployed_Panel.SetActive(false);
        AUS_Melbourne_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        AUS_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
