using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Vector3 m_velocity; // ���x

    public int Bulletnumber;    // �e�̔ԍ�

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Init(float angle, float speed , int number)
    {
        Bulletnumber = number;

        // �e�̔��ˊp�x���x�N�g���ɕϊ�����
        var direction = Utils.GetDirection(angle);

        // ���ˊp�x�Ƒ������瑬�x�����߂�
        m_velocity = direction * speed;

        // �e���i�s�����������悤�ɂ���
        var angles = transform.localEulerAngles;
        angles.z = angle - 90;
        transform.localEulerAngles = angles;

        // 2 �b��ɍ폜����
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        // �ړ�����
        transform.localPosition += m_velocity;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            GameObject obj = collision.gameObject;
            Bullet script = obj.GetComponent<Bullet>();
            int number = script.Bulletnumber;

            if (Bulletnumber == number)
            {
                Debug.Log("�������Ȃ̂ł��݂�����");
                Destroy(this.gameObject);
                return;
            }
            if ((Bulletnumber == 0) && (number == 2))
            {
                 Debug.Log("�s�������Ȃ̂ŏ���");
                 Destroy(this.gameObject);
                 return;
            }
            if ((Bulletnumber == 1) && (number == 0))
            {
                Debug.Log("�s�������Ȃ̂ŏ���");
                Destroy(this.gameObject);
                return;
            }
            if ((Bulletnumber == 2) && (number == 1))
            {
                Debug.Log("�s�������Ȃ̂ŏ���");
                Destroy(this.gameObject);
                return;
            }
        }

        if(collision.gameObject.tag == "Player")
        {
            GameObject obj = collision.gameObject;
            Player_Watanabe script = obj.GetComponent<Player_Watanabe>();
            script.m_Hp += -1;

            Debug.Log("�v���C���[�ɖ���");
            Destroy(this.gameObject);
            return;
        }
        
        if(collision.gameObject.tag == "Enemy")
        {
            GameObject obj = collision.gameObject;
            Enemy script = obj.GetComponent<Enemy>();
            script.m_Hp += -1;

            Debug.Log("�G�ɖ���");
            Destroy(this.gameObject);
            return;
        }
    }

}
