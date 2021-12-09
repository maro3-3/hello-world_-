using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Collision_Onodera : MonoBehaviour
{
    // Start is called before the first frame update
    // public string teststring;
    //public Button button;
    [SerializeField] GameObject Object;
    //[SerializeField] GameObject PLAYER;
    DataBase database = null;
    public int ClieCountry = 1;//クライアントの国 

    public int ClieArea = 1;//クライアントの地域　
    public int ClieNum = 1;

    void Start()
    {
        //PLAYER = GameObject.FindGameObjectWithTag("Player");
        database = Resources.Load<DataBase>("DataBase");
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
