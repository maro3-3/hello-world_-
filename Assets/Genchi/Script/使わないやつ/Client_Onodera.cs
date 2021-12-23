using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Client_Onodera : MonoBehaviour

{
   
    [SerializeField] GameObject Client;
    public int ClieCountry = 0;//クライアントの国 

    public int ClieArea = 0;//クライアントの地域　
    public int ClieNum = 0;
    public int ClieLv = 0;
    
    int Arealv;

    void Start()
    {
        
        Arealv = Areamanager_Onodera.GetArealv(ClieCountry, ClieArea);
    }

    void Update()
    {
       if( ClieLv>Arealv)
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
