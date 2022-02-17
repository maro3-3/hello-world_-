using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CHN_Cancel_Client : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;

    [SerializeField] private GameObject Client_Panel;

    [SerializeField] private GameObject CHN_AreaPage_Client_Panel;   // �����n��N���C�A���g�y�[�W

    [SerializeField] private GameObject CHN_Beijing_ClientList_Panel;     // �����@�k���N���C�A���g���X�g�y�[�W
    [SerializeField] private GameObject CHN_Shanghai_ClientList_Panel;    // �����@��C�N���C�A���g���X�g�y�[�W
    [SerializeField] private GameObject CHN_Sichuan_ClientList_Panel;     // �����@�l��N���C�A���g���X�g�y�[�W

    [SerializeField] private GameObject[] CHN_Beijing_ClientPage_Panel = new GameObject[2];     // �����@�k���N���C�A���g�y�[�W
    [SerializeField] private GameObject[] CHN_Shanghai_ClientPage_Panel = new GameObject[3];    // �����@��C�N���C�A���g�y�[�W
    [SerializeField] private GameObject[] CHN_Sichuan_ClientPage_Panel = new GameObject[4];     // �����@�l��N���C�A���g�y�[�W

    public void OnPointerClick(PointerEventData eventData)
    {
        // �e�n�搶�Y�҃��X�g�Ł~�{�^����������n���\��
        if (CHN_Beijing_ClientList_Panel.activeInHierarchy == true ||
            CHN_Shanghai_ClientList_Panel.activeInHierarchy == true ||
            CHN_Sichuan_ClientList_Panel.activeInHierarchy == true)
            CHN_ClientListPage_AreaPage_ChangeActive();

        // �ǂ̒n��̐��Y�҂��ŕ\�����鐶�Y�҃��X�g��������
        for (int i = 0; i < 2; i++)
        {
            if (CHN_Beijing_ClientPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Beijing_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                CHN_Beijing_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (CHN_Shanghai_ClientPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Shanghai_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                CHN_Shanghai_ClientList_Panel.SetActive(true);
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (CHN_Sichuan_ClientPage_Panel[i].activeInHierarchy == true)
            {
                CHN_Sichuan_ClientPage_Panel[i].SetActive(false);
                BG_Panel.SetActive(true);
                Client_Panel.SetActive(true);
                CHN_Sichuan_ClientList_Panel.SetActive(true);
            }
        }
    }

    // �e�n�搶�Y�҃��X�g�y�[�W����n��y�[�W�ֈړ�
    void CHN_ClientListPage_AreaPage_ChangeActive()
    {
        CHN_Beijing_ClientList_Panel.SetActive(false);
        CHN_Shanghai_ClientList_Panel.SetActive(false);
        CHN_Sichuan_ClientList_Panel.SetActive(false);
        CHN_AreaPage_Client_Panel.SetActive(true);
    }

}
