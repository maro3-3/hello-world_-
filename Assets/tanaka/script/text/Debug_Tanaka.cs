using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Debug_Tanaka : MonoBehaviour
{
    [SerializeField] Area_Tanaka area_t = null;//エリアのデータ
    // Start is called before the first frame update
    void Start()
    {
        int a = area_t.area;
        string b = a.ToString();
        gameObject.GetComponent<Text>().text = b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
