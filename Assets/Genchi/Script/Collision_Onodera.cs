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



    void Start()
    {
        //PLAYER = GameObject.FindGameObjectWithTag("Player");
 
    }

    public void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Object.SetActive(true);
        
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("minigame");
        }
        }
    }
    private void OnTriggerExit(Collider other)
    {
       
            Object.SetActive(false);
        
    }


}
