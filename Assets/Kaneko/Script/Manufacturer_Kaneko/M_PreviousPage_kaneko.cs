using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class M_PreviousPage_kaneko : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject NextPage;
    [SerializeField] private GameObject PreviousPage;

    public void OnPointerClick(PointerEventData eventData)
    {
        NextPage.SetActive(false);
        PreviousPage.SetActive(true);
    }
}
