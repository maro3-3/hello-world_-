using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // ���g��Transform
    [SerializeField] private Transform _self;

    // �^�[�Q�b�g��Transform
    [SerializeField] private Transform _target;

    private void Update()
    {
        // �^�[�Q�b�g�̕����Ɏ��g����]������
        _self.LookAt(_target);
    }
}
