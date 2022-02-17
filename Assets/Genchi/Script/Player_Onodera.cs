using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// プレイヤー
public class Player_Onodera : MonoBehaviour
{


    [SerializeField] private Vector3 velocity;              // 移動方向
    [SerializeField] private float moveSpeed = 5.0f;        // 移動速度
    [SerializeField] GameObject mae;
    [SerializeField] GameObject mae1;
    [SerializeField] GameObject mae2;
    [SerializeField] GameObject mae3;
    [SerializeField] GameObject mae4;
    [SerializeField] GameObject mae5;
    [SerializeField] GameObject mae6;
    [SerializeField] GameObject usiro;
    [SerializeField] GameObject usiro1;
    [SerializeField] GameObject usiro2;
    [SerializeField] GameObject usiro3;
    [SerializeField] GameObject usiro4;
    [SerializeField] GameObject usiro5;
    [SerializeField] GameObject usiro6;
    [SerializeField] GameObject migi;
    [SerializeField] GameObject migi1;
    [SerializeField] GameObject migi2;
    [SerializeField] GameObject migi3;
    [SerializeField] GameObject migi4;
    [SerializeField] GameObject migi5;
    [SerializeField] GameObject migi6;
    [SerializeField] GameObject hidari;
    [SerializeField] GameObject hidari1;
    [SerializeField] GameObject hidari2;
    [SerializeField] GameObject hidari3;
    [SerializeField] GameObject hidari4;
    [SerializeField] GameObject hidari5;
    [SerializeField] GameObject hidari6;

    public AudioClip sound;
    AudioSource audioSource;
    float walkcount = 0.0f;
    int walkcount2 = 0;

    public enum CharacterState
    {
        normal,
        talk
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        walkcount = 0.0f;
        walkcount2 = 0;
    }

    void Update()
    {

        
        
           
        
        
        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.S))
        {
            walkcount += 0.1f;
            velocity.z -= 1;
            mae.SetActive(true);
            usiro.SetActive(false);
            migi.SetActive(false);
            hidari.SetActive(false);
            hidari1.SetActive(false);
            hidari2.SetActive(false);
            hidari3.SetActive(false);
            hidari4.SetActive(false);
            hidari5.SetActive(false);
            hidari6.SetActive(false);
            migi1.SetActive(false);
            migi2.SetActive(false);
            migi3.SetActive(false);
            migi4.SetActive(false);
            migi5.SetActive(false);
            migi6.SetActive(false);
            usiro1.SetActive(false);
            usiro2.SetActive(false);
            usiro3.SetActive(false);
            usiro4.SetActive(false);
            usiro5.SetActive(false);
            usiro6.SetActive(false);

            if (walkcount >= 1.0f)
            {
                walkcount = 0.0f;
                walkcount2 += 1;
                if (walkcount2 >= 6)
                {
                    walkcount2 = 0;
                }
            }
            if (walkcount2 == 0)
            {
                mae.SetActive(false);
                mae1.SetActive(true);
                mae2.SetActive(false);
                mae3.SetActive(false);
                mae4.SetActive(false);
                mae5.SetActive(false);
                mae6.SetActive(false);
            }
            if (walkcount2 == 1)
            {
                mae.SetActive(false);
                mae1.SetActive(false);
                mae2.SetActive(true);
                mae3.SetActive(false);
                mae4.SetActive(false);
                mae5.SetActive(false);
                mae6.SetActive(false);
            }
            if (walkcount2 == 2)
            {
                mae.SetActive(false);
                mae1.SetActive(false);
                mae2.SetActive(false);
                mae3.SetActive(true);
                mae4.SetActive(false);
                mae5.SetActive(false);
                mae6.SetActive(false);
            }
            if (walkcount2 == 3)
            {
                mae.SetActive(false);
                mae1.SetActive(false);
                mae2.SetActive(false);
                mae3.SetActive(false);
                mae4.SetActive(true);
                mae5.SetActive(false);
                mae6.SetActive(false);
            }
            if (walkcount2 == 4)
            {
                mae.SetActive(false);
                mae1.SetActive(false);
                mae2.SetActive(false);
                mae3.SetActive(false);
                mae4.SetActive(false);
                mae5.SetActive(true);
                mae6.SetActive(false);
            }
            if (walkcount2 == 5)
            {
                mae.SetActive(false);
                mae1.SetActive(false);
                mae2.SetActive(false);
                mae3.SetActive(false);
                mae4.SetActive(false);
                mae5.SetActive(false);
                mae6.SetActive(true);
            }



        }
        else if (Input.GetKey(KeyCode.D))
        {
            walkcount += 0.1f;
            velocity.x += 1;
            mae.SetActive(false);
            usiro.SetActive(false);
            migi.SetActive(true);
            hidari.SetActive(false);
            mae1.SetActive(false);
            mae2.SetActive(false);
            mae3.SetActive(false);
            mae4.SetActive(false);
            mae5.SetActive(false);
            mae6.SetActive(false);
            hidari1.SetActive(false);
            hidari2.SetActive(false);
            hidari3.SetActive(false);
            hidari4.SetActive(false);
            hidari5.SetActive(false);
            hidari6.SetActive(false);
            usiro1.SetActive(false);
            usiro2.SetActive(false);
            usiro3.SetActive(false);
            usiro4.SetActive(false);
            usiro5.SetActive(false);
            usiro6.SetActive(false);

            if (walkcount >= 1.0f)
            {
                walkcount = 0.0f;
                walkcount2 += 1;
                if (walkcount2 >= 6)
                {
                    walkcount2 = 0;
                }
            }
            if (walkcount2 == 0)
            {
                migi.SetActive(false);
                migi1.SetActive(true);
                migi2.SetActive(false);
                migi3.SetActive(false);
                migi4.SetActive(false);
                migi5.SetActive(false);
                migi6.SetActive(false);
            }
            if (walkcount2 == 1)
            {
                migi.SetActive(false);
                migi1.SetActive(false);
                migi2.SetActive(true);
                migi3.SetActive(false);
                migi4.SetActive(false);
                migi5.SetActive(false);
                migi6.SetActive(false);
            }
            if (walkcount2 == 2)
            {
                migi.SetActive(false);
                migi1.SetActive(false);
                migi2.SetActive(false);
                migi3.SetActive(true);
                migi4.SetActive(false);
                migi5.SetActive(false);
                migi6.SetActive(false);
            }
            if (walkcount2 == 3)
            {
                migi.SetActive(false);
                migi1.SetActive(false);
                migi2.SetActive(false);
                migi3.SetActive(false);
                migi4.SetActive(true);
                migi5.SetActive(false);
                migi6.SetActive(false);
            }
            if (walkcount2 == 4)
            {
                migi.SetActive(false);
                migi1.SetActive(false);
                migi2.SetActive(false);
                migi3.SetActive(false);
                migi4.SetActive(false);
                migi5.SetActive(true);
                migi6.SetActive(false);
            }
            if (walkcount2 == 5)
            {
                migi.SetActive(false);
                migi1.SetActive(false);
                migi2.SetActive(false);
                migi3.SetActive(false);
                migi4.SetActive(false);
                migi5.SetActive(false);
                migi6.SetActive(true);
            }


        }
        else if (Input.GetKey(KeyCode.W))
        {
            walkcount += 0.1f;
            velocity.z += 1;
            mae.SetActive(false);
            usiro.SetActive(true);
            migi.SetActive(false);
            hidari.SetActive(false);
            mae1.SetActive(false);
            mae2.SetActive(false);
            mae3.SetActive(false);
            mae4.SetActive(false);
            mae5.SetActive(false);
            mae6.SetActive(false);
            hidari1.SetActive(false);
            hidari2.SetActive(false);
            hidari3.SetActive(false);
            hidari4.SetActive(false);
            hidari5.SetActive(false);
            hidari6.SetActive(false);
            migi1.SetActive(false);
            migi2.SetActive(false);
            migi3.SetActive(false);
            migi4.SetActive(false);
            migi5.SetActive(false);
            migi6.SetActive(false);

            if (walkcount >= 1.0f)
            {
                walkcount = 0.0f;
                walkcount2 += 1;
                if (walkcount2 >= 6)
                {
                    walkcount2 = 0;
                }
            }
            if (walkcount2 == 0)
            {
                usiro.SetActive(false);
                usiro1.SetActive(true);
                usiro2.SetActive(false);
                usiro3.SetActive(false);
                usiro4.SetActive(false);
                usiro5.SetActive(false);
                usiro6.SetActive(false);
            }
            if (walkcount2 == 1)
            {
                usiro.SetActive(false);
                usiro1.SetActive(false);
                usiro2.SetActive(true);
                usiro3.SetActive(false);
                usiro4.SetActive(false);
                usiro5.SetActive(false);
                usiro6.SetActive(false);
            }
            if (walkcount2 == 2)
            {
                usiro.SetActive(false);
                usiro1.SetActive(false);
                usiro2.SetActive(false);
                usiro3.SetActive(true);
                usiro4.SetActive(false);
                usiro5.SetActive(false);
                usiro6.SetActive(false);
            }
            if (walkcount2 == 3)
            {
                usiro.SetActive(false);
                usiro1.SetActive(false);
                usiro2.SetActive(false);
                usiro3.SetActive(false);
                usiro4.SetActive(true);
                usiro5.SetActive(false);
                usiro6.SetActive(false);
            }
            if (walkcount2 == 4)
            {
                usiro.SetActive(false);
                usiro1.SetActive(false);
                usiro2.SetActive(false);
                usiro3.SetActive(false);
                usiro4.SetActive(false);
                usiro5.SetActive(true);
                usiro6.SetActive(false);
            }
            if (walkcount2 == 5)
            {
                usiro.SetActive(false);
                usiro1.SetActive(false);
                usiro2.SetActive(false);
                usiro3.SetActive(false);
                usiro4.SetActive(false);
                usiro5.SetActive(false);
                usiro6.SetActive(true);
            }


        }
        else if (Input.GetKey(KeyCode.A))
        {
            walkcount +=  0.1f;
            velocity.x -= 1;
            mae.SetActive(false);
            usiro.SetActive(false);
            migi.SetActive(false);
            hidari.SetActive(true);
            mae1.SetActive(false);
            mae2.SetActive(false);
            mae3.SetActive(false);
            mae4.SetActive(false);
            mae5.SetActive(false);
            mae6.SetActive(false);
            migi1.SetActive(false);
            migi2.SetActive(false);
            migi3.SetActive(false);
            migi4.SetActive(false);
            migi5.SetActive(false);
            migi6.SetActive(false);
            usiro1.SetActive(false);
            usiro2.SetActive(false);
            usiro3.SetActive(false);
            usiro4.SetActive(false);
            usiro5.SetActive(false);
            usiro6.SetActive(false);

            if (walkcount >= 1.0f)
            {
                walkcount = 0.0f;
                walkcount2 += 1;
                if(walkcount2>=6)
                {
                    walkcount2 = 0;
                }
            }
            if(walkcount2==0)
            {
                hidari.SetActive(false);
                hidari1.SetActive(true);
                hidari2.SetActive(false);
                hidari3.SetActive(false);
                hidari4.SetActive(false);
                hidari5.SetActive(false);
                hidari6.SetActive(false);
            }
            if (walkcount2 == 1)
            {
                hidari.SetActive(false);
                hidari1.SetActive(false);
                hidari2.SetActive(true);
                hidari3.SetActive(false);
                hidari4.SetActive(false);
                hidari5.SetActive(false);
                hidari6.SetActive(false);
            }
            if (walkcount2 == 2)
            {
                hidari.SetActive(false);
                hidari1.SetActive(false);
                hidari2.SetActive(false);
                hidari3.SetActive(true);
                hidari4.SetActive(false);
                hidari5.SetActive(false);
                hidari6.SetActive(false);
            }
            if (walkcount2 == 3)
            {
                hidari.SetActive(false);
                hidari1.SetActive(false);
                hidari2.SetActive(false);
                hidari3.SetActive(false);
                hidari4.SetActive(true);
                hidari5.SetActive(false);
                hidari6.SetActive(false);
            }
            if (walkcount2 == 4)
            {
                hidari.SetActive(false);
                hidari1.SetActive(false);
                hidari2.SetActive(false);
                hidari3.SetActive(false);
                hidari4.SetActive(false);
                hidari5.SetActive(true);
                hidari6.SetActive(false);
            }
            if (walkcount2 == 5)
            {
                hidari.SetActive(false);
                hidari1.SetActive(false);
                hidari2.SetActive(false);
                hidari3.SetActive(false);
                hidari4.SetActive(false);
                hidari5.SetActive(false);
                hidari6.SetActive(true);
            }
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            mae.SetActive(true);
            mae1.SetActive(false);
            mae2.SetActive(false);
            mae3.SetActive(false);
            mae4.SetActive(false);
            mae5.SetActive(false);
            mae6.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            migi.SetActive(true);
            migi1.SetActive(false);
            migi2.SetActive(false);
            migi3.SetActive(false);
            migi4.SetActive(false);
            migi5.SetActive(false);
            migi6.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            usiro.SetActive(true);
            usiro1.SetActive(false);
            usiro2.SetActive(false);
            usiro3.SetActive(false);
            usiro4.SetActive(false);
            usiro5.SetActive(false);
            usiro6.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            hidari.SetActive(true);
            hidari1.SetActive(false);
            hidari2.SetActive(false);
            hidari3.SetActive(false);
            hidari4.SetActive(false);
            hidari5.SetActive(false);
            hidari6.SetActive(false);
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

        // いずれかの方向に移動している場合
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