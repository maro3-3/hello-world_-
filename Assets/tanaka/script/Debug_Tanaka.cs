using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Debug_Tanaka : MonoBehaviour
{
    [SerializeField] Area_Tanaka database = null;
    // Start is called before the first frame update
    void Start()
    {
        int unemployedNum = database.area;
        string unemployedNumS = unemployedNum.ToString();
        gameObject.GetComponent<Text>().text = unemployedNumS;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
