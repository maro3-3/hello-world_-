using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Drone2Text_Tanaka : MonoBehaviour
{
    [SerializeField] DataBase database = null;
    [SerializeField] int area;
    [SerializeField] Text a;
    [SerializeField] Text b;
    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        a.GetComponent<Text>().text = database.clients[area].ClientLv.ToString();
        b.GetComponent<Text>().text = database.clients[area].Performance.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
