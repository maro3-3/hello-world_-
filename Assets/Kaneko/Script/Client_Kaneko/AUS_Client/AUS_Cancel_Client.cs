using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AUS_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject AUS_AreaPage_Client_Panel;   // ���[���Ƃ�肠�n��N���C�A���g�y�[�W

    [SerializeField] private GameObject AUS_Canberra_ClientList_Panel;     // �I�[�X�g�����A�@�L�����x���N���C�A���g���X�g�y�[�W
    [SerializeField] private GameObject AUS_Perth_ClientList_Panel;        // �I�[�X�g�����A�@�p�[�X�N���C�A���g���X�g�y�[�W
    [SerializeField] private GameObject AUS_Melbourne_ClientList_Panel;    // �I�[�X�g�����A�@�����{�����N���C�A���g���X�g�y�[�W

    [SerializeField] private GameObject[] AUS_Canberra_ClientPage_Panel = new GameObject[3];    // �I�[�X�g�����A�@�L�����x���N���C�A���g�y�[�W
    [SerializeField] private GameObject[] AUS_Perth_ClientPage_Panel = new GameObject[3];       // �I�[�X�g�����A�@�p�[�X�N���C�A���g�y�[�W
    [SerializeField] private GameObject[] AUS_Melbourne_ClientPage_Panel = new GameObject[3];   // �I�[�X�g�����A�@�����{�����N���C�A���g�y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (AUS_Canberra_ClientList_Panel.activeInHierarchy == true ||
            AUS_Perth_ClientList_Panel.activeInHierarchy == true ||
            AUS_Melbourne_ClientList_Panel.activeInHierarchy == true)
            AUS_ClientListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Canberra_ClientPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Canberra_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                AUS_Canberra_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Perth_ClientPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Perth_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                AUS_Perth_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (AUS_Melbourne_ClientPage_Panel[i].activeInHierarchy == true)
            {
                AUS_Melbourne_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                AUS_Melbourne_ClientList_Panel.SetActive(true);
            }
        }
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void AUS_ClientListPage_AreaPage_ChangeActive()
    {
        AUS_Canberra_ClientList_Panel.SetActive(false);
        AUS_Perth_ClientList_Panel.SetActive(false);
        AUS_Melbourne_ClientList_Panel.SetActive(false);
        AUS_AreaPage_Client_Panel.SetActive(true);
    }

}
