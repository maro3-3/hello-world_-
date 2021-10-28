using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMinigame_Onodera : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("kari");
    }
}
