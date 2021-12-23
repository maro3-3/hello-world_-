using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;


public class Enemy : MonoBehaviour
{

    public enum EnemyState  // �G�l�~�[�̏��
    {
        ONE,
        TWO,
        THREE,
    }

    public EnemyState State = EnemyState.ONE;
    public EnemyState NextState = EnemyState.ONE;

    public Transform m_Transform;
    public Bullet[] m_BulletPrefab; // �e�̃v���n�u
    public int Bulletnumber;        // ���˂���e�̔ԍ�
    public float m_BulletSpeed;     // �e�̃X�s�[�h
    public float m_ShotTimer;       // �ˌ��^�C�~���O�Ǘ��^�C�}�[
    public float m_ShotInterval;    // �ˌ��Ԋu
    public float m_MoveTimer;       // �����ړ��Ǘ��^�C�}�[
    public float m_MoveInterval;    // �����ړ��Ԋu
    float m_Move = 1;        // ���]�p��1�˂�����ǂ���
    public float m_JumpTimer;       // �W�����v�^�C�~���O�Ǘ��^�C�}�[
    public float m_JumpInterval;    // �W�����v�Ԋu
    public float m_speed; // �ړ��̑���
    public float m_jump;  // �W�����v��
    public bool isGround; // �ڒn����
    public int m_MaxHp;   // �ő�̗�
    public int m_Hp;      // �̗�

    public GameObject target;
    public GameObject barrel;

    // Start is called before the first frame update
    void Start()
    {
        m_Hp = m_MaxHp;
        m_ShotInterval = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        switch (State)
        {
            case EnemyState.ONE:
                one();
                break;

            case EnemyState.TWO:
                two();
                break;

            case EnemyState.THREE:
                three();
                break;

            default:
                Debug.Log("�ǂ̂̏�Ԃɂ������Ă��Ȃ�");
                break;
        }

        // �ȉ��A�ˌ�����

        // �e�̔��˃^�C�~���O���Ǘ�����^�C�}�[���X�V����
        m_ShotTimer += Time.deltaTime;

        // �܂��e�̔��˃^�C�~���O�ł͂Ȃ��ꍇ�́A�����ŏ������I����
        if (m_ShotTimer < m_ShotInterval) return;

        // �e�̔��˃^�C�~���O���Ǘ�����^�C�}�[�����Z�b�g����
        m_ShotTimer = 0;

        var pos = m_Transform.position;
        var dir = target.transform.position - pos;
        var angle = Utils.GetAngle(Vector3.zero, dir);
        Shoot(angle, m_BulletSpeed);

        if (m_Hp <= 0)
            Destroy(this.gameObject);
    }



    private void one()
    {
        if (m_Hp <= 10)
        {
            SetState(EnemyState.TWO);
            m_ShotInterval = 1.5f;
        }
    }

    private void two()
    {
        // �����ړ��^�C�}�[�X�V
        m_MoveTimer += Time.deltaTime;
        // ���]����
        if (m_MoveTimer >= m_MoveInterval)
        {
            // �����ړ����Ǘ�����^�C�}�[�����Z�b�g�����]
            m_MoveTimer = 0;
            m_Move *= -1;
        }
        transform.Translate(m_Move * Vector3.left * Time.deltaTime);

        if (m_Hp <= 5)
        {
            SetState(EnemyState.THREE);
            m_ShotInterval = 0.6f;
        }
    }

    private void three()
    {
        // �����ړ��^�C�}�[�X�V
        m_MoveTimer += Time.deltaTime;
        // ���]����
        if (m_MoveTimer >= m_MoveInterval)
        {
            // �����ړ����Ǘ�����^�C�}�[�����Z�b�g�����]
            m_MoveTimer = 0;
            m_Move *= -1;
        }
        transform.Translate(m_Move * Vector3.left * Time.deltaTime);

        if(isGround)
        {
            // �W�����v�^�C�~���O���Ǘ�����^�C�}�[���X�V����
            m_JumpTimer += Time.deltaTime;

            // �W�����v�^�C�~���O�������ꍇ�W�����v����B
            if (m_JumpTimer >= m_JumpInterval)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, m_jump, 0);
                // �W�����v�^�C�~���O���Ǘ�����^�C�}�[�����Z�b�g����
                m_JumpTimer = 0;

                SEManager.Instance.Play("Jump");
            }
        }

    }

    private void Shoot(float angle, float speed)
    {
        var pos = barrel.transform.position; // �v���C���[�̈ʒu
        var rot = transform.localRotation; // �v���C���[�̌���

        Bulletnumber = Random.Range(0, m_BulletPrefab.Length);

        // ���˂���e�𐶐�����(��ނ̓����_��)
        var Bullet = Instantiate(m_BulletPrefab[Bulletnumber], pos, rot);

        // �e�𔭎˂�������Ƒ�����ݒ肵����
        Bullet.Init(angle, speed, Bulletnumber);

        // ����SE
        switch (Bulletnumber)
        {
            case 0:
                SEManager.Instance.Play("Attack1");
                break;
            case 1:
                SEManager.Instance.Play("Attack2");
                break;
            case 2:
                SEManager.Instance.Play("Attack3");
                break;
            default:
                Debug.Log("����SE�ɂĈُ�");
                break;
        }
    }

    private void SetState(EnemyState nextstate)
    {
        State = nextstate;
    }

    void OnCollisionStay(Collision collision)
    {
        // �n�ʐڒn����
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // �n�ʗ��E����
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �n�ʒ��n����
        if (collision.gameObject.tag == "Ground")
        {
            SEManager.Instance.Play("Landing");
        }
    }
}

