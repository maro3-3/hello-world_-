using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//ミッション報酬受け取りボタン用スクリプト
public class ReceiveMission_Tanaka : MonoBehaviour
{

    [SerializeField] GameObject frame1;
    [SerializeField] GameObject frame2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        frame1.SetActive(true);
        frame2.SetActive(true);
    }
}
