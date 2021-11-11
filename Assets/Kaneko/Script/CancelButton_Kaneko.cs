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
    [SerializeField] private GameObject USA_ClientMenu_Panel;
    [SerializeField] private GameObject ZAF_ManufacturerMenu_Panel;
    [SerializeField] private GameObject ZAF_UnemployedMenu_Panel;
    [SerializeField] private GameObject USA_Client_A_Panel;
    [SerializeField] private GameObject ZAF_Jozi_ManufacturerA_Panel;
    [SerializeField] private GameObject ZAF_Jozi_UnemployedA_Panel;
    [SerializeField] private Vector3 ClientStartPos;
    [SerializeField] private Vector3 ManufacturerStartPos;


    public void OnPointerClick(PointerEventData eventData)
    {
        // �e���j���[����X�^�[�g��ʂɖ߂�
        if (USA_ClientMenu_Panel.activeInHierarchy == true ||
            ZAF_ManufacturerMenu_Panel.activeInHierarchy == true ||
            ZAF_UnemployedMenu_Panel.activeInHierarchy == true)
                StartPage_ChangeActive();

        // �e���j���[��ʂɖ߂�
        if (ZAF_Jozi_UnemployedA_Panel.activeInHierarchy == true)
            ZAF_UnemployedMenuPage_ChangeActive();
        if (ZAF_Jozi_ManufacturerA_Panel.activeInHierarchy == true)
            ZAF_ManufacturerMenuPage_ChangeActive();
        if (USA_Client_A_Panel.activeInHierarchy == true)
            USA_ClientMenuPage_ChangeActive();

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // ��ԍŏ��̉�ʂɖ߂�
    private void StartPage_ChangeActive()
    {
        // �N���C�A���g�Ɛ��Y�҂����̏ꏊ�ɖ߂�
        GameObject Ccild = Client_Panel.transform.GetChild(0).gameObject;
        Ccild.transform.position = ClientStartPos;
        GameObject Mcild = Manufacturer_Panel.transform.GetChild(0).gameObject;
        Mcild.transform.position = ManufacturerStartPos;

        if(USA_ClientMenu_Panel.activeInHierarchy == true)
            USA_ClientMenu_Panel.SetActive(false);
        if(ZAF_ManufacturerMenu_Panel.activeInHierarchy == true)
            ZAF_ManufacturerMenu_Panel.SetActive(false);
        if(ZAF_UnemployedMenu_Panel.activeInHierarchy == true)
            ZAF_UnemployedMenu_Panel.SetActive(false);
        
        // BG�E�N���C�A���g�E���Y�ҁE���Ǝ҂�\��
        BG_Panel.SetActive(true);
        Client_Panel.SetActive(true);
        Manufacturer_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
    }

    // ��A�t���J���Ǝ҃��j���[�ɖ߂�
    private void ZAF_UnemployedMenuPage_ChangeActive()
    {
        ZAF_Jozi_UnemployedA_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Unemployed_Panel.SetActive(true);
        ZAF_UnemployedMenu_Panel.SetActive(true);

    }
    // ��A�t���J���Y�҃��j���[�ɖ߂�
    private void ZAF_ManufacturerMenuPage_ChangeActive()
    {
        ZAF_Jozi_ManufacturerA_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Manufacturer_Panel.SetActive(true);
        ZAF_ManufacturerMenu_Panel.SetActive(true);

    }
    // �A�����J�N���C�A���g���j���[�ɖ߂�
    private void USA_ClientMenuPage_ChangeActive()
    {
        USA_Client_A_Panel.SetActive(false);
        BG_Panel.SetActive(true);
        Client_Panel.SetActive(true);
        USA_ClientMenu_Panel.SetActive(true);

    }
}
