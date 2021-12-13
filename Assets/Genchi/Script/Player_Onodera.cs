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
    [SerializeField] GameObject usiro;
    [SerializeField] GameObject migi;
    [SerializeField] GameObject hidari;

    public enum CharacterState
    {
        normal,
        talk
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
        
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        // いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            transform.position += velocity;
        }
    }
}