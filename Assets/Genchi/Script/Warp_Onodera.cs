using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp_Onodera : MonoBehaviour
{
    public Vector3 pos;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
