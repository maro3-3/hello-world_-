using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Cancel_Unemployed : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Unemployed_Panel;

    [SerializeField] private GameObject CHN_AreaPage_Unemployed_Panel;   // �����n�掸�Ǝ҃y�[�W

    [SerializeField] private GameObject CHN_Beijing_Unemployed_Panel;    // �����k�����Ǝ҃y�[�W
    [SerializeField] private GameObject CHN_Shanghai_Unemployed_Panel;   // ������C���Ǝ҃y�[�W
    [SerializeField] private GameObject CHN_Sichuan_Unemployed_Panel;    // �����l�쎸�Ǝ҃y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�掸�Ǝ҃y�[�W�Ł~�{�^����������n���\��
        if (CHN_Beijing_Unemployed_Panel.activeInHierarchy  == true ||
            CHN_Shanghai_Unemployed_Panel.activeInHierarchy == true ||
            CHN_Sichuan_Unemployed_Panel.activeInHierarchy  == true)
                CHN_UnemployedPage_AreaPage_ChangeActive();

        // 
    }

    // �e�n�掸�Ǝ҃y�[�W����n��y�[�W�ֈړ�
    void CHN_UnemployedPage_AreaPage_ChangeActive()
    {
        CHN_Beijing_Unemployed_Panel.SetActive(false);
        CHN_Shanghai_Unemployed_Panel.SetActive(false);
        CHN_Sichuan_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        CHN_AreaPage_Unemployed_Panel.SetActive(true);
    }
}
