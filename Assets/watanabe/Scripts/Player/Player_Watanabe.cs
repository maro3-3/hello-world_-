using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Watanabe : MonoBehaviour
{
    public Transform m_Transform;
    public Bullet[] m_BulletPrefab; // �e�̃v���n�u
    public int Bulletnumber; // ���˂���e�̔ԍ�
    public float m_BulletSpeed;// �e�̃X�s�[�h
    public float m_speed; // �ړ��̑���
    public float m_jump;  // �W�����v��
    public int m_MaxHp;   // �ő�̗�
    public int m_Hp;      // �̗�

    public GameObject enemy;
    public GameObject barrel;

    // Start is called before the first frame update
    void Start()
    {
        m_Hp = m_MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKey("d"))
      {
            transform.position += transform.right * m_speed * Time.deltaTime;
      }
      if (Input.GetKey("a"))
       {
            transform.position -= transform.right * m_speed * Time.deltaTime;
      }
      if (Input.GetKeyDown("e"))
      {
         if (Bulletnumber == 2)
          {
                Bulletnumber = 0;
          }
          else
           {
                Bulletnumber++;
           }
       }
      if (Input.GetKeyDown("space"))
        {
            var pos = m_Transform.position;
            var dir = enemy.transform.position - pos;
            var angle = Utils.GetAngle(Vector3.zero, dir);
            Shoot(angle, m_BulletSpeed);
       }

        // ��]���Ȃ��悤�Ɋp�x���Œ肷��
        m_Transform = this.transform;
        Vector3 localAngle = m_Transform.localEulerAngles;
        localAngle.x = 0.0f;
        localAngle.y = 0.0f;
        localAngle.z = 0.0f;
        m_Transform.localEulerAngles = localAngle;

        if(m_Hp <= 0)
        Destroy(this.gameObject);
    }

    void OnCollisionStay(Collision collision)
    {
        // �n��(Ground)�ɐڐG���Ă���ꍇw�ŃW�����v�ł���
        if (collision.gameObject.tag == "Ground")
        {
          if (Input.GetKey("w"))
          {
                GetComponent<Rigidbody>().velocity = new Vector3(0, m_jump, 0);
          }
        }
    }

    private void Shoot(float angle,float speed)
    {
        var pos = barrel.transform.position; // �v���C���[�̈ʒu
        var rot = transform.localRotation; // �v���C���[�̌���

        // ���˂���e�𐶐�����
        var Bullet = Instantiate(m_BulletPrefab[Bulletnumber], pos, rot);

        // �e�𔭎˂�������Ƒ�����ݒ肷��
        Bullet.Init(angle, speed, Bulletnumber);
    }
}
