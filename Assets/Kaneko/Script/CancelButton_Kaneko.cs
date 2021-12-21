using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CancelButton_Kaneko : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject BG_Panel;
    [SerializeField] private GameObject Client_Panel;
    [SerializeField] private GameObject Manufacturer_Panel;
    [SerializeField] private GameObject Unemployed_Panel;
    [SerializeField] private GameObject CHN_Beijing_ClientList_Panel;    // �����k���N���C�A���g�y�[�W
    [SerializeField] private GameObject CHN_Beijing_ManuList_Panel;      // �����k�����Y�҃y�[�W

    [SerializeField] private GameObject CHN_Aria_ClientList_Panel;       // �����n��N���C�A���g�y�[�W
    [SerializeField] private GameObject CHN_Aria_ManuList_Panel;         // �����n�搶�Y�҃y�[�W
    [SerializeField] private GameObject CHN_Aria_UnemployedMenu_Panel;         // �����n�搶�Y�҃y�[�W

    [SerializeField] private GameObject CHN_Beijing_ClientA_Panel;       // �����k���N���C�A���gA�y�[�W
    [SerializeField] private GameObject CHN_Beijing_ManuA_Panel;         // �����k�����Y��A�y�[�W
    [SerializeField] private GameObject CHN_Beijing_Unemployed_Panel;         // �����k�����Y��A�y�[�W

    [SerializeField] private Vector3 ClientStartPos;
    [SerializeField] private Vector3 ManufacturerStartPos;


    public void OnPointerClick(PointerEventData eventData)
    {
        // �e���j���[����X�^�[�g��ʂɖ߂�
        if (CHN_Aria_ClientList_Panel.activeInHierarchy == true ||
            CHN_Aria_ManuList_Panel.activeInHierarchy == true ||
            CHN_Aria_UnemployedMenu_Panel.activeInHierarchy == true)
                StartPage_ChangeActive();

        // �����n�惊�X�g�ɖ߂�
        if (CHN_Beijing_ClientList_Panel.activeInHierarchy == true)
            CHN_Aria_Client_ChangeActive();
        if (CHN_Beijing_ManuList_Panel.activeInHierarchy == true)
            CHN_Aria_Manu_ChangeActive();
        if (CHN_Beijing_Unemployed_Panel.activeInHierarchy == true)
            CHN_Aria_Unemployed_ChangeActive();

        // �����k�����X�g�ɖ߂�
        //if (CHN_Beijing_ClientA_Panel.activeInHierarchy == true)
        //    CHN_Beijing_UnemployedList_ChangeActive();
        if (CHN_Beijing_ManuA_Panel.activeInHierarchy == true)
            CHN_Beijing_ManuList_ChangeActive();
        if (CHN_Beijing_ClientA_Panel.activeInHierarchy == true)
            CHN_Beijing_ClientList_ChangeActive();



        // �����n�惊�X�g�ɖ߂�
    }

    // ��ԍŏ��̉�ʂɖ߂�
    private void StartPage_ChangeActive()
    {
        // �N���C�A���g�Ɛ��Y�҂����̏ꏊ�ɖ߂�
        GameObject Ccild = Client_Panel.transform.GetChild(0).gameObject;
        Ccild.transform.position = ClientStartPos;
        GameObject Mcild = Manufacturer_Panel.transform.GetChild(0).gameObject;
        Mcild.transform.position = ManufacturerStartPos;

        if (CHN_Aria_ClientList_Panel.activeInHierarchy == true)
            CHN_Aria_ClientList_Panel.SetActive(false);
        if(CHN_Aria_ManuList_Panel.activeInHierarchy == true)
            CHN_Aria_ManuList_Panel.SetActive(false);
        if(CHN_Aria_UnemployedMenu_Panel.activeInHierarchy == true)
            CHN_Aria_UnemployedMenu_Panel.SetActive(false);
        
        // BG�E�N���C�A���g�E���Y�ҁE���Ǝ҂�\��
        BG_Panel.SetActive(true);
        Client_Panel.SetActive(true);
        Manufacturer_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
    }

    // �����k�����Ǝ҃��X�g�ɖ߂�
    //private void CHN_Beijing_UnemployedList_ChangeActive()
    //{
    //    CHN_Beijing_UnemployedA_Panel.SetActive(false);
    //    BG_Panel.SetActive(true);
    //    CHN_Beijing_UnemployedMenu_Panel.SetActive(true);
    //    CHN_Beijing_UnemployedA_Panel.SetActive(true);

    //}

    // �����n�惊�X�g�ɖ߂�
    private void CHN_Aria_Unemployed_ChangeActive()
    {
        CHN_Beijing_Unemployed_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        CHN_Aria_UnemployedMenu_Panel.SetActive(true);

    }
    // �����k�����Y�҃��X�g�ɖ߂�
    private void CHN_Beijing_ManuList_ChangeActive()
    {
        CHN_Beijing_ManuA_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Manufacturer_Panel.SetActive(true);
        CHN_Beijing_ManuList_Panel.SetActive(true);

    }
    // �����k���N���C�A���g���X�g�ɖ߂�
    private void CHN_Beijing_ClientList_ChangeActive()
    {
        CHN_Beijing_ClientA_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Client_Panel.SetActive(true);
        CHN_Beijing_ClientList_Panel.SetActive(true);

    }

    // �����n�搶�Y�҃��X�g�ɖ߂�
    private void CHN_Aria_Manu_ChangeActive()
    {
        CHN_Beijing_ManuList_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        CHN_Aria_ManuList_Panel.SetActive(true);

    }
    // �����n��N���C�A���g���X�g�ɖ߂�
    private void CHN_Aria_Client_ChangeActive()
    {
        CHN_Beijing_ClientList_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        CHN_Aria_ClientList_Panel.SetActive(true);

    }
}
;    

