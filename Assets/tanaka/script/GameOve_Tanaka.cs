using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOve_Tanaka : MonoBehaviour
{
    [SerializeField] RectTransform image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        image.position -= new Vector3(0.0f, 0.1f, 0);
       
        if (image.position.y<100)
        {
            
            SceneManager.LoadScene("Title");
        }
    }
}
