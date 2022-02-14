using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class TitleSound_Tanaka : MonoBehaviour
{

    void Start()
    {
        BGMManager.Instance.Play(BGMPath.TITLE, 1, 15, 1, true, true);
    }

   
}
