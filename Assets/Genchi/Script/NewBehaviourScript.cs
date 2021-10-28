using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 自身のTransform
    [SerializeField] private Transform _self;

    // ターゲットのTransform
    [SerializeField] private Transform _target;

    private void Update()
    {
        // ターゲットの方向に自身を回転させる
        _self.LookAt(_target);
    }
}
