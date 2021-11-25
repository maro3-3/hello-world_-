using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collision_Onodera : MonoBehaviour
{
    // Start is called before the first frame update
    // public string teststring;
    //public Button button;
    [SerializeField] GameObject Object;
    [SerializeField] GameObject PLAYER;



    void Start()
    {
        PLAYER = GameObject.FindGameObjectWithTag("Player");
 
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject == PLAYER)
        {
            Object.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Object.SetActive(false);
    }
  


}
