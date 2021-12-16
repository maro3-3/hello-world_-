using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ���Y�҃��X�g���N���C�A���g���X�g�ŏ����ɂ��Ă͂܂���̂��n�C���C�g������
public class ProductionHighLight : MonoBehaviour
{
    [SerializeField] private GameObject RedHighLight;

    // Start is called before the first frame update
    void Start()
    {
        RedHighLight = this.transform.Find("RedHighLight").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnHightLight() // ���Y���Ɨv�����������ł���΃n�C���C�g��\��
    {
        GameObject Minimana = GameObject.Find("MinigameManager");
        MinigameManager Mini_scr = Minimana.GetComponent<MinigameManager>();

        //Mini_scr.intHighLight = production;

        GameObject[] Requests = GameObject.FindGameObjectsWithTag("Request");

        for (int i = 0; i < Requests.Length; i++)
        {
            Debug.Log(Requests.Length);
            Request Reqscript = Requests[i].GetComponent<Request>();
            GameObject RequestHighLight = Requests[i].transform.Find("BlueHighLight").gameObject;
            if (Reqscript.request == Mini_scr.intHighLight)
            {
                Debug.Log(Reqscript.request);
                RequestHighLight.SetActive(true);
            }
        }

        RedHighLight.SetActive(true);
    }

    public void OffHightLight()
    {
        GameObject[] Requests = GameObject.FindGameObjectsWithTag("Request");

        for (int i = 0; i < Requests.Length; i++)
        {
            GameObject RequestHighLight = Requests[i].transform.Find("BlueHighLight").gameObject;
            RequestHighLight.SetActive(false);
        }

        RedHighLight.SetActive(false);
    }
}
