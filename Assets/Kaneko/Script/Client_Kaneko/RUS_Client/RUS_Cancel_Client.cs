using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RUS_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject RUS_AreaPage_Client_Panel;      // ���V�A�n��N���C�A���g�y�[�W

    [SerializeField] private GameObject RUS_Moscow_ClientList_Panel;    // ���V�A�@���X�N���N���C�A���g���X�g�y�[�W
    [SerializeField] private GameObject RUS_Ufa_ClientList_Panel;       // ���V�A�@�E�t�@�@�N���C�A���g���X�g�y�[�W

    [SerializeField] private GameObject[] RUS_Moscow_ClientPage_Panel = new GameObject[4];    // ���V�A���X�N���N���C�A���g�y�[�W
    [SerializeField] private GameObject[] RUS_Ufa_ClientPage_Panel = new GameObject[3];       // ���V�A�E�t�@�@�N���C�A���g�y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (RUS_Moscow_ClientList_Panel.activeInHierarchy == true ||
            RUS_Ufa_ClientList_Panel.activeInHierarchy == true)
            RUS_ClientListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        for (int i = 0; i < 4; i++)
        {
            if (RUS_Moscow_ClientPage_Panel[i].activeInHierarchy == true)
            {
                RUS_Moscow_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                RUS_Moscow_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (RUS_Ufa_ClientPage_Panel[i].activeInHierarchy == true)
            {
                RUS_Ufa_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                RUS_Ufa_ClientList_Panel.SetActive(true);
            }
        }
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void RUS_ClientListPage_AreaPage_ChangeActive()
    {
        RUS_Moscow_ClientList_Panel.SetActive(false);
        RUS_Ufa_ClientList_Panel.SetActive(false);
        RUS_AreaPage_Client_Panel.SetActive(true);
    }

}
