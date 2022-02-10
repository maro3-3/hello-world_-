using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class M_NextPage_kaneko : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject NextPage;
    [SerializeField] private GameObject PreviousPage;

    public void OnPointerClick(PointerEventData eventData)
    {
        PreviousPage.SetActive(false);
        NextPage.SetActive(true);
    }
}
