using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoSekai_Onodera1 : MonoBehaviour
{
    // public string teststring;
    //public Button button;
    [SerializeField] GameObject Object;
    //[SerializeField] GameObject PLAYER;

    public AudioClip sound;
    AudioSource audioSource;

    private float timer = 0;
    private float interval = 0.3f;
    private float scaleRate = 0.2f;


    void Start()
    {
            //PLAYER = GameObject.FindGameObjectWithTag("Player");
            audioSource = GetComponent<AudioSource>();

       

    }


    private void Update()
    {
        if (this.timer > 0)
        {
            this.timer -= Time.deltaTime;
            this.transform.localScale = (this.scaleRate * this.timer / this.interval) * Vector3.one;
        }
    }

    public void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Object.SetActive(true);

            if (Input.GetKey(KeyCode.Space))
            {
                //audioSource.Play();
                //SceneManager.LoadScene("SekaiGamen");
                this.timer = this.interval;
                audioSource.Play();
                StartCoroutine("GoToGameScene");

            }
           
        }
    }
    private void OnTriggerExit(Collider other)
    {

        Object.SetActive(false);

    }

    IEnumerator GoToGameScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("SekaiGamen");
    }



}
