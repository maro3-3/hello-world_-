using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//���݂̌��p�̃X�N���v�g
public class Month_Tanaka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        monthCount();//���݂̌��v�Z
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void monthCount()//���݂̌��v�Z
    {
        //�^�[���擾
        int turn = 7;//��

        int count = 0;//�J�E���g�p

        while (turn > 3)//�^�[�����R�ȉ��ɂȂ�܂łS�Ŋ���
        {
            turn /= 4;
            count++;
        }

        count += 4;//�X�^�[�g���S���Ȃ̂łS�𑫂�

        if (count > 12)//�P�Q��葽�������ꍇ�P�Q�Ŋ��������܂�����߂�
        {
            count %= 12;
        }

        string monthNumS = count.ToString();//string�ɕϊ�
        gameObject.GetComponent<Text>().text = monthNumS;//�o��
    }
}
