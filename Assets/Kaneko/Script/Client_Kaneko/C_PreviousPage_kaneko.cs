using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class C_PreviousPage_kaneko : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject NextPage;
    [SerializeField] private GameObject PreviousPage;

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        NextPage.SetActive(false);
        PreviousPage.SetActive(true);

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
