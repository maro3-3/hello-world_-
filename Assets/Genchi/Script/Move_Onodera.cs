using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Onodera : MonoBehaviour
{
    public GameObject point;
    public GameObject chara;

    
    private void OnTriggerEnter(Collider other)
    {
        Vector3 pos = point.transform.position;

       // if (other.name == chara.name)
        //{
            pos.y += 1;
            //Chara���ڐG������point�I�u�W�F�N�g�̈ʒu�Ɉړ�����
            chara.transform.position = pos;

       // }
    }
}
