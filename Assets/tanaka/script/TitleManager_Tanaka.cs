using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class TitleManager_Tanaka : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] GameObject title;
    [SerializeField] GameObject movie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var currentBGMNames = BGMManager.Instance.GetCurrentAudioNames();
       

        if (currentBGMNames[0] == "Title")
        {
            button.SetActive(true);
            title.SetActive(true);
            movie.SetActive(false);
        }

    }
}
