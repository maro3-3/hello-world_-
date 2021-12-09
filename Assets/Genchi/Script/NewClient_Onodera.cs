using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewClient_Onodera : MonoBehaviour
{

    public int ClieCountry = 0;//クライアントの国 
    public int ClieArea = 0;//クライアントの地域　
    public int ClieNum = 0;
    public int ClieLv = 0;
    [SerializeField] GameObject Client;
    [SerializeField] GameObject Object;
    DataBase database = null;
   

    int Arealv;

    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
    }

    void Update()
    {
        if (ClieLv > Arealv)
        {
            Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
            Client.SetActive(false);
        }
        else
        {
            Client.SetActive(true);
        }
    }
    public void OnTriggerStay(Collider other)
    {
        int num = Areamanager_Onodera.CheckClieNum(ClieCountry, ClieArea, ClieNum);
        if (other.gameObject.CompareTag("Player"))
        {
            Object.SetActive(true);

            if (Input.GetKey(KeyCode.Space))
            {
                database.clients[num].ClientNo = 1;//ミニゲームシーンへクライアント情報を渡す
                SceneManager.LoadScene("minigame");

            }
        }
   
    }
    private void OnTriggerExit(Collider other)
    {

        Object.SetActive(false);

    }
}
