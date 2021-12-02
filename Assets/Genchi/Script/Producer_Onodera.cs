using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Producer_Onodera : MonoBehaviour
{
    [SerializeField] GameObject Producer;
    public int ProdCountry = 0;//生産者の国 1アメリカ　   2中国　3ロシア　4オーストラリア　5南アフリカ
    public int ProdArea = 0;//生産者の地域　1ニューヨーク　北京　モスクワ キャンペラ　     プレトリア
                            //                    2セントルイス　上海　ウファ　 パース　         ブルームフォンテイン
                            //                    3アトランタ　　四川　　　　　 メルボルン　　　 ケープタウン
    public int ProdNum = 0;
    //DataBase database = new DataBase();
    //DataBase.Client[] clients;
    int Arealv;

    void Start()
    {

        Arealv = Areamanager_Onodera.GetArealv(ProdCountry, ProdArea);
    }

    void Update()
    {
        if (ProdNum > Arealv)
        {
            Arealv = Areamanager_Onodera.GetArealv(ProdCountry, ProdArea);
            Producer.SetActive(false);
        }
        else
        {
            Producer.SetActive(true);
        }
    }
}
