using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class USA_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject USA_AreaPage_Client_Panel;   // �A�����J�n��N���C�A���g�y�[�W

    [SerializeField] private GameObject USA_NewYork_ClientList_Panel;    // �A�����J�@�j���[���[�N�N���C�A���g���X�g�y�[�W
    [SerializeField] private GameObject USA_StLouis_ClientList_Panel;    // �A�����J�@�Z���g���C�X�N���C�A���g���X�g�y�[�W
    [SerializeField] private GameObject USA_Atlanta_ClientList_Panel;    // �A�����J�@�A�g�����^�N���C�A���g���X�g�y�[�W

    [SerializeField] private GameObject[] USA_NewYork_ClientPage_Panel = new GameObject[2];    // �A�����J�@�j���[���[�N�N���C�A���g�y�[�W
    [SerializeField] private GameObject[] USA_StLouis_ClientPage_Panel = new GameObject[3];    // �A�����J�@�Z���g���C�X�N���C�A���g�y�[�W
    [SerializeField] private GameObject[] USA_Atlanta_ClientPage_Panel = new GameObject[2];    // �A�����J�@�A�g�����^�N���C�A���g�y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (USA_NewYork_ClientList_Panel.activeInHierarchy == true ||
            USA_StLouis_ClientList_Panel.activeInHierarchy == true ||
            USA_Atlanta_ClientList_Panel.activeInHierarchy == true)
            USA_ClientListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        for (int i = 0; i < 3; i++)
        {
            if (USA_NewYork_ClientPage_Panel[i].activeInHierarchy == true)
            {
                USA_NewYork_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                USA_NewYork_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 2; i++)
        {
            if (USA_StLouis_ClientPage_Panel[i].activeInHierarchy == true)
            {
                USA_StLouis_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                USA_StLouis_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (USA_Atlanta_ClientPage_Panel[i].activeInHierarchy == true)
            {
                USA_Atlanta_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                USA_Atlanta_ClientList_Panel.SetActive(true);
            }
        }
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void USA_ClientListPage_AreaPage_ChangeActive()
    {
        USA_NewYork_ClientList_Panel.SetActive(false);
        USA_StLouis_ClientList_Panel.SetActive(false);
        USA_Atlanta_ClientList_Panel.SetActive(false);
        USA_AreaPage_Client_Panel.SetActive(true);
    }

}
