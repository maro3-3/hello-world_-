using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Production : MonoBehaviour // クリックではなくハイライトだけで値を渡す
{
    public int production; // 仮データ
    public bool Choice;

    // Start is called before the first frame update
    void Start()
    {
        Choice = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickProduction()
    {
        Choice = true;
    }
}
