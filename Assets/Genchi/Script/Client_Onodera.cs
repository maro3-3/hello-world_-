using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Client_Onodera : MonoBehaviour

{
    // Start is called before the first frame update
    // public string teststring;
    //public Button button;
    [SerializeField] GameObject Client;
    public int ClieCountry = 0;//クライアントの国 1アメリカ　   2中国　3ロシア　4オーストラリア　5南アフリカ
    public int ClieArea = 0;//クライアントの地域　1ニューヨーク　北京　モスクワ キャンペラ　     プレトリア
                            //                    2セントルイス　上海　ウファ　 パース　         ブルームフォンテイン
                            //                    3アトランタ　　四川　　　　　 メルボルン　　　 ケープタウン
    public int ClieNum = 0;
    //DataBase database = new DataBase();
    //DataBase.Client[] clients;
    int Arealv;

    void Start()
    {
        
        Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
    }

    void Update()
    {
       if( ClieNum>Arealv)
        {
            Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
            Client.SetActive(false);
        }
        else
        {
            Client.SetActive(true);
        }
    }

}
