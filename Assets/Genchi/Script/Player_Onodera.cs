using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// �v���C���[
public class Player_Onodera : MonoBehaviour
{

    [SerializeField] private Vector3 velocity;              // �ړ�����
    [SerializeField] private float moveSpeed = 5.0f;        // �ړ����x
    [SerializeField] GameObject mae;
    [SerializeField] GameObject usiro;
    [SerializeField] GameObject migi;
    [SerializeField] GameObject hidari;

    public AudioClip sound;
    AudioSource audioSource;

    public enum CharacterState
    {
        normal,
        talk
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        
        
           
        
        
        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.S))
        {
            velocity.z -= 1;
            mae.SetActive(true);
            usiro.SetActive(false);
            migi.SetActive(false);
            hidari.SetActive(false);
           
        }
        else if (Input.GetKey(KeyCode.D))
        {
            velocity.x += 1;
            mae.SetActive(false);
            usiro.SetActive(false);
            migi.SetActive(true);
            hidari.SetActive(false);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            velocity.z += 1;
            mae.SetActive(false);
            usiro.SetActive(true);
            migi.SetActive(false);
            hidari.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= 1;
            mae.SetActive(false);
            usiro.SetActive(false);
            migi.SetActive(false);
            hidari.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.Play();
        }
        
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        // �����ꂩ�̕����Ɉړ����Ă���ꍇ
        if (velocity.magnitude > 0)
        {
            
            transform.position += velocity;
        }
        else
        {
            audioSource.Stop();
        }
    }
}